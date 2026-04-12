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
using DocumentFormat.OpenXml.Wordprocessing;

namespace KIEMSOAT_RAVAO
{
    public partial class MOI : Form
    {
        public MOI()
        {
            InitializeComponent();
            BalanceTableLayoutPanel(this.tableLayoutPanel2);
            BalanceTableLayoutPanel(this.tableLayoutPanel1);


        }
        private void get_dulieu()

        {
            if (comboBoxEdit1.Text == "6")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("MOI_6", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
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
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
            if (comboBoxEdit1.Text == "10")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("MOI_10", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
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
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
            if (comboBoxEdit1.Text == "6")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("MOI_6", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
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
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
            if (comboBoxEdit1.Text == "7")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("MOI_7", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
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
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
            if (comboBoxEdit1.Text == "8")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("MOI_8", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
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
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
            if (comboBoxEdit1.Text == "9")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("MOI_9", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
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
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
            if (comboBoxEdit1.Text == "11")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        using (SqlCommand command = new SqlCommand("MOI_11", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
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

                        using (SqlCommand command = new SqlCommand("MOI", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.CommandTimeout = 0; // Đặt Command Timeout = 0
                            command.ExecuteNonQuery();
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

                        using (SqlCommand command = new SqlCommand("MOI_14", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
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

                        using (SqlCommand command = new SqlCommand("MOI_13", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
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

                        using (SqlCommand command = new SqlCommand("MOI_12", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@InputSequence", inputNumbers);
                            command.ExecuteNonQuery();
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
                    //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridControl7.DataSource = null;
                }
            }
        }

        private void splitContainer11_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MOI_Load(object sender, EventArgs e)
        {
            get_dulieu();
            checkEdit1.Checked = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            get_dulieu();
        }

        private void gridView7_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "CUOI")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "CUOI"));
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
            if (e.Column.FieldName == "TT1")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "TT1"));
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
            if (e.Column.FieldName == "TT2")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "TT2"));
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
          
            if (e.Column.FieldName == "TT4")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "TT4"));
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
            if (e.Column.FieldName == "TT5")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "TT5"));
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
        private string filterPattern = ""; // Biến toàn cục lưu chuỗi T,X,...

        private void ApplyCustomFilterFromTextBox()
        {
            string rawInput = richTextBox1.Text.ToUpper().Replace(",", "").Trim();
            if (comboBoxEdit1.Text == "10")
            {
                if (rawInput.Length == 10)
                {
                    filterPattern = rawInput;
                    gridView7.RefreshData(); // Gọi để áp lại filter
                }
                else
                {
                    filterPattern = ""; // Không lọc nếu chưa đủ
                    gridView7.RefreshData();
                }
            }
            if (comboBoxEdit1.Text == "6")
            {
                if (rawInput.Length == 6)
                {
                    filterPattern = rawInput;
                    gridView7.RefreshData(); // Gọi để áp lại filter
                }
                else
                {
                    filterPattern = ""; // Không lọc nếu chưa đủ
                    gridView7.RefreshData();
                }
            }
            if (comboBoxEdit1.Text == "11")
            {
                if (rawInput.Length == 11)
                {
                    filterPattern = rawInput;
                    gridView7.RefreshData(); // Gọi để áp lại filter
                }
                else
                {
                    filterPattern = ""; // Không lọc nếu chưa đủ
                    gridView7.RefreshData();
                }
            }
            if (comboBoxEdit1.Text == "14")
            {
                if (rawInput.Length == 14)
                {
                    filterPattern = rawInput;
                    gridView7.RefreshData(); // Gọi để áp lại filter
                }
                else
                {
                    filterPattern = ""; // Không lọc nếu chưa đủ
                    gridView7.RefreshData();
                }
            }
            if (comboBoxEdit1.Text == "15")
            {
                if (rawInput.Length == 15)
                {
                    filterPattern = rawInput;
                    gridView7.RefreshData(); // Gọi để áp lại filter
                }
                else
                {
                    filterPattern = ""; // Không lọc nếu chưa đủ
                    gridView7.RefreshData();
                }
            }
            if (comboBoxEdit1.Text == "13")
            {
                if (rawInput.Length == 13)
                {
                    filterPattern = rawInput;
                    gridView7.RefreshData(); // Gọi để áp lại filter
                }
                else
                {
                    filterPattern = ""; // Không lọc nếu chưa đủ
                    gridView7.RefreshData();
                }
            }
            if (comboBoxEdit1.Text == "12")
            {
                if (rawInput.Length == 12)
                {
                    filterPattern = rawInput;
                    gridView7.RefreshData(); // Gọi để áp lại filter
                }
                else
                {
                    filterPattern = ""; // Không lọc nếu chưa đủ
                    gridView7.RefreshData();
                }
            }
        }


        private void UpdateRTextBox(string stringToAdd)
        {
            // Lấy giá trị hiện tại
            string currentText = richTextBox1.Text;

            // Thêm chuỗi mới vào cuối (có dấu phẩy nếu cần)
            if (!string.IsNullOrEmpty(currentText))
                currentText += "," + stringToAdd;
            else
                currentText = stringToAdd;

            // Cắt bớt nếu dài quá 12 ký tự (tính cả dấu phẩy)
            // => tách ra theo dấu phẩy để giới hạn số phần tử
            string[] parts = currentText.Split(',');
            if (comboBoxEdit1.Text == "10")
            {
                if (parts.Length > 10)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "6")
            {
                if (parts.Length > 6)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "7")
            {
                if (parts.Length > 7)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "8")
            {
                if (parts.Length > 8)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "9")
            {
                if (parts.Length > 9)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "11")
            {
                if (parts.Length > 11)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "14")
            {
                if (parts.Length > 14)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
             if (comboBoxEdit1.Text == "15")
            {
                if (parts.Length > 15)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "13")
            {
                if (parts.Length > 13)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "12")
            {
                if (parts.Length > 12)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }

            // Gộp lại chuỗi với dấu phẩy
            richTextBox1.Text = string.Join(",", parts);
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
        private void gridView7_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "TT1")
            {
                string cellValue = e.CellValue as string;
                if (!string.IsNullOrEmpty(cellValue))
                {
                    e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                    float currentX = e.Bounds.X;
                    float charWidth;

                    System.Drawing.Font boldFont = new System.Drawing.Font(e.Appearance.Font, FontStyle.Bold);

                    // Tách chuỗi theo dấu phẩy
                    string[] values = cellValue.Split(',');

                    foreach (string val in values)
                    {
                        string trimmed = val.Trim();

                        System.Drawing.Color color;
                        if (int.TryParse(trimmed, out int number))
                        {
                            color = number > 10 ? System.Drawing.Color.Maroon : System.Drawing.Color.Blue;
                        }
                        else
                        {
                            color = System.Drawing.Color.Gray; // Trường hợp lỗi hoặc không phải số
                        }

                        using (SolidBrush brush = new SolidBrush(color))
                        {
                            SizeF size = e.Graphics.MeasureString(trimmed, boldFont);

                            e.Graphics.DrawString(trimmed, boldFont, brush,
                                new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - size.Height) / 2));

                            charWidth = size.Width;
                            currentX += charWidth + 8; // khoảng cách giữa các số
                        }
                    }

                    boldFont.Dispose();
                    e.Handled = true;
                }
            }
            // THAY "GHEP1" BẰNG TÊN FIELDNAME CỦA CỘT BẠN MUỐN VẼ
            // THAY "GHEP1" BẰNG TÊN FIELDNAME CỦA CỘT BẠN MUỐN VẼ
            if (e.Column.FieldName == "CHUOITIEPTHEO") // Đảm bảo FieldName chính xác của cột
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
            if (e.Column.FieldName == "GHEP1")
            {
                string cellValue = e.CellValue as string;
                if (string.IsNullOrEmpty(cellValue))
                {
                    return;
                }

                List<int> numbers = new List<int>();
                string[] parts = cellValue.Split(',');
                foreach (string part in parts)
                {
                    if (int.TryParse(part.Trim(), out int num))
                    {
                        numbers.Add(num);
                    }
                }

                if (numbers.Count < 2)
                {
                    return;
                }

                int minDataValue = numbers.Min();
                int maxDataValue = numbers.Max();
                int dataRange = maxDataValue - minDataValue;

                const int PADDING = 5;

                RectangleF drawingBounds = new RectangleF(
                    e.Bounds.X + PADDING,
                    e.Bounds.Y + PADDING,
                    e.Bounds.Width - 2 * PADDING,
                    e.Bounds.Height - 2 * PADDING
                );

                List<PointF> points = new List<PointF>();
                float xStep = drawingBounds.Width / (numbers.Count - 1);

                for (int i = 0; i < numbers.Count; i++)
                {
                    float x = drawingBounds.X + (i * xStep);
                    float y;

                    if (dataRange == 0)
                    {
                        y = drawingBounds.Y + drawingBounds.Height / 2;
                    }
                    else
                    {
                        float normalizedY = (float)(numbers[i] - minDataValue) / dataRange;
                        y = drawingBounds.Bottom - (normalizedY * drawingBounds.Height);
                    }

                    points.Add(new PointF(x, y));
                }

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Vẽ đường viền (lót nền)
                using (Pen casingPen = new Pen(System.Drawing.Color.FromArgb(100, System.Drawing.Color.Black), 5))
                {
                    casingPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                    e.Graphics.DrawLines(casingPen, points.ToArray());
                }

                // Vẽ đường kẻ chính
                using (Pen linePen = new Pen(System.Drawing.Color.White, 3))
                {
                    linePen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                    e.Graphics.DrawLines(linePen, points.ToArray());
                }

                // ==========================================================
                // KHỐI VẼ SỐ ĐÃ ĐƯỢC CẬP NHẬT (CHỈ CÒN VẼ ĐIỂM NÚT)
                // ==========================================================
                using (SolidBrush pointBrush = new SolidBrush(System.Drawing.Color.Crimson))
                {
                    for (int i = 0; i < points.Count; i++)
                    {
                        // Chỉ vẽ một hình tròn nhỏ tại mỗi điểm
                        RectangleF pointRect = new RectangleF(points[i].X - 3, points[i].Y - 3, 6, 6);
                        e.Graphics.FillEllipse(pointBrush, pointRect);
                    }
                }

                e.Handled = true;
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            richTextBox4.Text = string.Empty;
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            //richTextBox4.Text = string.Empty;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = richTextBox1.SelectionStart;

            // Chuyển toàn bộ văn bản thành chữ hoa
            richTextBox1.Text = richTextBox1.Text.ToUpper();

            // Phục hồi vị trí con trỏ
            richTextBox1.SelectionStart = cursorPosition;
            UpdateRichTextBoxColors();

            //ApplyCustomFilterFromTextBox();
            //UpdateGhepFilter(); // Chỉ cập nhật filterGhep

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
        private bool IsMatchPattern(string valueStr, string pattern)
        {
            string[] values = valueStr.Split(',');
            if (values.Length < pattern.Length) return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                char cond = pattern[i];
                if (int.TryParse(values[i].Trim(), out int val))
                {
                    if (cond == 'T' && val <= 10) return false;
                    if (cond == 'X' && val > 10) return false;
                }
                else return false;
            }

            return true;
        }

     
        private void UpdateRTextBox4(string stringToAdd)
        {
            // Lấy giá trị hiện tại
            string currentText = richTextBox4.Text;

            // Thêm chuỗi mới vào cuối (có dấu phẩy nếu cần)
            if (!string.IsNullOrEmpty(currentText))
                currentText += "," + stringToAdd;
            else
                currentText = stringToAdd;

            // Cắt bớt nếu dài quá 12 ký tự (tính cả dấu phẩy)
            // => tách ra theo dấu phẩy để giới hạn số phần tử
            string[] parts = currentText.Split(',');
            if (comboBoxEdit1.Text == "6")
            {
                if (parts.Length > 6)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "7")
            {
                if (parts.Length > 7)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "8")
            {
                if (parts.Length > 8)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "9")
            {
                if (parts.Length > 9)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "10")
            {
                if (parts.Length > 10)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "11")
            {
                if (parts.Length > 11)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "14")
            {
                if (parts.Length > 14)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "15")
            {
                if (parts.Length > 15)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "13")
            {
                if (parts.Length > 13)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            if (comboBoxEdit1.Text == "12")
            {
                if (parts.Length > 12)
                {
                    // Bỏ phần tử đầu (FIFO kiểu queue)
                    parts = parts.Skip(1).ToArray();
                }
            }
            //// Gộp lại chuỗi với dấu phẩy
            richTextBox4.Text = string.Join(",", parts);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            UpdateRTextBox4("T");
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            UpdateRTextBox4("X");
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            // Lấy chuỗi số mẫu mà người dùng nhập vào
            string sampleSequence = richTextBox4.Text;

            // Từ chuỗi số mẫu, suy ra mẫu hình dạng "DNA" phức hợp
            this.filterComplexPattern = DeriveComplexPattern(sampleSequence);

            // Xóa bộ lọc cũ để tránh xung đột
            this.filterCuoi = "";

            // Yêu cầu GridView tự lọc lại dữ liệu với mẫu "DNA" mới
            gridView7.RefreshData();

            // Phần cập nhật màu sắc có thể giữ lại nếu muốn
            UpdateRichTextBoxColors4();
        }
        private string filterGhep = "";
        private string filterCuoi = "";

        private void UpdateGhepFilter()
        {
            string input1 = richTextBox1.Text.ToUpper().Replace(",", "").Trim();
            if (comboBoxEdit1.Text == "10")
            {
                if (input1.Length == 10)
                {
                    filterGhep = input1;
                }
                else
                {
                    filterGhep = ""; // clear nếu không hợp lệ
                }
            }
            if (comboBoxEdit1.Text == "6")
            {
                if (input1.Length == 6)
                {
                    filterGhep = input1;
                }
                else
                {
                    filterGhep = ""; // clear nếu không hợp lệ
                }
            }
            if (comboBoxEdit1.Text == "11")
            {
                if (input1.Length == 11)
                {
                    filterGhep = input1;
                }
                else
                {
                    filterGhep = ""; // clear nếu không hợp lệ
                }
            }
            if (comboBoxEdit1.Text=="14")
           {
                if (input1.Length == 14)
                {
                    filterGhep = input1;
                }
                else
                {
                    filterGhep = ""; // clear nếu không hợp lệ
                }
            }
            if (comboBoxEdit1.Text == "15")
            {
                if (input1.Length == 15)
                {
                    filterGhep = input1;
                }
                else
                {
                    filterGhep = ""; // clear nếu không hợp lệ
                }
            }
            if (comboBoxEdit1.Text == "13")
            {
                if (input1.Length == 13)
                {
                    filterGhep = input1;
                }
                else
                {
                    filterGhep = ""; // clear nếu không hợp lệ
                }
            }
            if (comboBoxEdit1.Text == "12")
            {
                if (input1.Length == 12)
                {
                    filterGhep = input1;
                }
                else
                {
                    filterGhep = ""; // clear nếu không hợp lệ
                }
            }
            gridView7.RefreshData();
        }

        private void UpdateCuoiFilter()
        {
            string input4 = richTextBox4.Text.ToUpper().Replace(",", "").Trim();
                filterCuoi = input4;
            gridView7.RefreshData(); // <- BẮT BUỘC GỌI ĐÂY
        }
        private void FilterGridCombined1(string searchCUOI,  string TT2, string TT3)
        {
            if (gridView7 != null)
            {
                string currentSearchCUOI = searchCUOI;

                while (true) // Vòng lặp vô hạn, sẽ thoát ra bằng lệnh break
                {
                    List<string> filterParts = new List<string>();

                    // Xây dựng chuỗi lọc cho GHEP1
                    if (!string.IsNullOrEmpty(currentSearchCUOI))
                    {
                        filterParts.Add($"[GHEP1] LIKE '%{currentSearchCUOI}'");
                    }

                    //if (!string.IsNullOrEmpty(TT0))
                    //{
                    //    filterParts.Add($"[TT0] = '{TT0}'");
                    //}
                    ////// Thêm các điều kiện lọc cho TT1, TT2, TT3
                    //if (!string.IsNullOrEmpty(TT1))
                    //{
                    //    filterParts.Add($"[TT1] = '{TT1}'");
                    //}
                    if (!string.IsNullOrEmpty(TT2))
                    {
                        filterParts.Add($"[TT2] = '{TT2}'");
                    }
                    if (!string.IsNullOrEmpty(TT3))
                    {
                        filterParts.Add($"[TT3] = '{TT3}'");
                    }

                    // Áp dụng chuỗi lọc
                    gridView7.ActiveFilterString = string.Join(" AND ", filterParts);

                    // Cho phép giao diện cập nhật
                    Application.DoEvents();

                    // Kiểm tra kết quả lọc
                    if (gridView7.RowCount >= 2 || string.IsNullOrEmpty(currentSearchCUOI))
                    {
                        // Dừng vòng lặp nếu tìm thấy kết quả hoặc chuỗi lọc đã rỗng
                        break;
                    }
                    else
                    {
                        // Nếu không tìm thấy dòng nào và chuỗi lọc chưa rỗng, xóa 1 ký tự đầu
                        if (currentSearchCUOI.Length > 0)
                        {
                            currentSearchCUOI = currentSearchCUOI.Substring(2);
                        }
                    }
                }
            }
        }
        private void FilterGridCombined(string searchCUOI)
        {
            if (gridView7 != null)
            {
                List<string> filterParts = new List<string>();

                if (!string.IsNullOrEmpty(searchCUOI))
                {
                    filterParts.Add($"[GHEP] = '%{searchCUOI}'");
                }
             
                gridView7.ActiveFilterString = string.Join(" AND ", filterParts);
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                ImportExcelToSQL();
                MessageBox.Show("Dữ liệu đã được chèn thành công từ Sheet2, cột B!");
                INS_GOM();
                get_dulieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            //FilterGridCombined(richTextBox1.Text,rich_hieuso3.Text);


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            richTxtHinhDang.Text = string.Empty;
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = string.Empty;
        }

        private void gridView7_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //// Thay "TenCotCuaBan" bằng tên thật của cột (FieldName) mà bạn muốn thay đổi
            //if (e.Column.FieldName == "GHEP")
            //{
            //    // Đảm bảo giá trị không null và là kiểu chuỗi
            //    if (e.Value != null)
            //    {
            //        string originalValue = e.Value.ToString();

            //        // Kiểm tra chuỗi có đủ 12 ký tự hoặc ít nhất 2 ký tự
            //        if (originalValue.Length >= 2)
            //        {
            //            // Lấy 2 ký tự cuối
            //            string lastTwoChars = originalValue.Substring(originalValue.Length - 4);

            //            // Gán lại giá trị hiển thị. Bạn có thể chọn 1 trong 2 cách sau:

            //            // Cách 1: Hiển thị dạng mặt nạ (**********XX)
            //            //e.DisplayText = "**********" + lastTwoChars;

            //            // Cách 2: Chỉ hiển thị 2 ký tự cuối (XX)
            //             e.DisplayText = lastTwoChars;
            //        }
            //    }
            //}
        }

        //private void gridView7_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        //{
        //    // Chỉ xử lý cho cột mà chúng ta đã thiết lập SortMode = Custom
        //    if (e.Column.FieldName == "GHEP")
        //    {
        //        // Lấy giá trị của 2 ô đang được so sánh
        //        string value1 = e.Value1?.ToString();
        //        string value2 = e.Value2?.ToString();

        //        // Xử lý trường hợp giá trị là null hoặc không hợp lệ
        //        if (string.IsNullOrEmpty(value1) || value1.Length < 2)
        //        {
        //            e.Result = -1; // Đẩy giá trị không hợp lệ xuống cuối
        //            e.Handled = true;
        //            return;
        //        }
        //        if (string.IsNullOrEmpty(value2) || value2.Length < 2)
        //        {
        //            e.Result = 1;
        //            e.Handled = true;
        //            return;
        //        }

        //        // Lấy 2 ký tự cuối từ mỗi giá trị
        //        string lastTwo1 = value1.Substring(value1.Length - 2);
        //        string lastTwo2 = value2.Substring(value2.Length - 2);

        //        // So sánh 2 chuỗi ký tự cuối và trả về kết quả
        //        // e.Result nhận giá trị -1, 0, hoặc 1
        //        e.Result = string.Compare(lastTwo1, lastTwo2);

        //        // Báo cho GridView biết rằng chúng ta đã xử lý xong việc so sánh
        //        // và không cần nó thực hiện logic sắp xếp mặc định nữa.
        //        e.Handled = true;
        //    }
        //}

        private void comboBoxEdit1_TextChanged(object sender, EventArgs e)
        {
            get_dulieu();
        }
        // Thay thế các biến filter cũ bằng biến này
        private string filterComplexPattern = "";
        /// <summary>
        /// Suy ra mẫu "DNA" phức hợp, kết hợp Tăng/Giảm và Tài/Xỉu.
        /// </summary>
        /// <param name="valueStr">Chuỗi số, ví dụ: "13,9,12,16,8"</param>
        /// <returns>Chuỗi DNA, ví dụ: "T,GX,TT,TT,GX"</returns>
        private string DeriveComplexPattern(string valueStr)
        {
            // Chuyển chuỗi thành danh sách số
            List<int> numbers = new List<int>();
            string[] parts = valueStr.Split(',');
            foreach (string part in parts)
            {
                if (int.TryParse(part.Trim(), out int num))
                {
                    numbers.Add(num);
                }
            }

            if (numbers.Count == 0)
            {
                return "";
            }

            List<string> patternParts = new List<string>();

            // 1. Xử lý số đầu tiên (chỉ có trạng thái Tài/Xỉu)
            patternParts.Add(numbers[0] > 10 ? "T" : "X");

            // 2. Xử lý các số còn lại (có cả Tăng/Giảm và Tài/Xỉu)
            if (numbers.Count > 1)
            {
                for (int i = 1; i < numbers.Count; i++)
                {
                    int numPrevious = numbers[i - 1];
                    int numCurrent = numbers[i];

                    string change, state;

                    // Xác định Tăng/Giảm/Bằng
                    if (numCurrent > numPrevious) change = "T";
                    else if (numCurrent < numPrevious) change = "G";
                    else change = "B";

                    // Xác định trạng thái Tài/Xỉu của số hiện tại
                    state = numCurrent > 10 ? "T" : "X";

                    patternParts.Add(change + state);
                }
            }

            return string.Join(",", patternParts);
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

        private void CalculateDifference()
        {
            string inputNumbers = richTxtHinhDang.Text.Trim();

            // Ensure there are numbers to process
            if (string.IsNullOrEmpty(inputNumbers))
            {
                rich_hieuso3.Text = "0"; // Or clear all difference fields if preferred
                rich_hieuso2.Text = "0";
                rich_hieuso1.Text = "0";
                rich_hieuso0.Text = "0";


                return;
            }

            List<string> numbersAsString = inputNumbers.Split(',').ToList();
            List<int> numbers = new List<int>();

            // Convert string numbers to integers
            foreach (string numStr in numbersAsString)
            {
                if (int.TryParse(numStr.Trim(), out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    // Handle cases where conversion fails (e.g., non-numeric input)
                    rich_hieuso3.Text = "Invalid input"; // More descriptive error
                    rich_hieuso2.Text = "Invalid input";
                    rich_hieuso1.Text = "Invalid input";
                    rich_hieuso0.Text = "Invalid input";

                    return;
                }
            }

            // Ensure there are enough numbers for the calculations
            // We need numbers[0], numbers[1], numbers[2], numbers[3]
            // so we need at least 4 numbers.
            if (numbers.Count < 5) // Changed from 6 to 4
            {
                rich_hieuso3.Text = "0"; // More descriptive message
                rich_hieuso2.Text = "0";
                rich_hieuso1.Text = "0";
                rich_hieuso0.Text = "0";

                return;
            }
            int hieuso3 = numbers[4] - numbers[3];
            int hieuso2 = numbers[3] - numbers[2];
            //int hieuso1 = numbers[2] - numbers[1];
            //int hieuso0 = numbers[1] - numbers[0];

            rich_hieuso3.Text = hieuso3.ToString();
            rich_hieuso2.Text = hieuso2.ToString();
            //rich_hieuso1.Text = hieuso1.ToString();
            //rich_hieuso0.Text = hieuso0.ToString();


        }
        private void CalculateDifference(string cuoi)
        {
            string inputNumbers = richTxtHinhDang.Text.Trim();

            // Ensure there are numbers to process
            if (string.IsNullOrEmpty(inputNumbers))
            {
                rich_hieuso3.Text = "0"; // Or clear all difference fields if preferred
                return;
            }

            List<string> numbersAsString = inputNumbers.Split(',').ToList();
            List<int> numbers = new List<int>();

            // Convert string numbers to integers
            foreach (string numStr in numbersAsString)
            {
                if (int.TryParse(numStr.Trim(), out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    // Handle cases where conversion fails (e.g., non-numeric input)
                    rich_hieuso3.Text = "Invalid input"; // More descriptive error
                    return;
                }
            }

     
        }
        private int CountNumbersInRichTextBox()
        {
            // Lấy chuỗi từ RichTextBox
            string text = richTextBox1.Text;

            // Loại bỏ khoảng trắng thừa ở đầu và cuối chuỗi
            text = text.Trim();

            // Nếu chuỗi rỗng, trả về 0
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            // Tách chuỗi thành một mảng dựa trên dấu phẩy
            string[] numbersArray = text.Split(',');

            // Đếm số phần tử trong mảng
            int count = numbersArray.Length;

            return count;
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

                dv.RowFilter = $"GHEP1 LIKE '%{currentFilter}'";

                if (dv.Count >= 1)

                {

                    return currentFilter;

                }


                // Cắt bỏ ký tự đầu tiên

                currentFilter = currentFilter.Substring(2);

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

                gridView7.ActiveFilterString = $"[GHEP1] LIKE '%{lastFilterString}'";

            }



        }
        private async Task AddNumberToInputAsync(string newNumber)
        {
            string inputNumbers = richTxtHinhDang.Text.Trim();

            List<string> numbers = string.IsNullOrEmpty(inputNumbers)
                ? new List<string>()
                : inputNumbers.Split(',').ToList();

            if (numbers.Count >= 5)
            {

                numbers.RemoveAt(0);
            }

            // Thêm số mới vào danh sách
            numbers.Add(newNumber);
            richTxtHinhDang.Text = string.Join(",", numbers);
            CalculateDifference();
           
                if (checkEdit1.Checked==false)
                {
                
                    FilterGridCombined1(richTextBox1.Text,  rich_hieuso2.Text, rich_hieuso3.Text);
                //PerformOptimizedGridFiltering();
            }
            
        }

        private async void btn10_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn10.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn9_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn9.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async  void btn8_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn8.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn7_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn7.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn6_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn6.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn5_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn5.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn4_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn4.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn3_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
            string clickedNumber = btn3.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn11_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn11.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn12_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn12.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn13_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn13.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn14_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn14.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn15_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn15.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn16_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn16.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn17_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn17.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private async void btn18_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
            string clickedNumber = btn18.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }
        private void UpdateRichTextBoxNumberColors(RichTextBox rtb)
        {
            // Lưu lại vị trí con trỏ để không bị nhảy lung tung khi gõ
            int selectionStart = rtb.SelectionStart;
            int selectionLength = rtb.SelectionLength;

            // Tạm dừng việc vẽ lại giao diện để tránh nhấp nháy
            rtb.SuspendLayout();

            // Reset toàn bộ chữ về màu đen trước khi tô lại
            rtb.SelectAll();
            rtb.SelectionColor = System.Drawing.Color.Black;

            string[] parts = rtb.Text.Split(',');
            int currentPosition = 0;

            // Lặp qua từng phần được ngăn cách bởi dấu phẩy
            foreach (string part in parts)
            {
                // Thử chuyển phần đó thành số
                if (int.TryParse(part.Trim(), out int number))
                {
                    // Chọn đúng phần văn bản tương ứng
                    rtb.Select(currentPosition, part.Length);

                    // Tô màu dựa trên điều kiện
                    if (number > 10)
                    {
                        rtb.SelectionColor = System.Drawing.Color.Maroon; // Màu đỏ sẫm cho số > 10
                    }
                    else
                    {
                        rtb.SelectionColor = System.Drawing.Color.Blue;   // Màu xanh cho số <= 10
                    }
                }
                // Di chuyển vị trí đến sau phần vừa xử lý và dấu phẩy
                currentPosition += part.Length + 1;
            }

            // Khôi phục lại vị trí con trỏ
            rtb.SelectionStart = selectionStart;
            rtb.SelectionLength = selectionLength;
            rtb.Focus();

            // Cho phép vẽ lại giao diện
            rtb.ResumeLayout();
        }

        private void rich_hieuso_TextChanged(object sender, EventArgs e)
        {
            //string inputNumbers = richTxtHinhDang.Text.Trim();

            //List<string> numbers = string.IsNullOrEmpty(inputNumbers)
            //    ? new List<string>()
            //    : inputNumbers.Split(',').ToList();
            //if (numbers.Count >= 3)
            //{
            //    FilterGridCombined(richTextBox1.Text, rich_hieuso.Text, rich_hieuso1.Text);
            //}    
            
        }

        private void rich_hieuso5_TextChanged(object sender, EventArgs e)
        {
        }
        private void richTxtHinhDang_TextChanged(object sender, EventArgs e)
        {
            string sampleSequence = richTxtHinhDang.Text;
            UpdateRichTextBoxNumberColors(richTxtHinhDang);

            //string[] parts = sampleSequence.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //int numberCount = parts.Length;
            //if (numberCount >= 6)
            //{
            //    //this.filterComplexPattern = DeriveComplexPattern(sampleSequence);
            //    FilterGridCombined(richTextBox1.Text, rich_hieuso1.Text, rich_hieuso2.Text, rich_hieuso3.Text, rich_hieuso4.Text, rich_hieuso5.Text);

            //}
            //else
            //{
            //    this.filterComplexPattern = "";
            //}
            //gridView7.RefreshData();

        }
    }
    }
