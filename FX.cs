using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using ClosedXML.Excel;
using DocumentFormat.OpenXml;
using DevExpress.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Diagnostics;
using System.Web.UI.WebControls;
using View = System.Windows.Forms.View;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;
using DevExpress.DataAccess.Excel;


namespace KIEMSOAT_RAVAO
{
    public partial class FX : Form
    {
        public FX()
        {
            InitializeComponent();
            BalanceTableLayoutPanel(this.tableLayoutPanel2);
            BalanceTableLayoutPanel(this.tableLayoutPanel4);
            BalanceTableLayoutPanel(this.tableLayoutPanel1);
            BalanceTableLayoutPanel(this.tableLayoutPanel3);

        }
        private void BalanceTableLayoutPanel(TableLayoutPanel tlp)
        {
            // Cân bằng các cột: Set tất cả về 100% để chúng tự chia đều
            float columnPercent = 100f / tlp.ColumnCount;
            foreach (ColumnStyle cs in tlp.ColumnStyles)
            {
                cs.SizeType = SizeType.Percent;
                cs.Width = columnPercent;
            }

            // Cân bằng các hàng: Set tất cả về 100% để chúng tự chia đều
            float rowPercent = 100f / tlp.RowCount;
            foreach (RowStyle rs in tlp.RowStyles)
            {
                rs.SizeType = SizeType.Percent;
                rs.Height = rowPercent;
            }
        }
        private void get_dulieu()
        {
            if (comboBoxEdit1.Text == "16")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("get_cuoi16", connection))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter();
                            DataSet ds = new DataSet();
                            da.SelectCommand = command;
                            da.Fill(ds);
                            gridControl7.DataSource = ds.Tables[0];
                            CopyDataSource();

                        }
                    }
                }
                catch (Exception ex)
                {
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
            if (comboBoxEdit1.Text == "15")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("get_cuoi15", connection))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;
                            command.CommandTimeout = 0; // Đặt timeout bằng 0 để không giới hạn thời gian chờ
                            SqlDataAdapter da = new SqlDataAdapter();
                            DataSet ds = new DataSet();
                            da.SelectCommand = command;
                            da.Fill(ds);
                            gridControl7.DataSource = ds.Tables[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    gridControl7.DataSource = null;
                }
            }
            if (comboBoxEdit1.Text == "17")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                      
                        using (SqlCommand command = new SqlCommand("get_cuoi17", connection))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter();
                            DataSet ds = new DataSet();
                            da.SelectCommand = command;
                            da.Fill(ds);
                            gridControl7.DataSource = ds.Tables[0];
                            CopyDataSource();

                        }
                    }
                }
                catch (Exception ex)
                {
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
            if (comboBoxEdit1.Text == "13")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("get_cuoi13", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter();
                            DataSet ds = new DataSet();
                            da.SelectCommand = command;
                            da.Fill(ds);
                            gridControl7.DataSource = ds.Tables[0];
                            CopyDataSource();

                        }
                    }
                }
                catch (Exception ex)
                {
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
            if (comboBoxEdit1.Text == "12")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("get_cuoi12", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter();
                            DataSet ds = new DataSet();
                            da.SelectCommand = command;
                            da.Fill(ds);
                            gridControl7.DataSource = ds.Tables[0];
                            CopyDataSource();

                        }
                    }
                }
                catch (Exception ex)
                {
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
            if (comboBoxEdit1.Text == "14")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("get_cuoi14", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter();
                            DataSet ds = new DataSet();
                            da.SelectCommand = command;
                            da.Fill(ds);
                            gridControl7.DataSource = ds.Tables[0];
                            CopyDataSource();

                        }
                    }
                }
                catch (Exception ex)
                {
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
            if (comboBoxEdit1.Text == "18")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("get_cuoi18", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter();
                            DataSet ds = new DataSet();
                            da.SelectCommand = command;
                            da.Fill(ds);
                            gridControl7.DataSource = ds.Tables[0];
                            CopyDataSource();

                        }
                    }
                }
                catch (Exception ex)
                {
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
        }
        private void CountCharacters1()
        {
            // Lấy tổng số ký tự trong RichTextBox
            int characterCount = richTextBox1.Text.Length;
            //labelControl1.Text = $"{characterCount}";

        }
        private void CopyDataSource()
        {
            gridControl4.DataSource = null; gridControl5.DataSource = null;
            gridControl6.DataSource = null; gridControl61.DataSource = null;
            gridControl62.DataSource = null; gridControl63.DataSource = null; gridControl64.DataSource = null;
            gridControl4.DataSource = gridControl3.DataSource;
            gridControl5.DataSource = gridControl3.DataSource;
            gridControl6.DataSource = gridControl3.DataSource;
            gridControl61.DataSource = gridControl3.DataSource;
            gridControl62.DataSource = gridControl3.DataSource;
            gridControl63.DataSource = gridControl3.DataSource;
            gridControl64.DataSource = gridControl3.DataSource;

            //gridControl1.DataSource = null; gridControl2.DataSource = null;
            //gridControl1.DataSource = gridControl7.DataSource;
            //gridControl2.DataSource = gridControl7.DataSource;
        }
        private void get_dulieu16()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    using (SqlCommand command = new SqlCommand("get_cuoi16", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                        command.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        da.SelectCommand = command;
                        da.Fill(ds);
                        gridControl1.DataSource = ds.Tables[0];
                        CopyDataSource();

                    }
                }
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridControl1.DataSource = null;
            }


        }
        private void get_dulieu15()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    using (SqlCommand command = new SqlCommand("get_cuoi15", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                        command.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        da.SelectCommand = command;
                        da.Fill(ds);
                        gridControl2.DataSource = ds.Tables[0];
                        //CopyDataSource();

                    }
                }
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridControl2.DataSource = null;
            }


        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string excelPath = @"C:\Users\SVAO4\Desktop\GET_DATA_GPT.xlsx";

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

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    // Mở hộp thoại để người dùng chọn file Excel
            //    OpenFileDialog openFileDialog = new OpenFileDialog();
            //    openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            //    openFileDialog.Title = "Chọn file Excel để tải dữ liệu";

            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        // Tạo đối tượng ExcelDataSource
            //        var source = new ExcelDataSource();
            //        source.FileName = openFileDialog.FileName;  // Đường dẫn file được chọn từ hộp thoại

            //        // Chỉ định tên sheet là "Sheet"
            //        var worksheetSettings = new ExcelWorksheetSettings("Sheet"); // Sử dụng đúng tên sheet của bạn
            //        source.SourceOptions = new ExcelSourceOptions(worksheetSettings);

            //        // Lấy dữ liệu từ file Excel vào ExcelDataSource
            //        source.Fill();

            //        // Gán nguồn dữ liệu vào GridControl
            //        gridControl7.DataSource = source;

            //        // Thông báo thành công
            //        XtraMessageBox.Show("Dữ liệu đã được tải từ Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Xử lý lỗi nếu có
            //    XtraMessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            get_dulieu();
        }
        
        
        private void INS_GOM()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Gọi stored procedure
                using (SqlCommand command = new SqlCommand("ins_gom", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Chạy TABLE GOM THÀNH CÔNG!");
                }
            }
        }
        private void INS_GOM200()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Gọi stored procedure
                using (SqlCommand command = new SqlCommand("ins_gom200", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Chạy TABLE GOM200 THÀNH CÔNG!");
                }
            }
        }
        private void InsertIntoDatabase200(string connectionString, string valueB)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Chèn dữ liệu vào cột DATA
                string query = "INSERT INTO INF200 (DATA) VALUES (@ValueB)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ValueB", valueB);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
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
        private void ImportExcelToSQL()
        {
            string excelPath = @"C:\Users\SVAO4\Desktop\GET_DATA_GPT.xlsx";

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
        private void ImportExcelToSQL200()
        {
            string excelPath = @"C:\Users\SVAO4\Desktop\GET_DATA_GPT.xlsx";

            // Lấy chuỗi kết nối từ App.config
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

            // Mở file Excel
            using (var workbook = new XLWorkbook(excelPath))
            {
                // Lấy Sheet2
                var worksheet = workbook.Worksheet("OK");

                // Lặp qua các hàng, bắt đầu từ hàng đầu tiên
                foreach (var row in worksheet.RowsUsed())
                {
                    // Lấy giá trị từ cột B (cột thứ 2)
                    string valueB = row.Cell(2).GetValue<string>(); // Cell(2) là cột B

                    // Chèn dữ liệu vào SQL Server
                    InsertIntoDatabase200(connectionString, valueB);
                }
            }

            // Thực thi stored procedure sau khi chèn dữ liệu
            ExecuteStoredProcedure200(connectionString);
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
        private void ExecuteStoredProcedure200(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Gọi stored procedure
                using (SqlCommand command = new SqlCommand("ins_datatab200", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
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
            get_dulieu();
        }
       
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            richTextBox4.Text = string.Empty;
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            richTextBox4.Text = string.Empty;
        }
        private void UpdateRichTextBoxColors()
        {
            // Lấy chuỗi hiện tại trong RichTextBox
            string text = richTextBox1.Text;

            // Lưu trữ vị trí con trỏ
            int currentSelectionStart = richTextBox1.SelectionStart;
            int currentSelectionLength = richTextBox1.SelectionLength;

            // Tắt cập nhật giao diện để tránh nhấp nháy
            richTextBox1.SuspendLayout();

            // Xóa định dạng cũ
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = System.Drawing.Color.Black;

            // Lặp qua từng ký tự và thay đổi màu
            for (int i = 0; i < text.Length; i++)
            {
                richTextBox1.Select(i, 1); // Chọn từng ký tự

                if (text[i] == 'T')
                {
                    richTextBox1.SelectionColor = System.Drawing.Color.Maroon; // Màu cho ký tự T
                }
                else if (text[i] == 'X')
                {
                    richTextBox1.SelectionColor = System.Drawing.Color.Blue; // Màu cho ký tự X
                }
            }

            // Phục hồi vị trí con trỏ
            richTextBox1.SelectionStart = currentSelectionStart;
            richTextBox1.SelectionLength = currentSelectionLength;

            // Bật lại cập nhật giao diện
            richTextBox1.ResumeLayout();
        }

        private void CountCharacters()
        {
            // Lấy tổng số ký tự trong RichTextBox
            int characterCount = richTextBox1.Text.Length;
            labelControl2.Text = $"{characterCount}";

        }
        private void FilterGrid5(string searchText)
        {

            if (gridView7 != null && !string.IsNullOrEmpty(searchText))
            {
                // Tìm kiếm trong cột "Combined" (đặt tên theo cột chứa chuỗi trong GridControl)
                gridView7.ActiveFilterString = $"[GHEP] like '%{searchText}'";
            }
            else
            {
                // Xóa bộ lọc nếu TextBox rỗng
                gridView7.ActiveFilterString = string.Empty;
            }
        }
        private void FilterGrid1(string searchText)
        {

            if (gridView1 != null && !string.IsNullOrEmpty(searchText))
            {
                // Tìm kiếm trong cột "Combined" (đặt tên theo cột chứa chuỗi trong GridControl)
                gridView1.ActiveFilterString = $"[GHEP] like '%{searchText}'";
            }
            else
            {
                // Xóa bộ lọc nếu TextBox rỗng
                gridView1.ActiveFilterString = string.Empty;
            }
        }
        private void FilterGrid2(string searchText)
        {

            if (gridView2 != null && !string.IsNullOrEmpty(searchText))
            {
                // Tìm kiếm trong cột "Combined" (đặt tên theo cột chứa chuỗi trong GridControl)
                gridView2.ActiveFilterString = $"[GHEP] like '%{searchText}'";
            }
            else
            {
                // Xóa bộ lọc nếu TextBox rỗng
                gridView2.ActiveFilterString = string.Empty;
            }
        }
        private void FilterGridCombined(string searchCUOI, string searchGHEP)
        {
            if (gridView7 != null)
            {
                List<string> filterParts = new List<string>();

                if (!string.IsNullOrEmpty(searchCUOI))
                {
                    filterParts.Add($"[CUOI] LIKE '{searchCUOI}%'");
                }

                if (!string.IsNullOrEmpty(searchGHEP))
                {
                    filterParts.Add($"[GHEP] like '%{searchGHEP}'");
                }

                gridView7.ActiveFilterString = string.Join(" AND ", filterParts);
            }
        }

        private void AddNumberToInputAsync(string newNumber)
        {
            string inputNumbers = txtInput.Text.Trim();

            List<string> numbers = string.IsNullOrEmpty(inputNumbers)
                ? new List<string>()
                : inputNumbers.Split(',').ToList();

            if (numbers.Count >= 17)
            {

                numbers.RemoveAt(0);
            }

            // Thêm số mới vào danh sách
            numbers.Add(newNumber);
            txtInput.Text = string.Join(",", numbers);
        }
        private void UpdateRTextBox(string stringToAdd)
        {
            // Lấy giá trị hiện tại của richTextBox1
            string currentText = richTextBox1.Text;
            // Thêm chuỗi mới vào cuối
            currentText += stringToAdd;

            // Cập nhật giá trị mới cho richTextBox1
            richTextBox1.Text = currentText;

            if(comboBoxEdit1.Text=="15")
            {
                if (richTextBox1.Text.Length > 15)
                {
                    // Cắt bớt chuỗi nếu vượt quá 8 ký tự
                    richTextBox1.Text = richTextBox1.Text.Substring(1);
                }
            }
            if (comboBoxEdit1.Text == "12")
            {
                if (richTextBox1.Text.Length > 12)
                {
                    // Cắt bớt chuỗi nếu vượt quá 8 ký tự
                    richTextBox1.Text = richTextBox1.Text.Substring(1);
                }
            }
            if (comboBoxEdit1.Text == "14")
            {
                if (richTextBox1.Text.Length > 14)
                {
                    // Cắt bớt chuỗi nếu vượt quá 8 ký tự
                    richTextBox1.Text = richTextBox1.Text.Substring(1);
                }
            }
            if (comboBoxEdit1.Text == "13")
            {
                if (richTextBox1.Text.Length > 13)
                {
                    // Cắt bớt chuỗi nếu vượt quá 8 ký tự
                    richTextBox1.Text = richTextBox1.Text.Substring(1);
                }
            }
            if (comboBoxEdit1.Text == "16")
            {
                if (richTextBox1.Text.Length > 16)
                {
                    // Cắt bớt chuỗi nếu vượt quá 8 ký tự
                    richTextBox1.Text = richTextBox1.Text.Substring(1);
                }
            }
            if (comboBoxEdit1.Text == "17")
            {
                if (richTextBox1.Text.Length > 17)
                {
                    // Cắt bớt chuỗi nếu vượt quá 8 ký tự
                    richTextBox1.Text = richTextBox1.Text.Substring(1);
                }
            }
            if (comboBoxEdit1.Text == "18")
            {
                if (richTextBox1.Text.Length > 18)
                {
                    // Cắt bớt chuỗi nếu vượt quá 8 ký tự
                    richTextBox1.Text = richTextBox1.Text.Substring(1);
                }
            }


        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = richTextBox1.SelectionStart;

            // Chuyển toàn bộ văn bản thành chữ hoa
            richTextBox1.Text = richTextBox1.Text.ToUpper();

            // Phục hồi vị trí con trỏ
            richTextBox1.SelectionStart = cursorPosition;
            UpdateRichTextBoxColors();
            CountCharacters();

            if(comboBoxEdit1.Text=="15")
            {
                if (richTextBox1.Text.Length == 15)
                {
                    FilterGrid5(richTextBox1.Text);

                }
            }
            if (comboBoxEdit1.Text == "12")
            {
                if (richTextBox1.Text.Length == 12)
                {
                    FilterGrid5(richTextBox1.Text);

                }
            }
            if (comboBoxEdit1.Text == "13")
            {
                if (richTextBox1.Text.Length == 13)
                {
                    FilterGrid5(richTextBox1.Text);

                }
            }
            if (comboBoxEdit1.Text == "14")
            {
                if (richTextBox1.Text.Length == 14)
                {
                    FilterGrid5(richTextBox1.Text);

                }
            }
            if (comboBoxEdit1.Text == "16")
            {
                if (richTextBox1.Text.Length == 16)
                {
                    FilterGrid5(richTextBox1.Text);

                }
            }
            if (comboBoxEdit1.Text == "17")
            {
                if (richTextBox1.Text.Length == 17)
                {
                    FilterGrid5(richTextBox1.Text);
                    string a = richTextBox1.Text.Substring(1);
                    string b = richTextBox1.Text.Substring(2);
                    FilterGrid1(a); FilterGrid2(b);

                }
            }
            if (comboBoxEdit1.Text == "18")
            {
                if (richTextBox1.Text.Length == 18)
                {
                    //FilterGrid5(richTextBox1.Text);
                    //string a = richTextBox1.Text.Substring(1);
                    //string b = richTextBox1.Text.Substring(2);
                    //FilterGrid1(a); FilterGrid2(b);
                    PerformOptimizedGridFiltering();

                }
            }


        }

        private void FX_Load(object sender, EventArgs e)
        {
            // Lấy thông tin màn hình hiện tại
            Screen screen = Screen.PrimaryScreen;
            Rectangle workingArea = screen.WorkingArea;

            // Tính toán vị trí bên phải màn hình
            this.Left = workingArea.Right - this.Width; // Đưa form ra sát mép phải
            this.Top = workingArea.Top; // Giữ form ở đầu màn hình (hoặc điều chỉnh nếu cần)
            richTextBox1.Focus();
            get_dulieu();
            //gridView1.Columns["CUOI"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //gridView7.Columns["CUOI"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


        }

        private void gridView7_RowStyle(object sender, RowStyleEventArgs e)
        {

        }

        private void gridView7_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            // Đảm bảo rằng bạn đang làm việc với cột "COUNT"
            if (e.Column.FieldName == "COUNT")
            {
                // Lấy giá trị của ô và chuyển đổi nó thành số nguyên
                if (e.CellValue != null && int.TryParse(e.CellValue.ToString(), out int countValue))
                {
                    // Nếu giá trị lớn hơn 10, đặt màu chữ là Maroon
                    if (countValue > 10)
                    {
                        e.Appearance.ForeColor = System.Drawing.Color.Maroon;
                    }
                    // Nếu giá trị nhỏ hơn hoặc bằng 10, đặt màu chữ là Blue
                    else
                    {
                        e.Appearance.ForeColor = System.Drawing.Color.Blue;
                    }
                }
            }

        }

        private void gridView7_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            
            if (e.Column.FieldName == "GHEP"|| e.Column.FieldName== "CUOI") // Đảm bảo FieldName chính xác của cột
            {
                string ketQuaValue = e.CellValue as string; // Lấy giá trị cột

                if (!string.IsNullOrEmpty(ketQuaValue))
                {
                    e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; // Cải thiện hiển thị văn bản

                    float currentX = e.Bounds.X; // Vị trí X bắt đầu vẽ văn bản
                    float charWidth;

                    // Tạo font chữ đậm dựa trên font hiện tại
                    System.Drawing.Font boldFont = new System.Drawing.Font(e.Appearance.Font, FontStyle.Bold);

                    // Chia chuỗi thành mảng ký tự (T hoặc X)
                    char[] characters = ketQuaValue.ToCharArray();

                    // Lặp qua từng ký tự trong mảng
                    foreach (char character in characters)
                    {
                        // Kiểm tra ký tự có phải là 'T' hoặc 'X' không
                        if (character == 'T' || character == 'X')
                        {
                            System.Drawing.Color characterColor = character == 'T' ? System.Drawing.Color.Maroon : System.Drawing.Color.Blue; // Màu sắc dựa trên ký tự

                            using (SolidBrush brush = new SolidBrush(characterColor)) // Brush với màu tương ứng
                            {
                                string characterString = character.ToString();
                                SizeF characterSize = e.Graphics.MeasureString(characterString, boldFont); // Đo kích thước ký tự với font đậm

                                // Vẽ ký tự với font đậm
                                e.Graphics.DrawString(characterString, boldFont, brush,
                                    new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - characterSize.Height) / 2));

                                charWidth = characterSize.Width;
                                currentX += charWidth + 2; // Cập nhật vị trí X cho ký tự tiếp theo (+5 để tạo khoảng cách nhỏ giữa các ký tự)
                            }
                        }
                    }

                    // Giải phóng font đậm sau khi sử dụng
                    boldFont.Dispose();

                    e.Handled = true; // Đánh dấu là đã tự xử lý vẽ ô này, GridControl không cần vẽ nữa
                }
            }
            if (e.Column.FieldName == "COUNT") // Thêm điều kiện cho cột COUNT
            {
                string cellValue = e.CellValue as string;

                if (!string.IsNullOrEmpty(cellValue))
                {
                    e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                    float currentX = e.Bounds.X;
                    System.Drawing.Font boldFont = new System.Drawing.Font(e.Appearance.Font, FontStyle.Bold);
                    string[] numbers = cellValue.Split(','); // Tách chuỗi thành các số

                    foreach (string numberStr in numbers)
                    {
                        if (int.TryParse(numberStr.Trim(), out int number)) // Cố gắng chuyển đổi thành số
                        {
                            System.Drawing.Color numberColor = number > 10 ? System.Drawing.Color.Maroon : System.Drawing.Color.Blue;

                            using (SolidBrush brush = new SolidBrush(numberColor))
                            {
                                SizeF numberSize = e.Graphics.MeasureString(numberStr, boldFont);
                                e.Graphics.DrawString(numberStr, boldFont, brush,
                                    new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - numberSize.Height) / 2));
                                currentX += numberSize.Width + 5; // Thêm khoảng cách
                            }
                        }
                        else
                        {
                            // Xử lý trường hợp không phải là số nếu cần
                            SizeF errorSize = e.Graphics.MeasureString(numberStr, e.Appearance.Font);
                            e.Graphics.DrawString(numberStr, e.Appearance.Font, Brushes.Black, // Hoặc màu mặc định khác
                                new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - errorSize.Height) / 2));
                            currentX += errorSize.Width + 5;
                        }
                    }
                    boldFont.Dispose();
                    e.Handled = true;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=string.Empty;
            richTextBox2.Text = string.Empty;
            txtInput.Text = string.Empty;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Tạo đối tượng GridView
            //    GridView gridView = gridControl7.MainView as GridView;

            //    if (gridView != null)
            //    {
            //        // Xuất dữ liệu từ GridView ra file Excel
            //        SaveFileDialog saveFileDialog = new SaveFileDialog();
            //        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //        {
            //            // Lưu file Excel với tên người dùng chọn
            //            gridView.ExportToXlsx(saveFileDialog.FileName);
            //            XtraMessageBox.Show("Dữ liệu đã được xuất ra Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            try
            {
                ImportExcelToSQL200();
                MessageBox.Show("Dữ liệu đã được chèn thành công từ Sheet2, cột B!");
                INS_GOM200();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "GHEP" || e.Column.FieldName == "CUOI") // Đảm bảo FieldName chính xác của cột
            {
                string ketQuaValue = e.CellValue as string; // Lấy giá trị cột

                if (!string.IsNullOrEmpty(ketQuaValue))
                {
                    e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; // Cải thiện hiển thị văn bản

                    float currentX = e.Bounds.X; // Vị trí X bắt đầu vẽ văn bản
                    float charWidth;

                    // Tạo font chữ đậm dựa trên font hiện tại
                    System.Drawing.Font boldFont = new System.Drawing.Font(e.Appearance.Font, FontStyle.Bold);

                    // Chia chuỗi thành mảng ký tự (T hoặc X)
                    char[] characters = ketQuaValue.ToCharArray();

                    // Lặp qua từng ký tự trong mảng
                    foreach (char character in characters)
                    {
                        // Kiểm tra ký tự có phải là 'T' hoặc 'X' không
                        if (character == 'T' || character == 'X')
                        {
                            System.Drawing.Color characterColor = character == 'T' ? System.Drawing.Color.Maroon : System.Drawing.Color.Blue; // Màu sắc dựa trên ký tự

                            using (SolidBrush brush = new SolidBrush(characterColor)) // Brush với màu tương ứng
                            {
                                string characterString = character.ToString();
                                SizeF characterSize = e.Graphics.MeasureString(characterString, boldFont); // Đo kích thước ký tự với font đậm

                                // Vẽ ký tự với font đậm
                                e.Graphics.DrawString(characterString, boldFont, brush,
                                    new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - characterSize.Height) / 2));

                                charWidth = characterSize.Width;
                                currentX += charWidth + 2; // Cập nhật vị trí X cho ký tự tiếp theo (+5 để tạo khoảng cách nhỏ giữa các ký tự)
                            }
                        }
                    }

                    // Giải phóng font đậm sau khi sử dụng
                    boldFont.Dispose();

                    e.Handled = true; // Đánh dấu là đã tự xử lý vẽ ô này, GridControl không cần vẽ nữa
                }
            }
        }

        private void FX_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gridView2_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {

        }

        private void gridView2_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "GHEP" || e.Column.FieldName == "CUOI") // Đảm bảo FieldName chính xác của cột
            {
                string ketQuaValue = e.CellValue as string; // Lấy giá trị cột

                if (!string.IsNullOrEmpty(ketQuaValue))
                {
                    e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; // Cải thiện hiển thị văn bản

                    float currentX = e.Bounds.X; // Vị trí X bắt đầu vẽ văn bản
                    float charWidth;

                    // Tạo font chữ đậm dựa trên font hiện tại
                    System.Drawing.Font boldFont = new System.Drawing.Font(e.Appearance.Font, FontStyle.Bold);

                    // Chia chuỗi thành mảng ký tự (T hoặc X)
                    char[] characters = ketQuaValue.ToCharArray();

                    // Lặp qua từng ký tự trong mảng
                    foreach (char character in characters)
                    {
                        // Kiểm tra ký tự có phải là 'T' hoặc 'X' không
                        if (character == 'T' || character == 'X')
                        {
                            System.Drawing.Color characterColor = character == 'T' ? System.Drawing.Color.Maroon : System.Drawing.Color.Blue; // Màu sắc dựa trên ký tự

                            using (SolidBrush brush = new SolidBrush(characterColor)) // Brush với màu tương ứng
                            {
                                string characterString = character.ToString();
                                SizeF characterSize = e.Graphics.MeasureString(characterString, boldFont); // Đo kích thước ký tự với font đậm

                                // Vẽ ký tự với font đậm
                                e.Graphics.DrawString(characterString, boldFont, brush,
                                    new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - characterSize.Height) / 2));

                                charWidth = characterSize.Width;
                                currentX += charWidth + 2; // Cập nhật vị trí X cho ký tự tiếp theo (+5 để tạo khoảng cách nhỏ giữa các ký tự)
                            }
                        }
                    }

                    // Giải phóng font đậm sau khi sử dụng
                    boldFont.Dispose();

                    e.Handled = true; // Đánh dấu là đã tự xử lý vẽ ô này, GridControl không cần vẽ nữa
                }
            }
        }



        private void btn10_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn10.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn9.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn8.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn7.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn6.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn5.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn4.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn3.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn11.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn12.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn13.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn14.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn15.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn16.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn17.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn18.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }
        
        private void a()
        {
            // Lấy giá trị từ TextBox
            string input = txtInput.Text.Trim();

            // Kiểm tra nếu input rỗng
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào TextBox!");
                return;
            }

            try
            {
                // Chia chuỗi thành mảng các phần tử
                string[] values = input.Split(',');

                // Xử lý 5 phần tử đầu tiên
                for (int i = 0; i < Math.Min(14, values.Length); i++)
                {
                    if (int.TryParse(values[i], out int number))
                    {
                        values[i] = number > 10 ? "T" : "X";
                    }
                    else
                    {
                        MessageBox.Show($"Phần tử thứ {i + 1} không phải là số hợp lệ!");
                        return;
                    }
                }

                // Kết hợp các phần tử thành chuỗi mới
                string result = string.Join(",", values);

                // Hiển thị kết quả vào RichTextBox
                richTextBox2.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        private string FindBestFilterString(DataTable sourceTable, string initialFilter)

        {

            if (string.IsNullOrEmpty(initialFilter))

                return string.Empty;



            string currentFilter = initialFilter;

            while (currentFilter.Length > 0)

            {

                // Tạo một DataView để lọc dữ liệu trực tiếp từ nguồn

                DataView dv = new DataView(sourceTable);

                dv.RowFilter = $"GHEP LIKE '%{currentFilter}'";

                    if (dv.Count >= 2)

                    {

                        return currentFilter;

                    }
               

                // Cắt bỏ ký tự đầu tiên

                currentFilter = currentFilter.Substring(1);

            }

            return string.Empty;

        }
        private void PerformOptimizedGridFiltering()

        {

            // Lấy chuỗi tìm kiếm ban đầu

            string searchText = richTextBox1.Text;



            // Lấy DataTable làm nguồn dữ liệu (ví dụ)

            // Giả sử gridView5 được binding với một DataTable

            DataTable sourceTable = gridControl7.DataSource as DataTable;

            if (sourceTable == null) return;



            // Tìm chuỗi lọc tối ưu

            string lastFilterString = FindBestFilterString(sourceTable, searchText);



            // Áp dụng bộ lọc cho gridView5

            if (gridView7 != null)

            {

                gridView7.ActiveFilterString = $"[GHEP] LIKE '%{lastFilterString}'";

            }



        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {


            string inputNumbers = txtInput.Text.Trim();

            List<string> numbers = string.IsNullOrEmpty(inputNumbers)
                ? new List<string>()
                : inputNumbers.Split(',').ToList();

            if (numbers.Count >= 17)
            {
                a();
                //string b = richTextBox2.Text;
                FilterGrid(richTextBox2.Text);
                //FilterGrid1(b.ToString());
                string currentText4 = richTextBox2.Text;
                currentText4 = currentText4.Substring(2); // Bỏ ký tự đầu tiên
                FilterGrid4(currentText4);

                string currentText5 = richTextBox2.Text;
                currentText5 = currentText5.Substring(4); // Bỏ ký tự đầu tiên
                FilterGrid54(currentText5);

                string currentText6 = richTextBox2.Text;
                currentText6 = currentText6.Substring(6); // Bỏ ký tự đầu tiên
                FilterGrid6(currentText6);

                string currentText7 = richTextBox2.Text;
                currentText7 = currentText7.Substring(8); // Bỏ ký tự đầu tiên
                FilterGrid61(currentText7);

                string currentText8 = richTextBox2.Text;
                currentText8 = currentText8.Substring(10); // Bỏ ký tự đầu tiên
                FilterGrid62(currentText8);

                string currentText9 = richTextBox2.Text;
                currentText9 = currentText9.Substring(12); // Bỏ ký tự đầu tiên
                FilterGrid63(currentText9);

                string currentText10 = richTextBox2.Text;
                currentText10 = currentText10.Substring(14); // Bỏ ký tự đầu tiên
                FilterGrid64(currentText10);

            }
        }
        private void FilterGrid(string searchText)
                {
                    // Kiểm tra nếu GridView đang hiển thị dữ liệu
                    if (gridView3 != null && !string.IsNullOrEmpty(searchText))
                    {
                        // Tìm kiếm trong cột "Combined" (đặt tên theo cột chứa chuỗi trong GridControl)
                        gridView3.ActiveFilterString = $"[DATA] like '%{searchText}'";
                    }
                    else
                    {
                        // Xóa bộ lọc nếu TextBox rỗng
                        gridView3.ActiveFilterString = string.Empty;
                    }

                }
        private void FilterGrid4(string searchText)
        {
            // Kiểm tra nếu GridView đang hiển thị dữ liệu
            if (gridView4 != null && !string.IsNullOrEmpty(searchText))
            {
                // Tìm kiếm trong cột "Combined" (đặt tên theo cột chứa chuỗi trong GridControl)
                gridView4.ActiveFilterString = $"[DATA] like '%{searchText}'";
            }
            else
            {
                // Xóa bộ lọc nếu TextBox rỗng
                gridView4.ActiveFilterString = string.Empty;
            }

        }
        private void FilterGrid54(string searchText)
        {
            // Kiểm tra nếu GridView đang hiển thị dữ liệu
            if (gridView5 != null && !string.IsNullOrEmpty(searchText))
            {
                // Tìm kiếm trong cột "Combined" (đặt tên theo cột chứa chuỗi trong GridControl)
                gridView5.ActiveFilterString = $"[DATA] like '%{searchText}'";
            }
            else
            {
                // Xóa bộ lọc nếu TextBox rỗng
                gridView5.ActiveFilterString = string.Empty;
            }

        }
        private void FilterGrid6(string searchText)
        {
            // Kiểm tra nếu GridView đang hiển thị dữ liệu
            if (gridView6 != null && !string.IsNullOrEmpty(searchText))
            {
                // Tìm kiếm trong cột "Combined" (đặt tên theo cột chứa chuỗi trong GridControl)
                gridView6.ActiveFilterString = $"[DATA] like '%{searchText}'";
            }
            else
            {
                // Xóa bộ lọc nếu TextBox rỗng
                gridView6.ActiveFilterString = string.Empty;
            }

        }
        private void FilterGrid61(string searchText)
        {
            // Kiểm tra nếu GridView đang hiển thị dữ liệu
            if (gridView8 != null && !string.IsNullOrEmpty(searchText))
            {
                // Tìm kiếm trong cột "Combined" (đặt tên theo cột chứa chuỗi trong GridControl)
                gridView8.ActiveFilterString = $"[DATA] like '%{searchText}'";
            }
            else
            {
                // Xóa bộ lọc nếu TextBox rỗng
                gridView8.ActiveFilterString = string.Empty;
            }

        }
        private void FilterGrid62(string searchText)
        {
            // Kiểm tra nếu GridView đang hiển thị dữ liệu
            if (gridView9 != null && !string.IsNullOrEmpty(searchText))
            {
                // Tìm kiếm trong cột "Combined" (đặt tên theo cột chứa chuỗi trong GridControl)
                gridView9.ActiveFilterString = $"[DATA] like '%{searchText}'";
            }
            else
            {
                // Xóa bộ lọc nếu TextBox rỗng
                gridView9.ActiveFilterString = string.Empty;
            }

        }
        private void FilterGrid63(string searchText)
        {
            // Kiểm tra nếu GridView đang hiển thị dữ liệu
            if (gridView10 != null && !string.IsNullOrEmpty(searchText))
            {
                // Tìm kiếm trong cột "Combined" (đặt tên theo cột chứa chuỗi trong GridControl)
                gridView10.ActiveFilterString = $"[DATA] like '%{searchText}'";
            }
            else
            {
                // Xóa bộ lọc nếu TextBox rỗng
                gridView10.ActiveFilterString = string.Empty;
            }

        }
        private void FilterGrid64(string searchText)
        {
            // Kiểm tra nếu GridView đang hiển thị dữ liệu
            if (gridView11 != null && !string.IsNullOrEmpty(searchText))
            {
                // Tìm kiếm trong cột "Combined" (đặt tên theo cột chứa chuỗi trong GridControl)
                gridView11.ActiveFilterString = $"[DATA] like '%{searchText}'";
            }
            else
            {
                // Xóa bộ lọc nếu TextBox rỗng
                gridView11.ActiveFilterString = string.Empty;
            }

        }

        private void gridView3_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SS9")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS9"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = Color.Pink;
                }
                else { e.Appearance.BackColor = Color.Aqua; }
            }
        }

        private void gridView3_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "DATA") // Đảm bảo FieldName chính xác của cột
            {
                string ketQuaValue = e.CellValue as string; // Lấy giá trị cột

                if (!string.IsNullOrEmpty(ketQuaValue))
                {
                    e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; // Cải thiện hiển thị văn bản

                    float currentX = e.Bounds.X; // Vị trí X bắt đầu vẽ văn bản
                    float charWidth;

                    // Tạo font chữ đậm dựa trên font hiện tại
                    Font boldFont = new Font(e.Appearance.Font, FontStyle.Bold);

                    // Chia chuỗi thành mảng số
                    string[] numbers = ketQuaValue.Split(',');

                    // Lặp qua từng số trong mảng
                    foreach (string numberStr in numbers)
                    {
                        if (int.TryParse(numberStr.Trim(), out int number)) // Chuyển đổi số và kiểm tra
                        {
                            Color numberColor = number > 10 ? Color.Maroon : Color.Blue; // Màu sắc dựa trên giá trị số

                            using (SolidBrush brush = new SolidBrush(numberColor)) // Brush với màu tương ứng
                            {
                                string numberString = number.ToString();
                                SizeF numberSize = e.Graphics.MeasureString(numberString, boldFont); // Đo kích thước số với font đậm

                                // Vẽ số với font đậm
                                e.Graphics.DrawString(numberString, boldFont, brush,
                                    new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - numberSize.Height) / 2));

                                charWidth = numberSize.Width;
                                currentX += charWidth + 5; // Cập nhật vị trí X cho số tiếp theo (+5 để tạo khoảng cách nhỏ giữa các số)
                            }
                        }
                    }

                    // Giải phóng font đậm sau khi sử dụng
                    boldFont.Dispose();

                    e.Handled = true; // Đánh dấu là đã tự xử lý vẽ ô này, GridControl không cần vẽ nữa
                }
            }
        }

        private void gridView4_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {

            GridView view = sender as GridView;


            if (e.Column.FieldName == "SS9")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS9"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = Color.Pink;
                }
                else { e.Appearance.BackColor = Color.Aqua; }
            }
        }

        private void gridView5_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {

            GridView view = sender as GridView;


            if (e.Column.FieldName == "SS9")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS9"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = Color.Pink;
                }
                else { e.Appearance.BackColor = Color.Aqua; }
            }
        }
        private void gridView6_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SS9")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS9"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = Color.Pink;
                }
                else { e.Appearance.BackColor = Color.Aqua; }
            }
        }

        private void gridView8_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SS9")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS9"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = Color.Pink;
                }
                else { e.Appearance.BackColor = Color.Aqua; }
            }
        }

        private void gridView9_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SS9")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS9"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = Color.Pink;
                }
                else { e.Appearance.BackColor = Color.Aqua; }
            }
        }

        private void gridView10_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SS9")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS9"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = Color.Pink;
                }
                else { e.Appearance.BackColor = Color.Aqua; }
            }
        }

        private void gridView11_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SS9")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS9"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = Color.LightYellow;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = Color.Pink;
                }
                else { e.Appearance.BackColor = Color.Aqua; }
            }
        }
     
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_dulieu();
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn7.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn3.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn10.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn9.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn8.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn6.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn5.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn4.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn11_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn11.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn12_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn12.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn14_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn14.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn13_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn13.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn15_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn15.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn16_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn16.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn17_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn17.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn18_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn18.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }
        private void UpdateRichTextBoxColors4()
        {
            // Lấy chuỗi hiện tại trong RichTextBox
            string text = richTextBox4.Text;

            // Lưu trữ vị trí con trỏ
            int currentSelectionStart = richTextBox4.SelectionStart;
            int currentSelectionLength = richTextBox4.SelectionLength;

            // Tắt cập nhật giao diện để tránh nhấp nháy
            richTextBox4.SuspendLayout();

            // Xóa định dạng cũ
            richTextBox4.SelectAll();
            richTextBox4.SelectionColor = System.Drawing.Color.Black;

            // Lặp qua từng ký tự và thay đổi màu
            for (int i = 0; i < text.Length; i++)
            {
                richTextBox4.Select(i, 1); // Chọn từng ký tự

                if (text[i] == 'T')
                {
                    richTextBox4.SelectionColor = System.Drawing.Color.Maroon; // Màu cho ký tự T
                }
                else if (text[i] == 'X')
                {
                    richTextBox4.SelectionColor = System.Drawing.Color.Blue; // Màu cho ký tự X
                }
            }

            // Phục hồi vị trí con trỏ
            richTextBox4.SelectionStart = currentSelectionStart;
            richTextBox4.SelectionLength = currentSelectionLength;

            // Bật lại cập nhật giao diện
            richTextBox4.ResumeLayout();
        }
        private void UpdateRTextBox4(string stringToAdd)
        {
            // Lấy giá trị hiện tại của richTextBox1
            string currentText = richTextBox4.Text;
            // Thêm chuỗi mới vào cuối
            currentText += stringToAdd;

            // Cập nhật giá trị mới cho richTextBox1
            richTextBox4.Text = currentText;


        }
        private void simpleButton10_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = string.Empty;
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            //UpdateRTextBox4("T");
            // Lấy giá trị hiện tại của cột 'CUOI' từ dòng lọc tự động
            object filterValue = gridView7.GetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "CUOI");

            // Khởi tạo một chuỗi mới
            string newFilterString;
            string filterString = filterValue?.ToString() ?? string.Empty;

            // Kiểm tra xem chuỗi có kết thúc bằng '%' không
            if (filterString.EndsWith("%"))
            {
                // Loại bỏ dấu '%' ở cuối chuỗi
                string mainString = filterString.Substring(0, filterString.Length - 1);

                // Nối thêm ký tự 'T' vào phần chuỗi chính, sau đó thêm lại dấu '%'
                newFilterString = mainString + "T" + "%";
            }
            else
            {
                // Nếu chuỗi không có '%', chỉ cần nối thêm 'T' vào cuối
                newFilterString = filterString + "T";
            }

            // Đặt lại giá trị đã chỉnh sửa vào dòng lọc tự động
            gridView7.SetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "CUOI", newFilterString);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //UpdateRTextBox4("X");
            // Lấy giá trị hiện tại của cột 'CUOI' từ dòng lọc tự động
            object filterValue = gridView7.GetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "CUOI");

            // Khởi tạo một chuỗi mới
            string newFilterString;
            string filterString = filterValue?.ToString() ?? string.Empty;

            // Kiểm tra xem chuỗi có kết thúc bằng '%' không
            if (filterString.EndsWith("%"))
            {
                // Loại bỏ dấu '%' ở cuối chuỗi
                string mainString = filterString.Substring(0, filterString.Length - 1);

                // Nối thêm ký tự 'T' vào phần chuỗi chính, sau đó thêm lại dấu '%'
                newFilterString = mainString + "X" + "%";
            }
            else
            {
                // Nếu chuỗi không có '%', chỉ cần nối thêm 'T' vào cuối
                newFilterString = filterString + "X";
            }

            // Đặt lại giá trị đã chỉnh sửa vào dòng lọc tự động
            gridView7.SetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "CUOI", newFilterString);
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = richTextBox4.SelectionStart;

            // Chuyển toàn bộ văn bản thành chữ hoa
            richTextBox4.Text = richTextBox4.Text.ToUpper();
            // Phục hồi vị trí con trỏ
            richTextBox4.SelectionStart = cursorPosition;
            UpdateRichTextBoxColors4();
            PerformOptimizedGridFiltering();

        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            // Lấy giá trị hiện tại của cột 'GHEP' từ dòng lọc tự động
            object filterValue = gridView7.GetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "GHEP");

            // Kiểm tra xem giá trị có phải là chuỗi không rỗng và có ít nhất 2 ký tự không
            if (filterValue is string filterString && filterString.Length >= 2)
            {
                // Lấy ký tự đầu tiên
                string firstChar = filterString.Substring(0, 1);

                // Lấy phần còn lại của chuỗi, bắt đầu từ ký tự thứ 3
                string remainingString = filterString.Substring(2);

                // Nối hai phần lại với nhau
                string newFilterString = firstChar + remainingString;

                // Đặt lại giá trị đã chỉnh sửa vào dòng lọc tự động
                gridView7.SetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "GHEP", newFilterString);
            }
            else if (filterValue is string emptyString && emptyString.Length == 1)
            {
                // Nếu chuỗi chỉ có 1 ký tự, xóa nó đi để làm rỗng ô lọc
                gridView7.SetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "GHEP", string.Empty);
            }
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            // Lấy giá trị hiện tại của cột 'CUOI' từ dòng lọc tự động
            object filterValue = gridView7.GetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "CUOI");

            // Khởi tạo một chuỗi mới
            string newFilterString;
            string filterString = filterValue?.ToString() ?? string.Empty;

            // Kiểm tra xem chuỗi có kết thúc bằng '%' không
            if (filterString.EndsWith("%"))
            {
                // Loại bỏ dấu '%' ở cuối chuỗi
                string mainString = filterString.Substring(0, filterString.Length - 1);

                // Nối thêm ký tự 'T' vào phần chuỗi chính, sau đó thêm lại dấu '%'
                newFilterString = mainString + "T" + "%";
            }
            else
            {
                // Nếu chuỗi không có '%', chỉ cần nối thêm 'T' vào cuối
                newFilterString = filterString + "T";
            }

            // Đặt lại giá trị đã chỉnh sửa vào dòng lọc tự động
            gridView7.SetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "CUOI", newFilterString);
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            // Lấy giá trị hiện tại của cột 'CUOI' từ dòng lọc tự động
            object filterValue = gridView7.GetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "CUOI");

            // Khởi tạo một chuỗi mới
            string newFilterString;
            string filterString = filterValue?.ToString() ?? string.Empty;

            // Kiểm tra xem chuỗi có kết thúc bằng '%' không
            if (filterString.EndsWith("%"))
            {
                // Loại bỏ dấu '%' ở cuối chuỗi
                string mainString = filterString.Substring(0, filterString.Length - 1);

                // Nối thêm ký tự 'T' vào phần chuỗi chính, sau đó thêm lại dấu '%'
                newFilterString = mainString + "X" + "%";
            }
            else
            {
                // Nếu chuỗi không có '%', chỉ cần nối thêm 'T' vào cuối
                newFilterString = filterString + "X";
            }

            // Đặt lại giá trị đã chỉnh sửa vào dòng lọc tự động
            gridView7.SetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "CUOI", newFilterString);
        }
    }
   }

