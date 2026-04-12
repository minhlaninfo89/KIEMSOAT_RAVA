using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

// Using cho iText 7
using iText.Kernel.Pdf;
using iText.Signatures;

// Using cho BouncyCastle (QUAN TRỌNG)
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509; // Để dùng X509Certificate gốc

namespace KIEMSOAT_RAVAO
{
    public partial class KSK : Form
    {
        private string _selectedFilePath = string.Empty;

        public KSK()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedFilePath = openFileDialog.FileName;
                    lblFilePath.Text = "Đã chọn: " + Path.GetFileName(_selectedFilePath);
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedFilePath)) return;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(_selectedFilePath) + "_signed.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SignPdf(_selectedFilePath, saveFileDialog.FileName);
                        MessageBox.Show("Ký số thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void SignPdf(string inputPath, string outputPath)
        {
            // 1. Lấy chứng thư từ USB
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            X509Certificate2Collection sel = X509Certificate2UI.SelectFromCollection(
                store.Certificates, "Chọn chứng thư", "Chọn USB Viettel-CA", X509SelectionFlag.SingleSelection);

            if (sel.Count == 0) { store.Close(); return; }
            X509Certificate2 cert = sel[0];
            store.Close();

            // 2. Ký số iText 7
            using (PdfReader reader = new PdfReader(inputPath))
            using (FileStream os = new FileStream(outputPath, FileMode.Create))
            {
                PdfSigner signer = new PdfSigner(reader, os, new StampingProperties());

                // --- SỬA LỖI TẠI ĐÂY ---
                // iText 7 dùng trực tiếp chứng thư của BouncyCastle, không cần wrapper
                Org.BouncyCastle.X509.X509Certificate bcCert = DotNetUtilities.FromX509Certificate(cert);

                // Tạo mảng chứng thư trực tiếp
                Org.BouncyCastle.X509.X509Certificate[] chain = { bcCert };

                // Gọi lớp ký
                IExternalSignature externalSignature = new ViettelSignatureV7(cert);

                // Truyền chain trực tiếp vào (Argument 2 đã khớp kiểu dữ liệu)
                signer.SignDetached(externalSignature, chain, null, null, null, 0, PdfSigner.CryptoStandard.CMS);
            }
        }
    }

    // --- LỚP KÝ SỐ VIETTEL (CHUẨN ITEXT 7) ---
    public class ViettelSignatureV7 : IExternalSignature
    {
        private readonly X509Certificate2 _cert;

        public ViettelSignatureV7(X509Certificate2 cert)
        {
            _cert = cert;
        }

        public string GetHashAlgorithm() => "SHA-256";

        public string GetEncryptionAlgorithm() => "RSA";

        public byte[] Sign(byte[] message)
        {
            // Yêu cầu .NET Framework 4.7.2 trở lên để có GetRSAPrivateKey
            using (RSA rsa = _cert.GetRSAPrivateKey())
            {
                if (rsa == null) throw new Exception("Không tìm thấy Private Key. Hãy cắm USB!");
                return rsa.SignData(message, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            }
        }
    }
}