using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DocumentFormat.OpenXml.Wordprocessing;
using Color = System.Drawing.Color;

namespace KIEMSOAT_RAVAO
{
    public partial class CONCAT : Form
    {
        // Biến lưu trữ số cũ (txtinput0)
        private string strInputCu = "";

        public CONCAT()
        {
            InitializeComponent();
            RegisterButtonEvents();
        }

        // Sự kiện Load Form
        private void CONCAT_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        // --- HÀM TẢI DỮ LIỆU BẤT ĐỒNG BỘ ---
        private async void LoadDataAsync()
        {
            try
            {
                gridControl5.DataSource = null;
                DataTable dt = new DataTable();

                await Task.Run(() =>
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    using (SqlConnection cn = new SqlConnection(connectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("Pivot_D_Data_6", cn))
                        {
                            command.CommandTimeout = 300;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                da.Fill(dt);
                            }
                        }
                    }
                });

                if (dt.Rows.Count > 0)
                {
                    gridControl5.DataSource = dt;
                    gridView5.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Tắt icon chờ nếu có
            }
        }

        // --- HÀM ĐĂNG KÝ SỰ KIỆN NÚT ---
        private void RegisterButtonEvents()
        {
            btn1.Click += NumberButton_Click;
            btn2.Click += NumberButton_Click;
            btn3.Click += NumberButton_Click;
            btn4.Click += NumberButton_Click;
            btn5.Click += NumberButton_Click;
            btn6.Click += NumberButton_Click;

            // Nút Clean All
            simpleButton1.Click += simpleButton1_Click;
            // Nút Xóa 1 (Giả định nút Xóa 1 là simpleButton13)
            // simpleButton13.Click += simpleButton13_Click; 
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            if (btn == null) return;
            string number = btn.Text;
            AddNumberToInput(number);
        }

        // --- LOGIC NHẬP VÀ XỬ LÝ SỐ (TỪ NÚT BẤM) ---
        private void AddNumberToInput(string number)
        {
            string currentText = txtInput.Text;

            // Logic nhập số: Nếu đã đủ 3 ký tự hoặc rỗng thì gán mới, nếu không thì nối
            if (string.IsNullOrEmpty(currentText) || currentText.Length >= 3)
            {
                txtInput.Text = number;
            }
            else
            {
                txtInput.Text += number;
            }

            // Xử lý khi đủ 3 số
            if (txtInput.Text.Length == 3)
            {
                // 1. LỌC TRƯỚC: Lấy lịch sử hiện tại + số cũ + số mới để lọc
                LocDuLieu();

                // 2. TÍNH TOÁN VÀ CẬP NHẬT LỊCH SỬ T/X
                KiemTraVaGhiLog();

                // 3. LƯU SỐ MỚI LÀM SỐ CŨ cho lần nhập tiếp theo
                strInputCu = new string(txtInput.Text.Where(char.IsDigit).ToArray());
            }
        }

        // --- LOGIC TÍNH T/X VÀ GHI VÀO RICHBOX ---
        private void KiemTraVaGhiLog()
        {
            string text = txtInput.Text.Trim();

            if (text.Length < 3) return;

            int sum = 0;
            foreach (char c in text)
            {
                if (char.IsDigit(c)) sum += int.Parse(c.ToString());
            }

            string ketQua = (sum > 10) ? "T" : "X";

            // 1. Lấy chuỗi T/X hiện tại và nối thêm kết quả mới
            string currentContent = richTextBox2.Text;
            string newContent = currentContent + ketQua;

            // 2. Cắt chuỗi nếu dài quá 6 ký tự
            if (newContent.Length > 6)
            {
                newContent = newContent.Substring(newContent.Length - 6);
            }

            // 3. Gọi hàm vẽ lại màu
            HienThiMau(newContent);
        }

        // --- HÀM HIỂN THỊ MÀU (TÔ MÀU X=BLUE, T=MAROON) ---
        private void HienThiMau(string chuoiHienThi)
        {
            richTextBox2.Clear();

            foreach (char c in chuoiHienThi)
            {
                if (c == 'X')
                {
                    richTextBox2.SelectionColor = Color.Blue;
                }
                else if (c == 'T')
                {
                    richTextBox2.SelectionColor = Color.Maroon;
                }
                else
                {
                    richTextBox2.SelectionColor = Color.Black;
                }

                richTextBox2.AppendText(c.ToString());
            }
            richTextBox2.SelectionStart = richTextBox2.Text.Length;
            richTextBox2.ScrollToCaret();
        }

