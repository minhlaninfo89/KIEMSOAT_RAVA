using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using DevExpress.CodeParser;
using DevExpress.XtraBars.Docking2010.Views.Widget;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DocumentFormat.OpenXml.Wordprocessing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Color = System.Drawing.Color;
using Excel = Microsoft.Office.Interop.Excel;

namespace KIEMSOAT_RAVAO
{
    public partial class FindNextSO : Form
    {
        public FindNextSO()
        {
            InitializeComponent();
            this.Load += FindNextSO_Load; // Gắn sự kiện Load cho Form
        }
        private void UpdateProgressBar(int progress)
        {
            //if (progressBar.InvokeRequired)
            //{
            //    progressBar.Invoke(new Action(() => progressBar.Value = progress));
            //}
            //else
            //{
            //    progressBar.Value = progress;
            //}
        }

        private void UpdateUI(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        private async Task AddNumberToInputAsync(string newNumber)
        {
            string inputNumbers = txtInput.Text.Trim();

            List<string> numbers = string.IsNullOrEmpty(inputNumbers)
                ? new List<string>()
                : inputNumbers.Split(',').ToList();

            if (numbers.Count >= 5)
            {
               
                numbers.RemoveAt(0);
            }

            // Thêm số mới vào danh sách
            numbers.Add(newNumber);
            txtInput.Text = string.Join(",", numbers);
        }
        //private async Task AddNumberToInputAsync(string newNumber)
        //{
        //    // Hiển thị thanh tiến trình và đặt giá trị ban đầu
        //    progressBar.Visible = true;
        //    progressBar.Style = ProgressBarStyle.Continuous;
        //    progressBar.Minimum = 0;
        //    progressBar.Maximum = 100;
        //    progressBar.Value = 0;

        //    try
        //    {
        //        // Chạy công việc nặng trong một Task khác
        //        await Task.Run(() =>
        //        {
        //            // Bước 1: Xử lý txtInput
        //            UpdateProgressBar(10); // Tiến trình 10%
        //            string inputNumbers = txtInput.Text.Trim();
        //            List<string> numbers = string.IsNullOrEmpty(inputNumbers)
        //                ? new List<string>()
        //                : inputNumbers.Split(',').ToList();

        //            // Bước 2: Xử lý txtinput7
        //            UpdateProgressBar(40); // Tiến trình 40%
        //            string inputNumbers7 = txtinput7.Text.Trim();
        //            List<string> txtInput7Numbers = string.IsNullOrEmpty(inputNumbers7)
        //                ? new List<string>()
        //                : inputNumbers7.Split(',').ToList();

        //            // Xóa số đầu tiên nếu vượt quá 7 số
        //            if (txtInput7Numbers.Count >= 7)
        //            {
        //                txtInput7Numbers.RemoveAt(0);
        //            }
        //            txtInput7Numbers.Add(newNumber);

        //            // Bước 3: Xử lý txtInput
        //            UpdateProgressBar(70); // Tiến trình 70%
        //            if (numbers.Count >= 6)
        //            {
        //                numbers.RemoveAt(0); // Xóa số đầu tiên nếu danh sách vượt quá 5 số
        //            }
        //            numbers.Add(newNumber);

        //            // Bước 4: Xử lý txtinput6
        //            UpdateProgressBar(90); // Tiến trình 90%
        //            List<string> txtInput6Numbers = new List<string>(numbers);
        //            if (txtInput7Numbers.Count > numbers.Count)
        //            {
        //                txtInput6Numbers.Insert(0, txtInput7Numbers[txtInput7Numbers.Count - numbers.Count - 1]);
        //            }

        //            // Cập nhật UI
        //            UpdateUI(() =>
        //            {
        //                txtInput.Text = string.Join(",", numbers);
        //                txtinput7.Text = string.Join(",", txtInput7Numbers);
        //                txtinput6.Text = string.Join(",", txtInput6Numbers);
        //            });
        //        });

        //        // Hoàn thành công việc
        //        UpdateProgressBar(100); // Tiến trình hoàn thành
        //    }
        //    finally
        //    {
        //        // Ẩn thanh tiến trình khi hoàn thành
        //        progressBar.Visible = false;
        //    }
        //}


        private void get_dulieu()
        {

            ////ClearGridViewFilter();
            ////string inputNumbers = txtInput.Text.Trim();

            ////if (string.IsNullOrEmpty(inputNumbers))
            ////{
            ////    //XtraMessageBox.Show("Vui lòng nhập dãy số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ////    //return;
            ////}

            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            //    {
            //        if (connection.State == ConnectionState.Closed)
            //            connection.Open();

            //        using (SqlCommand command = new SqlCommand("get_cuoi", connection))
            //        {
            //            command.CommandType = CommandType.StoredProcedure;
            //            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
            //            command.ExecuteNonQuery();
            //            SqlDataAdapter da = new SqlDataAdapter();
            //            DataSet ds = new DataSet();
            //            da.SelectCommand = command;
            //            da.Fill(ds);
            //            gridControl7.DataSource = ds.Tables[0];
            //            //CopyDataSource();

            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            ////XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //gridControl7.DataSource = null;
            //}

            ////FilterGridViewByConvertText3(); FilterGridViewByConvertText2();
            //get_dulieu_gird6(); 
            FilterGrid5(txtInput.Text);


        }
        private void FilterGrid5(string searchText)
        {

            if (gridView5 != null && !string.IsNullOrEmpty(searchText))
            {
                // Tìm kiếm trong cột "Combined" (đặt tên theo cột chứa chuỗi trong GridControl)
                gridView5.ActiveFilterString = $"[GiaTriSS] like '%{searchText}'";
            }
            else
            {
                // Xóa bộ lọc nếu TextBox rỗng
                gridView5.ActiveFilterString = string.Empty;
            }
        }
        private void get_dulieu_gird6()
        {
            gridView5.ActiveFilter.Clear(); // Xóa tất cả bộ lọc đang áp dụng
            string inputNumbers = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(inputNumbers))
            {
                //XtraMessageBox.Show("Vui lòng nhập dãy số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    using (SqlCommand command = new SqlCommand("LOAD_DATA5", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        //command.Parameters.AddWithValue("@DaySo", inputNumbers);
                        command.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        da.SelectCommand = command;
                        da.Fill(ds);
                        gridControl5.DataSource = ds.Tables[0];


                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void get_dulieu_gird7()
        {
            gridView4.ActiveFilter.Clear(); // Xóa tất cả bộ lọc đang áp dụng
            string inputNumbers = txtinput7.Text.Trim();

            if (string.IsNullOrEmpty(inputNumbers))
            {
                //XtraMessageBox.Show("Vui lòng nhập dãy số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    using (SqlCommand command = new SqlCommand("TimKiemDaySo_7", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DaySo", inputNumbers);
                        command.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        da.SelectCommand = command;
                        da.Fill(ds);
                        gridControl4.DataSource = ds.Tables[0];


                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                get_dulieu_gird6();
                
            }
        }

        private void FindNextSO_Load(object sender, EventArgs e)
        {
            //AttachButtonEvents(); // Gắn sự kiện click cho các button

            //// Gọi BestFitColumns để tự động điều chỉnh kích thước cột
            //gridView4.BestFitColumns();
            //get_dulieu();
            get_dulieu_gird6();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
          
        }

        private async  void btn10_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn10.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
            //FilterGridViewByConvertText(); 
        }

        private async void btn9_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn9.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private async void btn8_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn8.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
            // Gọi phương thức lọc
        }

