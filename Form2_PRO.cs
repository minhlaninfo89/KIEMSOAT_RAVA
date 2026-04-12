using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIEMSOAT_RAVAO
{
    public partial class Form2_PRO : Form
    {
        public Form2_PRO()
        {
            InitializeComponent();
            gridView3.CustomDrawCell += gridView3_CustomDrawCell;
        }
        private void get_sid()
        {
            if (comboBoxEdit1.Text == "20")
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand("TimKiemChuoiTrongBang_20", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ChuoiTimKiem", SqlDbType.NVarChar)).Value = richTextBox1.Text;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(comboBoxEdit1.Text == "10")
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand("TimKiemChuoiTrongBang_10", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ChuoiTimKiem", SqlDbType.NVarChar)).Value = richTextBox1.Text;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.Text == "30")
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand("TimKiemChuoiTrongBang_30", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ChuoiTimKiem", SqlDbType.NVarChar)).Value = richTextBox1.Text;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.Text == "40")
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand("TimKiemChuoiTrongBang_40", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ChuoiTimKiem", SqlDbType.NVarChar)).Value = richTextBox1.Text;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.Text == "80")
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand("TimKiemChuoiTrongBang_80", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ChuoiTimKiem", SqlDbType.NVarChar)).Value = richTextBox1.Text;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.Text == "90")
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand("TimKiemChuoiTrongBang_90", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ChuoiTimKiem", SqlDbType.NVarChar)).Value = richTextBox1.Text;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void get_sid2()
        {
            //try
            //{
            //    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            //    {
            //        con.Open();
            //        using (SqlCommand command = new SqlCommand("TimKiemChuoiTrongBang", con))
            //        {
            //            command.CommandType = CommandType.StoredProcedure;
            //            command.Parameters.Add(new SqlParameter("@ChuoiTimKiem", SqlDbType.NVarChar)).Value = richTextBox2.Text;

            //            using (SqlDataAdapter da = new SqlDataAdapter(command))
            //            {
            //                DataSet ds = new DataSet();
            //                da.Fill(ds);
            //                gridControl1.DataSource = ds.Tables[0];
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void gridView3_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //string searchText = richTextBox1.Text;
            //if (!string.IsNullOrEmpty(searchText) && e.CellValue != null)
            //{
            //    string cellValue = e.CellValue.ToString();
            //    if (cellValue.Contains(searchText))
            //    {
            //        // Tìm tất cả các vị trí của chuỗi tìm kiếm trong cell
            //        List<int> startIndexList = new List<int>();
            //        int startIndex = 0;
            //        while ((startIndex = cellValue.IndexOf(searchText, startIndex)) != -1)
            //        {
            //            startIndexList.Add(startIndex);
            //            startIndex += searchText.Length;
            //        }

            //        if (startIndexList.Count > 0)
            //        {
            //            // Vẽ nội dung của cell
            //            int currentPosition = 0;
            //            foreach (int highlightStartIndex in startIndexList)
            //            {
            //                // Vẽ phần trước chuỗi tìm kiếm
            //                e.Appearance.DrawString(e.Cache, cellValue.Substring(currentPosition, highlightStartIndex - currentPosition), e.Bounds);

            //                // Highlight chuỗi tìm kiếm
            //                Rectangle highlightBounds = e.Bounds;
            //                highlightBounds.X += (int)e.Appearance.CalcTextSize(e.Cache, cellValue.Substring(currentPosition, highlightStartIndex - currentPosition), e.Bounds.Width).Width;
            //                highlightBounds.Width = (int)e.Appearance.CalcTextSize(e.Cache, searchText, e.Bounds.Width).Width;
            //                e.Appearance.FillRectangle(e.Cache, Color.Yellow, highlightBounds); // Màu highlight
            //                e.Appearance.DrawString(e.Cache, searchText, highlightBounds, e.Appearance.GetForeBrush(Color.Red)); // Màu chữ

            //                // Cập nhật vị trí hiện tại
            //                currentPosition = highlightStartIndex + searchText.Length;
            //            }

            //            // Vẽ phần còn lại của cell (nếu có)
            //            if (currentPosition < cellValue.Length)
            //            {
            //                e.Appearance.DrawString(e.Cache, cellValue.Substring(currentPosition), e.Bounds.X + (int)e.Appearance.CalcTextSize(e.Cache, cellValue.Substring(0, currentPosition), e.Bounds.Width).Width, e.Bounds.Y);
            //            }

            //            e.Handled = true;
            //        }
            //    }
            //}
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
            richTextBox1.SelectionColor = Color.Black;

            // Lặp qua từng ký tự và thay đổi màu
            for (int i = 0; i < text.Length; i++)
            {
                richTextBox1.Select(i, 1); // Chọn từng ký tự

                if (text[i] == 'T')
                {
                    richTextBox1.SelectionColor = Color.Maroon; // Màu cho ký tự T
                }
                else if (text[i] == 'X')
                {
                    richTextBox1.SelectionColor = Color.Blue; // Màu cho ký tự X
                }
            }

            // Phục hồi vị trí con trỏ
            richTextBox1.SelectionStart = currentSelectionStart;
            richTextBox1.SelectionLength = currentSelectionLength;

            // Bật lại cập nhật giao diện
            richTextBox1.ResumeLayout();
        }
        //private void UpdateRichTextBoxColors2()
        //{
        //    // Lấy chuỗi hiện tại trong RichTextBox
        //    string text = richTextBox2.Text;

        //    // Lưu trữ vị trí con trỏ
        //    int currentSelectionStart = richTextBox2.SelectionStart;
        //    int currentSelectionLength = richTextBox2.SelectionLength;

        //    // Tắt cập nhật giao diện để tránh nhấp nháy
        //    richTextBox2.SuspendLayout();

        //    // Xóa định dạng cũ
        //    richTextBox2.SelectAll();
        //    richTextBox2.SelectionColor = Color.Black;

        //    // Lặp qua từng ký tự và thay đổi màu
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        richTextBox2.Select(i, 1); // Chọn từng ký tự

        //        if (text[i] == 'T')
        //        {
        //            richTextBox2.SelectionColor = Color.Maroon; // Màu cho ký tự T
        //        }
        //        else if (text[i] == 'X')
        //        {
        //            richTextBox2.SelectionColor = Color.Blue; // Màu cho ký tự X
        //        }
        //    }

        //    // Phục hồi vị trí con trỏ
        //    richTextBox2.SelectionStart = currentSelectionStart;
        //    richTextBox2.SelectionLength = currentSelectionLength;

        //    // Bật lại cập nhật giao diện
        //    richTextBox2.ResumeLayout();
        //}
        private void UpdateRTextBox(string stringToAdd)
        {
            // Lấy giá trị hiện tại của richTextBox1
            string currentText = richTextBox1.Text;
            // Thêm chuỗi mới vào cuối
            currentText += stringToAdd;

            // Cập nhật giá trị mới cho richTextBox1
            richTextBox1.Text = currentText;
          
            {
                if (richTextBox1.Text.Length > 15)
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(1);
                }
            }
            //if (checkEdit1.Checked == false && ck_10.Checked == false)
            //{
            //    if (richTextBox1.TextLength >= 15)
            //    {
            //        get_sid();
            //    }
            //}
            //else if (checkEdit1.Checked == false && ck_10.Checked == true)
            //{
            //    if (richTextBox1.TextLength >= 10)
            //    {
            //        get_sid();
            //    }
            //}

        }
        private void UpdateRTextBox2(string stringToAdd)
        {
        //    // Lấy giá trị hiện tại của richTextBox1
        //    string currentText = richTextBox2.Text;
        //    // Thêm chuỗi mới vào cuối
        //    currentText += stringToAdd;

        //    // Cập nhật giá trị mới cho richTextBox1
        //    richTextBox2.Text = currentText;

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.ToUpper();
            richTextBox1.SelectionStart = richTextBox1.Text.Length; // Đặt con trỏ về cuối văn bản
            UpdateRichTextBoxColors();
            CountCharacters();
            if (checkEdit1.Checked == false)
            {
                if (richTextBox1.TextLength >= 15)
                {
                    get_sid();
                }
            }
            
        

        }

        private void Form2_PRO_Load(object sender, EventArgs e)
        {
            //get_sid();
            checkEdit1.Checked = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(1);
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==15)
            { get_sid(); }    
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
        private void CountCharacters()
        {
            // Lấy tổng số ký tự trong RichTextBox
            int characterCount = richTextBox1.Text.Length;
            labelControl2.Text = $"{characterCount}";

        }
        private void CountCharacters2()
        {
            //// Lấy tổng số ký tự trong RichTextBox
            //int characterCount = richTextBox2.Text.Length;
            //labelControl1.Text = $"{characterCount}";

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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
        }

        private void gridView3_CustomDrawCell_1(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            // Xử lý cho nhóm cột SoLuongTSau và SoLuongXSau
            if (e.Column.FieldName == "SoLuongTSau" || e.Column.FieldName == "SoLuongXSau")
            {
                // Lấy giá trị của cột T và X
                var valueT = gridView3.GetRowCellValue(e.RowHandle, "SoLuongTSau");
                var valueX = gridView3.GetRowCellValue(e.RowHandle, "SoLuongXSau");

                // So sánh giá trị (đảm bảo đã kiểm tra null và chuyển đổi sang số nếu cần)
                if (valueT != null && valueX != null)
                {
                    double doubleValueT, doubleValueX;
                    if (double.TryParse(valueT.ToString(), out doubleValueT) && double.TryParse(valueX.ToString(), out doubleValueX))
                    {
                        if (doubleValueT > doubleValueX)
                        {
                            // Nếu T lớn hơn X, đổi màu nền ô cột T thành đỏ
                            if (e.Column.FieldName == "SoLuongTSau")
                            {
                                e.Appearance.BackColor = Color.Cyan; // Đổi màu nền thành xanh cyan
                                e.Appearance.ForeColor = Color.Maroon; // Đổi màu chữ thành nâu đỏ
                                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold); // In đậm chữ
                            }
                        }
                        else if (doubleValueX > doubleValueT)
                        {
                            // Nếu X lớn hơn T, đổi màu nền ô cột X thành đỏ
                            if (e.Column.FieldName == "SoLuongXSau")
                            {
                                e.Appearance.BackColor = Color.Cyan; // Đổi màu nền thành xanh cyan
                                e.Appearance.ForeColor = Color.Maroon; // Đổi màu chữ thành nâu đỏ
                                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold); // In đậm chữ
                            }
                        }
                    }
                }
            }

            // Xử lý cho nhóm cột SoLuongTTruoc và SoLuongXTruoc
            if (e.Column.FieldName == "SoLuongTTruoc" || e.Column.FieldName == "SoLuongXTruoc")
            {
                // Lấy giá trị của cột T và X
                var valueTT = gridView3.GetRowCellValue(e.RowHandle, "SoLuongTTruoc");
                var valueXT = gridView3.GetRowCellValue(e.RowHandle, "SoLuongXTruoc");

                // So sánh giá trị (đảm bảo đã kiểm tra null và chuyển đổi sang số nếu cần)
                if (valueTT != null && valueXT != null)
                {
                    double doubleValueTT, doubleValueXT;
                    if (double.TryParse(valueTT.ToString(), out doubleValueTT) && double.TryParse(valueXT.ToString(), out doubleValueXT))
                    {
                        if (doubleValueTT > doubleValueXT)
                        {
                            // Nếu T lớn hơn X, đổi màu nền ô cột T thành đỏ
                            if (e.Column.FieldName == "SoLuongTTruoc")
                            {
                                e.Appearance.BackColor = Color.Cyan; // Đổi màu nền thành xanh cyan
                                e.Appearance.ForeColor = Color.Maroon; // Đổi màu chữ thành nâu đỏ
                                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold); // In đậm chữ
                            }
                        }
                        else if (doubleValueXT > doubleValueTT)
                        {
                            // Nếu X lớn hơn T, đổi màu nền ô cột X thành đỏ
                            if (e.Column.FieldName == "SoLuongXTruoc")
                            {
                                e.Appearance.BackColor = Color.Cyan; // Đổi màu nền thành xanh cyan
                                e.Appearance.ForeColor = Color.Maroon; // Đổi màu chữ thành nâu đỏ
                                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold); // In đậm chữ
                            }
                        }
                    }
                }
            }
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

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            UpdateRTextBox2("T");
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            UpdateRTextBox2("X");
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            //if (richTextBox2.Text.Length > 0)
            //{
            //    richTextBox2.Text = richTextBox2.Text.Substring(0, richTextBox2.Text.Length - 1);
            //}
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            //if (richTextBox2.Text.Length > 0)
            //{
            //    richTextBox2.Text = richTextBox2.Text.Substring(1);
            //}
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "KetQua") // **Đảm bảo "KetQua" là FieldName chính xác của cột Kết quả**
            {
                string ketQuaValue = e.CellValue as string; // Lấy giá trị cột Kết quả

                if (!string.IsNullOrEmpty(ketQuaValue))
                {
                    e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; // Cải thiện hiển thị văn bản

                    float currentX = e.Bounds.X; // Vị trí X bắt đầu vẽ văn bản
                    float charWidth;

                    // Lặp qua từng ký tự trong chuỗi "KetQua"
                    foreach (char character in ketQuaValue)
                    {
                        Color charColor = Color.Black; // Màu mặc định nếu không phải T hoặc X

                        if (character == 'T')
                        {
                            charColor = Color.Maroon; // Màu xanh cho chữ T
                        }
                        else if (character == 'X')
                        {
                            charColor = Color.Blue;  // Màu đỏ cho chữ X
                        }

                        using (SolidBrush brush = new SolidBrush(charColor)) // Brush với màu tương ứng
                        {
                            string charString = character.ToString();
                            SizeF charSize = e.Graphics.MeasureString(charString, e.Appearance.Font); // Đo kích thước ký tự

                            // Vẽ ký tự
                            e.Graphics.DrawString(charString, e.Appearance.Font, brush, new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - charSize.Height) / 2));

                            charWidth = charSize.Width;
                            currentX += charWidth; // Cập nhật vị trí X cho ký tự tiếp theo
                        }
                    }
                    e.Handled = true; // Đánh dấu là đã tự xử lý vẽ ô này, GridControl không cần vẽ nữa
                }
            }
            //// Kiểm tra nếu cột hiện tại là cột T hoặc X (**LƯU Ý: Sửa FieldName theo tên cột thực tế của bạn**)
            //if (e.Column.FieldName == "SoLuongT" || e.Column.FieldName == "SoLuongX")
            //{
            //    // Lấy giá trị của cột T và X
            //    var valueT = gridView1.GetRowCellValue(e.RowHandle, "SoLuongT"); // **LƯU Ý: Sửa FieldName theo tên cột thực tế của bạn**
            //    var valueX = gridView1.GetRowCellValue(e.RowHandle, "SoLuongX"); // **LƯU Ý: Sửa FieldName theo tên cột thực tế của bạn**

            //    // So sánh giá trị (đảm bảo đã kiểm tra null và chuyển đổi sang số nếu cần)
            //    if (valueT != null && valueX != null)
            //    {
            //        double doubleValueT, doubleValueX;
            //        if (double.TryParse(valueT.ToString(), out doubleValueT) && double.TryParse(valueX.ToString(), out doubleValueX))
            //        {
            //            if (doubleValueT > doubleValueX)
            //            {
            //                // Nếu T lớn hơn X, đổi màu nền ô cột T thành đỏ
            //                if (e.Column.FieldName == "SoLuongT")
            //                {
            //                    e.Appearance.BackColor = Color.Cyan; // Đổi màu nền thành đỏ
            //                    e.Appearance.ForeColor = Color.Maroon; // Đổi màu nền thành đỏ
            //                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold); // **THÊM DÒNG NÀY ĐỂ IN ĐẬM CHỮ**
            //                }
            //            }
            //            else if (doubleValueX > doubleValueT)
            //            {
            //                // Nếu X lớn hơn T, đổi màu nền ô cột X thành đỏ
            //                if (e.Column.FieldName == "SoLuongX")
            //                {
            //                    e.Appearance.BackColor = Color.Cyan; // Đổi màu nền thành đỏ
            //                    e.Appearance.ForeColor = Color.Maroon; // Đổi màu nền thành đỏ
            //                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold); // **THÊM DÒNG NÀY ĐỂ IN ĐẬM CHỮ**
            //                }
            //            }
            //            // Trường hợp bằng nhau (doubleValueT == doubleValueX), không làm gì (hoặc bạn có thể tùy chỉnh nếu muốn)
            //        }
            //    }
            //}
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            //richTextBox2.Text = richTextBox2.Text.ToUpper();
            //richTextBox2.SelectionStart = richTextBox2.Text.Length; // Đặt con trỏ về cuối văn bản
            //UpdateRichTextBoxColors2();
            //CountCharacters2();
            //if (richTextBox2.TextLength >= 12)
            //{
            //    get_sid2();
            //}

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            string excelPath = @"C:\Users\SUPPORT\Desktop\GET_DATA_GPT_THUONG.xlsx";

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

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
        }
        private void UpdateRTextBox_dau(string stringToAdd)
        {
            // Lấy giá trị hiện tại của richTextBox1
            string currentText = richTextBox1.Text;

            // Thêm chuỗi mới vào đầu
            currentText = stringToAdd + currentText;

            // Cập nhật giá trị mới cho richTextBox1
            richTextBox1.Text = currentText;

            // Giới hạn độ dài của richTextBox1.Text nếu vượt quá 15 ký tự
            
                if (richTextBox1.Text.Length > 10)
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(0, 10);
                }
            
                
        }
        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox_dau("X");
        }

        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            UpdateRTextBox_dau("T");
        }

        private void comboBoxEdit1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == false)
            {
               
                    get_sid();
              
            }
        }

        private void ck_10_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