        // --- HÀM LỌC DỮ LIỆU THEO CHUỖI DÀI 12 KÝ TỰ ---
        private void LocDuLieu()
        {
            try
            {
                // --- 1. LẤY LỊCH SỬ T/X (Đã làm sạch) ---
                string rawText = richTextBox2.Text;
                string cleanHistory = "";
                foreach (char c in rawText)
                {
                    if (c == 'T' || c == 'X') cleanHistory += c;
                }

                // --- 2. LẤY SỐ CŨ VÀ SỐ MỚI (CHỈ LẤY CHỮ SỐ) ---

                // Dùng LINQ để đảm bảo chỉ lấy các ký tự là chữ số từ input
                string sCurrentRaw = txtInput.Text;
                string sOldRaw = strInputCu;

                // Bỏ qua các ký tự không phải số
                string sCurrent = new string(sCurrentRaw.Where(char.IsDigit).ToArray());
                string sOld = new string(sOldRaw.Where(char.IsDigit).ToArray());

                // --- 3. KIỂM TRA ĐỦ DỮ LIỆU ---
                if (cleanHistory.Length < 6 || sOld.Length != 3 || sCurrent.Length != 3)
                {
                    gridView5.ActiveFilterString = "";
                    return;
                }

                // --- 4. GHÉP CHUỖI ---
                string s6 = cleanHistory.Substring(cleanHistory.Length - 6);

                // Chuỗi ghép: [T/X 6] + [Số Cũ 3] + [Số Mới 3]
                string chuoiCanLoc = s6 + sOld + sCurrent;

                // Debug: Hiện thông báo để bạn đối chiếu xem chuỗi đã sạch chưa
                // MessageBox.Show($"Chuỗi lọc: {chuoiCanLoc}\nLịch sử T/X: {s6}\nSố Cũ: {sOld}\nSố Mới: {sCurrent}", "Kiểm tra Chuỗi Sạch");

                // --- 5. LỌC ---
                gridView5.ActiveFilterString = $"[DATA] LIKE '%{chuoiCanLoc}'";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        // --- XỬ LÝ SỰ KIỆN NÚT KHÁC ---

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            // Tùy chọn: Xóa luôn lịch sử
            // richTextBox2.Clear();
            // strInputCu = "";
        }

        // Hàm Xóa 1 (Áp dụng cho nút XÓA 1)
        private void xoa1()
        {
            // Lấy giá trị hiện tại của ô lọc tự động cột DATA
            object filterValue = gridView5.GetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "DATA");

            if (filterValue is string filterString && filterString.Length > 0)
            {
                // Tìm vị trí của % (nếu có)
                int startIndex = filterString.StartsWith("%") ? 1 : 0;

                if (filterString.Length - startIndex > 0)
                {
                    // Lấy toàn bộ chuỗi trừ ký tự cuối cùng
                    string newFilterText = filterString.Substring(startIndex, filterString.Length - startIndex - 1);

                    // Khôi phục lại dấu % ở đầu (nếu nó có ban đầu)
                    if (filterString.StartsWith("%"))
                    {
                        newFilterText = "%" + newFilterText;
                    }

                    // Đặt lại giá trị đã chỉnh sửa vào dòng lọc tự động
                    gridView5.SetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "DATA", newFilterText);
                }
                else
                {
                    // Nếu chỉ còn %, xóa sạch
                    gridView5.SetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "DATA", string.Empty);
                }
            }
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            xoa1();
        }

        // --- LOGIC TÔ MÀU HÀNG GRIDVIEW (Cot10) ---
        private void gridView5_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.Column.FieldName == "Cot10" && e.RowHandle >= 0)
            {
                object cellValue = view.GetRowCellValue(e.RowHandle, "Cot10");
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    if (int.TryParse(cellValue.ToString(), out int VALUE))
                    {
                        if (VALUE <= 10)
                        {
                            e.Appearance.BackColor = Color.LightYellow; // X
                        }
                        else if (VALUE > 10)
                        {
                            e.Appearance.BackColor = Color.Pink; // T
                        }
                    }
                }
            }
        }
    }
}