        private async void btn7_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn7.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private async void btn3_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn3.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private async void btn6_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn6.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private async void btn5_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn5.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private async void btn4_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn4.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private async void btn14_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn14.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private async void btn13_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn13.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private async void btn12_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn12.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private async void btn11_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn11.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);
            ; get_dulieu();
        }

        private async void btn18_Click(object sender, EventArgs e)
        {
            //string clickedNumber = btn18.Text; // Lấy số từ nút được click
            // await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            //get_dulieu();FilterGridViewByConvertText();
        }

        private async void btn17_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn17.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private async void btn16_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn16.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private async void btn15_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn15.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_dulieu();
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn18.Text; // Lấy số từ nút được click
             await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
            get_dulieu();
        }

        private void gridView4_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SoTiepTheo")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SoTiepTheo"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }
            if (e.Column.FieldName == "SoTiepTheo1")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SoTiepTheo1"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }

        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void txtInput_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if(e.KeyChar==13)
            {
                get_dulieu();
            }    
        }

        private void ImportExcelToSQL()
        {
            string excelPath = @"C:\Users\SUPPORT\Desktop\GET_DATA_GPT.xlsx";

            // Lấy chuỗi kết nối từ App.config
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

            // Mở file Excel
            using (var workbook = new XLWorkbook(excelPath))
            {
                // Lấy Sheet2
                var worksheet = workbook.Worksheet("Sheet2");

                // Lặp qua các hàng, bắt đầu từ hàng đầu tiên
                foreach (var row in worksheet.RowsUsed())
                {
                    // Lấy giá trị từ cột B (cột thứ 2)
                    string valueB = row.Cell(2).GetValue<string>(); // Cell(2) là cột B

                    // Chèn dữ liệu vào SQL Server
                    InsertIntoDatabase(connectionString, valueB);
                }
            }

            // Thực thi stored procedure sau khi chèn dữ liệu
            ExecuteStoredProcedure(connectionString);
        }

        private void InsertIntoDatabase(string connectionString, string valueB)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Chèn dữ liệu vào cột DATA
                string query = "INSERT INTO INF (DATA) VALUES (@ValueB)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ValueB", valueB);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void ExecuteStoredProcedure(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Gọi stored procedure
                using (SqlCommand command = new SqlCommand("ins_datatab123", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            get_dulieu();

        }
        
  
        private async void btn_Click(object sender, EventArgs e)
        {
            if (sender is SimpleButton button)
            {
                string clickedNumber = button.Text.Trim(); // Lấy số từ nút được click
                           // Lọc dữ liệu theo giá trị
            }
        }


        private void AttachButtonEvents()
        {
            foreach (var control in this.Controls.OfType<SimpleButton>())
            {
                control.Click += btn_Click; // Gắn sự kiện click cho tất cả các nút
            }
        }


        private void ConvertInputToOutput()
        {
            string inputNumbers = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(inputNumbers))
            {
                txtinput6.Text = string.Empty;
                return;
            }

            List<string> numbers = inputNumbers.Split(',').ToList();

            List<string> convertedNumbers = numbers.Select(num =>
            {
                if (int.TryParse(num, out int parsedNumber))
                {
                    return parsedNumber > 10 ? "T" : "X";
                }
                return string.Empty;
            }).ToList();

            txtinput6.Text = string.Join(",", convertedNumbers);
        }

        private void FilterGridViewByConvertText_bk()
        {
            string filterText = txtinput6.Text.Trim();

            if (string.IsNullOrEmpty(filterText))
            {
                gridView7.ActiveFilter.Clear(); // Bỏ bộ lọc nếu không có giá trị
                return;
            }

            // Lấy số cuối cùng trong chuỗi
            var lastValue = filterText.Split(',')
                                      .Select(x => x.Trim())
                                      .Where(x => !string.IsNullOrEmpty(x))
                                      .LastOrDefault();

            if (string.IsNullOrEmpty(lastValue))
            {
                gridView7.ActiveFilter.Clear(); // Không áp dụng bộ lọc nếu không tìm thấy giá trị
                return;
            }

            // Tạo điều kiện lọc kết thúc bằng giá trị bằng (LIKE '%value')
            string filterExpression = $"[PhienGiaTri] LIKE '%{lastValue}'";

            // Áp dụng bộ lọc vào GridView
            gridView7.ActiveFilterString = filterExpression;
        }

        private void FilterGridViewByConvertText7()
        {
            // Lấy giá trị từ txtinput6
            string filterText = txtinput6.Text.Trim();

            // Nếu không có giá trị, bỏ bộ lọc
            if (string.IsNullOrEmpty(filterText))
            {
                gridView7.ActiveFilter.Clear(); // Bỏ bộ lọc nếu không có giá trị
                return;
            }

            // Trích xuất 3 ký tự cuối cùng
            string lastThreeChars = filterText.Length >= 1
                ? filterText.Substring(filterText.Length - 1)
                : filterText;

            // Tạo điều kiện lọc kết thúc bằng 3 ký tự cuối
            string filterExpression = $"[PhienGiaTri] LIKE '%{lastThreeChars}'";

            // Áp dụng bộ lọc vào GridView
            gridView7.ActiveFilterString = filterExpression;
        }

        private void FilterGridViewByConvertText2()
        {
            //string filterText = txtinput6.Text.Trim();

            //// Nếu không có giá trị, bỏ bộ lọc
            //if (string.IsNullOrEmpty(filterText))
            //{
            //    gridView3.ActiveFilter.Clear(); // Bỏ bộ lọc nếu không có giá trị
            //    return;
            //}

            //// Trích xuất 3 ký tự cuối cùng
            //string lastThreeChars = filterText.Length >= 5
            //    ? filterText.Substring(filterText.Length - 5)
            //    : filterText;

            ////  Tạo điều kiện lọc kết thúc bằng 3 ký tự cuối
            //string filterExpression = $"[PhienGiaTri] like '%{lastThreeChars}'";

            //// Áp dụng bộ lọc vào GridView
            //gridView3.ActiveFilterString = filterExpression;
        }
        private void FilterGridViewByConvertText3()
        {
            string filterText = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(filterText))
            {
                gridView7.ActiveFilter.Clear();
                return;
            }

            string[] numbers = filterText.Split(',');
            if (numbers.Length < 3)
            {
                // Nếu không đủ 3 số, bỏ lọc.
                gridView7.ActiveFilter.Clear();
                return;
            }

            // Lấy ba số cuối cùng và tạo chuỗi lọc
            string thirdLastNumber = numbers[numbers.Length - 3].Trim();
            string secondLastNumber = numbers[numbers.Length - 2].Trim();
            string lastNumber = numbers[numbers.Length - 1].Trim();
            string filterValue = $"{thirdLastNumber},{secondLastNumber},{lastNumber}"; // Tạo chuỗi "số3,số2,số1"

            // Tạo biểu thức lọc chính xác chuỗi "số3,số2,số1"
            string filterExpression = $"[GiaTriSS] like '%{filterValue}%'";

            gridView7.ActiveFilterString = filterExpression;
        }

        private void ClearGridViewFilter()
        {
            //gridView3.ActiveFilter.Clear(); // Xóa tất cả bộ lọc đang áp dụng
            
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtInput_TextChanged_1(object sender, EventArgs e)
        {
            //txtConvert.Text = txtInput.Text;
            ConvertInputToOutput();
        }
        private void CopyDataSource()
        {
            // Kiểm tra nếu gridControl3 có DataSource
            if (gridControl7.DataSource != null)
            {
                // Sao chép DataSource từ gridControl3 sang gridControl6

                gridControl3.DataSource = gridControl7.DataSource;
                // Làm mới dữ liệu trong GridView
                gridView3.RefreshData();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trong gridControl3 để sao chép!");
            }
        }


        private void gridView3_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SoTiepTheo")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SoTiepTheo"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Aqua;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }
        }

        private void gridView5_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SoTiepTheo")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SoTiepTheo"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Aqua;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }

            }
            if (e.Column.FieldName == "SoTiepTheo1")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SoTiepTheo1"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }
        }

        private void splitContainer5_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView6_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SoTiepTheo")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SoTiepTheo"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }
            if (e.Column.FieldName == "SoTiepTheo1")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SoTiepTheo1"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }
        }


        private void gridView7_RowCellStyle_1(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "T_80")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "T_80"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Aqua;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }


            }
            if (e.Column.FieldName == "X_80")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "X_80"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Aqua;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }


            }
            if (e.Column.FieldName == "T_20")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "T_20"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Aqua;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }


            }
            if (e.Column.FieldName == "X_20")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "X_20"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Aqua;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }


            }

        }

        private void gridView3_RowCellStyle_1(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SoTiepTheo")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SoTiepTheo"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }
        }

        private void gridView7_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == "CHUYENDOI"|| e.Column.FieldName == "T_X") // **Đảm bảo "KetQua" là FieldName chính xác của cột Kết quả**
            //{
            //    string ketQuaValue = e.CellValue as string; // Lấy giá trị cột Kết quả

            //    if (!string.IsNullOrEmpty(ketQuaValue))
            //    {
            //        e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; // Cải thiện hiển thị văn bản

            //        float currentX = e.Bounds.X; // Vị trí X bắt đầu vẽ văn bản
            //        float charWidth;

            //        // Lặp qua từng ký tự trong chuỗi "KetQua"
            //        foreach (char character in ketQuaValue)
            //        {
            //            Color charColor = Color.Black; // Màu mặc định nếu không phải T hoặc X

            //            if (character == 'T')
            //            {
            //                charColor = Color.Maroon; // Màu xanh cho chữ T
            //                e.Appearance.Font = new System.Drawing.Font(e.Appearance.Font, FontStyle.Bold); // **THÊM DÒNG NÀY ĐỂ IN ĐẬM CHỮ**
            //            }
            //            else if (character == 'X')
            //            {
            //                charColor = Color.Blue;  // Màu đỏ cho chữ X
            //                e.Appearance.Font = new System.Drawing.Font(e.Appearance.Font, FontStyle.Bold); // **THÊM DÒNG NÀY ĐỂ IN ĐẬM CHỮ**
            //            }

            //            using (SolidBrush brush = new SolidBrush(charColor)) // Brush với màu tương ứng
            //            {
            //                string charString = character.ToString();
            //                SizeF charSize = e.Graphics.MeasureString(charString, e.Appearance.Font); // Đo kích thước ký tự

            //                // Vẽ ký tự
            //                e.Graphics.DrawString(charString, e.Appearance.Font, brush, new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - charSize.Height) / 2));

            //                charWidth = charSize.Width;
            //                currentX += charWidth; // Cập nhật vị trí X cho ký tự tiếp theo
            //            }
            //        }
            //        e.Handled = true; // Đánh dấu là đã tự xử lý vẽ ô này, GridControl không cần vẽ nữa
            //    }
            //}
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string excelPath = @"C:\Users\SUPPORT\Desktop\GET_DATA_GPT.xlsx";

            try
            {
                // Sử dụng Process.Start để mở tệp Excel
                Process.Start(excelPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở tệp Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void INS_GOM()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Gọi stored procedure
                using (SqlCommand command = new SqlCommand("ins_gom2", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Chạy TABLE GOM2 THÀNH CÔNG!");
                }
            }
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                ImportExcelToSQL();
                MessageBox.Show("Dữ liệu đã được chèn thành công từ Sheet2, cột B!");
                INS_GOM();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            // Lấy giá trị từ trường nhập liệu
            string inputSequence = txtInput.Text.Trim();

            // Kiểm tra nếu chuỗi rỗng hoặc không hợp lệ
            if (string.IsNullOrEmpty(inputSequence))
            {
                MessageBox.Show("Không có dữ liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Tách chuỗi thành mảng các số
                string[] numbers = inputSequence.Split(',');

                // Kiểm tra nếu chỉ có một phần tử
                if (numbers.Length <= 1)
                {
                    MessageBox.Show("Không thể xóa thêm nữa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Loại bỏ phần tử đầu tiên
                Array.Resize(ref numbers, numbers.Length - 1);

                // Ghép lại thành chuỗi mới
                string newSequence = string.Join(",", numbers);

                // Cập nhật giá trị vào trường nhập liệu
                txtInput.Text = newSequence;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ trường nhập liệu
            string inputSequence = txtInput.Text.Trim();

            // Kiểm tra nếu chuỗi rỗng hoặc không hợp lệ
            if (string.IsNullOrEmpty(inputSequence))
            {
                MessageBox.Show("Không có dữ liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Tách chuỗi thành mảng các số
                string[] numbers = inputSequence.Split(',');

                // Kiểm tra nếu chỉ có một phần tử
                if (numbers.Length <= 1)
                {
                    MessageBox.Show("Không thể xóa thêm nữa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Loại bỏ phần tử đầu tiên
                string[] newNumbers = numbers.Skip(1).ToArray(); // Sử dụng LINQ để bỏ phần tử đầu tiên

                // Ghép lại thành chuỗi mới
                string newSequence = string.Join(",", newNumbers);

                // Cập nhật giá trị vào trường nhập liệu
                txtInput.Text = newSequence;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            get_dulieu();
        }
    }
}
