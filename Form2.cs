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
using DocumentFormat.OpenXml.Office2010.CustomUI;


namespace KIEMSOAT_RAVAO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void get_dulieu()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    using (SqlCommand command = new SqlCommand("FindNextCharAfterSubstringInDATA", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SearchString", richTextBox1.Text);
                        command.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        da.SelectCommand = command;
                        da.Fill(ds);
                        gridControl1.DataSource = ds.Tables[0];
                        //CopyDataSource();

                    }
                }
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridControl1.DataSource = null;
            }


        }
        private void CountCharacters1()
        {
            // Lấy tổng số ký tự trong RichTextBox
            int characterCount = richTextBox1.Text.Length;
            labelControl2.Text = $"{characterCount}";

        }
        private void UpdateRTextBox(string stringToAdd)
        {
            // Lấy giá trị hiện tại của richTextBox1
            string currentText = richTextBox1.Text;
            // Thêm chuỗi mới vào cuối
            currentText += stringToAdd;

            // Cập nhật giá trị mới cho richTextBox1
            richTextBox1.Text = currentText;
            if (richTextBox1.Text.Length > 17)
            {
                // Cắt bớt chuỗi nếu vượt quá 8 ký tự
                richTextBox1.Text = richTextBox1.Text.Substring(1);
            }

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
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("T");
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            UpdateRTextBox("X");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = richTextBox1.SelectionStart;

            // Chuyển toàn bộ văn bản thành chữ hoa
            richTextBox1.Text = richTextBox1.Text.ToUpper();

            // Phục hồi vị trí con trỏ
            richTextBox1.SelectionStart = cursorPosition;
            UpdateRichTextBoxColors();
            CountCharacters1();

            if (richTextBox1.Text.Length >= 17)
            {
                get_dulieu();

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    
    }
