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
namespace KIEMSOAT_RAVAO
{
    public partial class DAYSO : Form
    {
        public DAYSO()
        {
            InitializeComponent();
            this.gridView5.RowHeight = 30;
            BalanceTableLayoutPanel(this.tableLayoutPanel1);
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            ConvertInputToOutput();
            btnCopyLastTwoNumbers();
            string numbersString = txtInput.Text;
            string[] numbersArray = numbersString.Split(','); // Tách chuỗi thành mảng các chuỗi con dựa trên dấu phẩy
            int count = numbersArray.Length; // Đếm số lượng phần tử trong mảng
            if (count == 5)
            {
                get_dulieu();
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

        
        private void FilterGrid5(string searchText)
        {

            
        }
        private void get_dulieu()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    using (SqlCommand command = new SqlCommand("TimKiemVaPhanTichDaySo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DaySo", txtInput.Text);

                        SqlDataAdapter da = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        da.SelectCommand = command;
                        da.Fill(ds); // Dữ liệu được đổ vào DataSet ở đây

                        // --- Bắt đầu phần kiểm tra và xử lý lỗi null ---
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                        {
                            // Nếu có dữ liệu, gán cho DataSource
                            gridControl5.DataSource = ds.Tables[0];
                        
                        }
                        else
                        {
                            // Nếu không có dữ liệu, thiết lập DataSource thành null
                            // Điều này sẽ làm sạch GridControl và tránh lỗi
                            gridControl5.DataSource = null;
                         
                            // Tùy chọn: hiển thị thông báo cho người dùng rằng không có dữ liệu
                            // XtraMessageBox.Show("Không tìm thấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        // --- Kết thúc phần kiểm tra và xử lý lỗi null ---
                    }
                }
            }
            catch (Exception ex)
            {
                // Gỡ bỏ comment dòng dưới đây để hiển thị lỗi nếu bạn muốn xem chi tiết
                // XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Đảm bảo GridControl sạch sẽ ngay cả khi có lỗi kết nối/truy vấn
                gridControl5.DataSource = null;
            }

            // Các hàm này được gọi sau khi lấy dữ liệu, giữ nguyên
            FilterGridCombined1(txtinput6.Text,txtInput.Text);
            //FilterGrid5(txtinput6.Text);
        }
        #region CLICK
        private async void btn10_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn10.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn9_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn9.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn8_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn8.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn7_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn7.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn6_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn6.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn5_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn5.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn4_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn4.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn3_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn3.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn11_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn11.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn12_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn12.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn13_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn13.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn14_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn14.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn15_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn15.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn16_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn16.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn17_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn17.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private async void btn18_Click(object sender, EventArgs e)
        {
            string clickedNumber = btn18.Text; // Lấy số từ nút được click
            await AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput

        }

