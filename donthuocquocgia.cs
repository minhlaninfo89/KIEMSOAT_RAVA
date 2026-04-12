using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIEMSOAT_RAVAO
{
    public partial class donthuocquocgia : Form
    {

        public donthuocquocgia()
        {
            InitializeComponent();
        }
        private string apiUrl = "https://api.donthuocquocgia.vn/api/v1/them-bac-si"; // Thay thế URL của API của bạn
        private string apiToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLmRvbnRodW9jcXVvY2dpYS52bi9hcGkvYXV0aC9kYW5nLW5oYXAtY28tc28ta2hhbS1jaHVhLWJlbmgiLCJpYXQiOjE3MTY4MDU0MzUsImV4cCI6MTcxNzQxMDIzNSwibmJmIjoxNzE2ODA1NDM1LCJqdGkiOiJKU3BMRnlHVzlwMEwxeXozIiwic3ViIjoiNjU4MTZhNGQ0ZWRkYTk0MWQ4MmZmZGM0IiwicHJ2IjoiODdlMGFmMWVmOWZkMTU4MTJmZGVjOTcxNTNhMTRlMGIwNDc1NDZhYSJ9.4sMt032LTz43RJ-UxxSbWqNR6gp5Ka7yOYkOt81YvHU"; // Thay thế token của bạn

        private async void simpleButton3_Click(object sender, EventArgs e)
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
                    string mabs = "0159NT-CCHN";

                    // Data to send (e.g., JSON)
                    string jsonData = "{\"ma_lien_thong_bac_si\": \"0159NT-CCHN\"}";

                    // Create the request content
                    HttpContent content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");

                    // Perform the POST request
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    // Ensure that the request was successful
                    response.EnsureSuccessStatusCode();

                    // Read the data received from the API response
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Display the data in a TextBox or any other appropriate UI control
                    txtResponse.Text = responseBody;
                }
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP request errors
                MessageBox.Show($"Error sending request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bsphien"].ConnectionString);
        private async void simpleButton4_Click(object sender, EventArgs e)
        {
  
            if (cn.State == ConnectionState.Closed)
                    cn.Open();
                var sql = @"select '123' as ma_thuoc,Ten_Thuoc as biet_duoc,Ten_Thuoc, 'Viên' as don_vi_tinh,'12' as soluong,N'uống' as cachdung
                                from Toathuocchitiet a
                                join DM_Duoc b on b.Duoc_id = a.Duoc_id
                                where MaDonThuoc ='MDT.202240371767' and a.Duoc_id =18265";
            
            SqlCommand command = new SqlCommand(sql,cn);
            command.Connection = cn;
            command.ExecuteNonQuery();



            try
            {
                var apiUrl = "https://api.donthuocquocgia.vn/api/v1/gui-don-thuoc"; // Thay thế URL của API của bạn
                var apiKey = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLmRvbnRodW9jcXVvY2dpYS52bi9hcGkvYXV0aC9kYW5nLW5oYXAtYmFjLXNpIiwiaWF0IjoxNzE3MDU1MzczLCJleHAiOjE3MTc2NjAxNzMsIm5iZiI6MTcxNzA1NTM3MywianRpIjoiTERmV1FZS0VKdFpTcmVWSSIsInN1YiI6IjVmNjFkYTYxYzM5YzI0NGI1NzYyMmVkNSIsInBydiI6Ijg3ZTBhZjFlZjlmZDE1ODEyZmRlYzk3MTUzYTE0ZTBiMDQ3NTQ2YWEifQ.hcHtuMLiwhK5j-LEtgonQ6mkP7Z4uU5qr74Tax-LU34"; // Thay thế token của bạn

                var donThuoc = new
                {
                    //ngay_xuat = DateTime.Now.ToString("yyyy-MM-dd"),
                    //loai_phieu_xuat = 0,
                    //ghi_chu = "Đơn thuốc mẫu",
                    //ma_co_so_nhan = "CS001",
                    //ten_co_so_nhan = "Bệnh viện A",
                    loai_don_thuoc = "c",
                    ma_don_thuoc = "583210015L12-c",
                    ho_ten_benh_nhan = "TEST",
                    ngay_sinh_benh_nhan = "18/09/1989",
                    gioi_tinh = "1",
                    dia_chi = "BỆNH VIỆN ĐA KHOA TỈNH NINH THUẬN",
                    chan_doan = new[]
                    {
                            new
                            {
                                ma_chan_doan = "I10",
                                ten_chan_doan = "I10-THA: Tăng huyết áp",
                                ket_luan = "10",
                            }
                        },
                    hinh_thuc_dieu_tri = "1",
                    thong_tin_don_thuoc = new[]
                    {
                        sql
                            //new
                            //{
                            //    ma_thuoc = "123",
                            //    biet_duoc = "456",
                            //    ten_thuoc = "789",
                            //    don_vi_tinh = "Viên",
                            //    so_luong = "4",
                            //    cach_dung = "23",

                            //  },
           //new {ma_thuoc="18265",
           //    biet_duoc="Klamentin (Amoxicilin + Acid clavulanic)",
           //    ten_thuoc="Klamentin (Amoxicilin + Acid clavulanic)",
           //    don_vi_tinh="Klamentin (Amoxicilin + Acid clavulanic)",
           //    so_luong="10",
           //    cach_dung="Klamentin (Amoxicilin + Acid clavulanic)",
           //},
        },
                    loi_dan = "",
                    so_dien_thoai_nguoi_kham_benh = "012345678",
                    ngay_gio_ke_don = "2023-12-01 00:00:00",
                };

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(donThuoc), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Đã gửi đơn thuốc thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show($"Error sending request:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }
    
}



    


      