        private void gridView5_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "NextColumnValue")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "NextColumnValue"));
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
            if (e.Column.FieldName == "NextColumnValue2")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "NextColumnValue2"));
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
        #endregion CLICK
        private void txtinput6_TextChanged(object sender, EventArgs e)
        {
            UpdateRichTextBoxColors4();
        }
            private void UpdateRichTextBoxColors4()
        {
            // Lấy chuỗi hiện tại trong RichTextBox
            string text = txtinput6.Text;

            // Lưu trữ vị trí con trỏ
            int currentSelectionStart = txtinput6.SelectionStart;
            int currentSelectionLength = txtinput6.SelectionLength;

            // Tắt cập nhật giao diện để tránh nhấp nháy
            txtinput6.SuspendLayout();

            // Xóa định dạng cũ
            txtinput6.SelectAll();
            txtinput6.SelectionColor = System.Drawing.Color.Black;

            // Lặp qua từng ký tự và thay đổi màu
            for (int i = 0; i < text.Length; i++)
            {
                txtinput6.Select(i, 1); // Chọn từng ký tự

                if (text[i] == 'T')
                {
                    txtinput6.SelectionColor = System.Drawing.Color.Maroon; // Màu cho ký tự T
                }
                else if (text[i] == 'X')
                {
                    txtinput6.SelectionColor = System.Drawing.Color.Blue; // Màu cho ký tự X
                }
            }

            // Phục hồi vị trí con trỏ
            txtinput6.SelectionStart = currentSelectionStart;
            txtinput6.SelectionLength = currentSelectionLength;

            // Bật lại cập nhật giao diện
            txtinput6.ResumeLayout();
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "NextColumnValue")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "NextColumnValue"));
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
            
            if (e.Column.FieldName == "NextColumnValue2")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "NextColumnValue2"));
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

        private void FilterGridCombined1(string searchCUOI, string searchGHEP)
        {
            if (gridView5 != null)
            {
                List<string> filterParts = new List<string>();

                if (!string.IsNullOrEmpty(searchCUOI))
                {
                    filterParts.Add($"[ConvertedValues] LIKE '%{searchCUOI}'");
                }
                if (!string.IsNullOrEmpty(searchGHEP))
                {
                    filterParts.Add($"[CombinedValues] LIKE '%{searchGHEP}'");
                }
               

                gridView5.ActiveFilterString = string.Join(" AND ", filterParts); 
            }
        }
        private void FilterGridCombined_apchot(string searchCUOI, string searchGHEP)
        {

            if (gridView5 != null)
            {
                List<string> filterParts = new List<string>();
                if (!string.IsNullOrEmpty(searchCUOI))
                {
                    filterParts.Add($"[ConvertedValues] LIKE '%{searchCUOI}'");
                }

                if (!string.IsNullOrEmpty(searchGHEP))
                {
                    filterParts.Add($"[CombinedValues] LIKE '%{searchGHEP}'");
                }
               

                gridView5.ActiveFilterString = string.Join(" AND ", filterParts);
            }
        }
        private void btnCopyLastTwoNumbers()
        {
            // Lấy chuỗi từ textbox nguồn
            string sourceText = txtInput.Text;

            // Kiểm tra xem chuỗi có rỗng không
            if (string.IsNullOrEmpty(sourceText))
            {
                txt2socuoi.Text = "Không có dữ liệu trong textbox nguồn.";
                return;
            }

            // Tách chuỗi thành một mảng các số dựa trên dấu phẩy
            string[] numbers = sourceText.Split(',');

            // Kiểm tra xem có đủ ít nhất 2 số không
            if (numbers.Length >= 2)
            {
                // Lấy hai số cuối cùng
                string lastNumber0 = numbers[numbers.Length - 3].Trim(); // Số áp chót
                string lastNumber1 = numbers[numbers.Length - 2].Trim(); // Số áp chót
                string lastNumber2 = numbers[numbers.Length - 1].Trim(); // Số cuối cùng

                // Kết hợp chúng lại thành một chuỗi mới
                //string result = $"{lastNumber1},{lastNumber2}";
                string result = $"{lastNumber0},{lastNumber1},{lastNumber2}";
                // Dán chuỗi kết quả vào textbox đích
                txt2socuoi.Text = result;
            }
            else
            {
                // Xử lý trường hợp không có đủ 2 số
                txt2socuoi.Text = "Chuỗi không có đủ 2 số cuối.";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //NextColumnValue
        }

        private void gridView2_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "NextColumnValue")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "NextColumnValue"));
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
            if (e.Column.FieldName == "NextColumnValue2")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "NextColumnValue2"));
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

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
            txtinput6.Text= string.Empty;   
            txt2socuoi.Text= string.Empty;
        }

        private void gridView5_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == "CombinedValues")
            //{
            //    string cellValue = e.CellValue as string;
            //    if (string.IsNullOrEmpty(cellValue))
            //    {
            //        return;
            //    }

            //    List<int> numbers = new List<int>();
            //    string[] parts = cellValue.Split(',');
            //    foreach (string part in parts)
            //    {
            //        if (int.TryParse(part.Trim(), out int num))
            //        {
            //            numbers.Add(num);
            //        }
            //    }

            //    if (numbers.Count == 0) // Chỉ cần 1 điểm cũng vẽ được (nhưng không có đường kẻ)
            //    {
            //        return;
            //    }

            //    int minDataValue = numbers.Min();
            //    int maxDataValue = numbers.Max();
            //    int dataRange = maxDataValue - minDataValue;

            //    const int PADDING = 5;

            //    RectangleF drawingBounds = new RectangleF(
            //        e.Bounds.X + PADDING,
            //        e.Bounds.Y + PADDING,
            //        e.Bounds.Width - 2 * PADDING,
            //        e.Bounds.Height - 2 * PADDING
            //    );

            //    List<PointF> points = new List<PointF>();
            //    float xStep = (numbers.Count > 1) ? drawingBounds.Width / (numbers.Count - 1) : 0;

            //    for (int i = 0; i < numbers.Count; i++)
            //    {
            //        // Nếu chỉ có 1 điểm, vẽ ở giữa. Nếu nhiều hơn, tính theo bước.
            //        float x = (numbers.Count > 1) ? (drawingBounds.X + (i * xStep)) : (drawingBounds.X + drawingBounds.Width / 2);
            //        float y;

            //        if (dataRange == 0)
            //        {
            //            y = drawingBounds.Y + drawingBounds.Height / 2;
            //        }
            //        else
            //        {
            //            float normalizedY = (float)(numbers[i] - minDataValue) / dataRange;
            //            y = drawingBounds.Bottom - (normalizedY * drawingBounds.Height);
            //        }

            //        points.Add(new PointF(x, y));
            //    }

            //    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //    // Chỉ vẽ đường kẻ nếu có từ 2 điểm trở lên
            //    if (points.Count >= 2)
            //    {
            //        // Vẽ đường viền (lót nền)
            //        using (Pen casingPen = new Pen(Color.FromArgb(100, Color.Black), 5))
            //        {
            //            casingPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            //            e.Graphics.DrawLines(casingPen, points.ToArray());
            //        }

            //        // Vẽ đường kẻ chính
            //        using (Pen linePen = new Pen(Color.White, 3))
            //        {
            //            linePen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            //            e.Graphics.DrawLines(linePen, points.ToArray());
            //        }
            //    }

            //    // ==========================================================
            //    // KHỐI VẼ ĐIỂM NÚT VÀ SỐ (ĐÃ XÓA IF)
            //    // ==========================================================
            //    using (SolidBrush pointBrush = new SolidBrush(Color.Crimson))
            //    using (SolidBrush textBrush = new SolidBrush(Color.Maroon))
            //    using (Font textFont = new Font("Segoe UI", 10, FontStyle.Bold))
            //    {
            //        for (int i = 0; i < points.Count; i++)
            //        {
            //            // 1. Vẽ tất cả các điểm nút
            //            RectangleF pointRect = new RectangleF(points[i].X - 3, points[i].Y - 3, 6, 6);
            //            e.Graphics.FillEllipse(pointBrush, pointRect);

            //            // 2. Vẽ chữ tại TẤT CẢ các điểm
            //            string numberText = numbers[i].ToString();
            //            SizeF textSize = e.Graphics.MeasureString(numberText, textFont);

            //            // Vẽ nền mờ cho chữ để dễ đọc
            //            RectangleF textBgRect = new RectangleF(points[i].X - textSize.Width / 2 - 2, points[i].Y - textSize.Height - 7, textSize.Width + 4, textSize.Height + 2);
            //            using (SolidBrush textBgBrush = new SolidBrush(Color.FromArgb(150, Color.White)))
            //            {
            //                e.Graphics.FillRectangle(textBgBrush, textBgRect);
            //            }
            //            // Vẽ chữ
            //            e.Graphics.DrawString(numberText, textFont, textBrush, points[i].X - textSize.Width / 2, points[i].Y - textSize.Height - 6);
            //        }
            //    }

            //    e.Handled = true;
            //}
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
        private void DAYSO_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FilterGridCombined_apchot(txtinput6.Text, txt2socuoi.Text);

        }
    }
  }
