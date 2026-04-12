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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DocumentFormat.OpenXml.Wordprocessing;
using DevExpress.XtraPrinting.Native.Navigation;

namespace KIEMSOAT_RAVAO
{
    public partial class CHITIET_SOcs : Form
    {
        private string currentInput = string.Empty;
        private const int MAX_LENGTH = 3; // Giới hạn số ký tự cho một ô nhập (3-digit number)
        private string NormalizeString(string s)
        {
            // Kiểm tra phải là chuỗi số 3 ký tự
            if (string.IsNullOrEmpty(s) || s.Length != MAX_LENGTH_NUMERIC || !s.All(char.IsDigit)) return string.Empty;

            // Trả về chuỗi các chữ số đã được sắp xếp (ví dụ: "312" -> "123")
            return new string(s.OrderBy(c => c).ToArray());
        }
        private string AppendFilter(string currentFilter, string newFilter)
        {
            if (string.IsNullOrEmpty(newFilter)) return string.Empty;
            if (string.IsNullOrEmpty(currentFilter)) return newFilter;
            return " AND " + newFilter;
        }
        // Khai báo kết nối và DataTable gốc
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        private DataTable dtGoc = new DataTable();

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

        public CHITIET_SOcs()
        {
            InitializeComponent();
            AttachNumberButtonEvents();
            LoadGridData(); // Tải dữ liệu gốc khi form khởi tạo
            BalanceTableLayoutPanel(this.tableLayoutPanel2);
            BalanceTableLayoutPanel(this.tableLayoutPanel1);
            BalanceTableLayoutPanel(this.tableLayoutPanel3);
            this.chkAdvancedFilter.Checked = true;
            

        }
        private void FilterTimer_Tick(object sender, EventArgs e)
        {
           
            // Gọi ApplyFilter với các giá trị hiện tại
            //ApplyFilter(this.txtInput0.Text, this.txtInput1.Text, this.txtInput2.Text, this.txtInput3.Text);
        }
        // ========================= PHẦN HỖ TRỢ CHUẨN HÓA =========================


        private string cong(string digitString)
        {
            digitString = digitString.Trim();
            if (digitString.Length < 3)
            {
                return string.Empty;
            }

            int sum = 0;
            foreach (char c in digitString)
            {
                if (char.IsDigit(c))
                {
                    sum += (int)char.GetNumericValue(c);
                }
            }

            return sum > 10 ? "T" : "X";
        }
        private int CalculateSumOfDigits(string s)
        {
            if (s == null || s.Length != MAX_LENGTH_NUMERIC) return 0;
            if (s.All(char.IsDigit))
            {
                return s.Select(c => (int)char.GetNumericValue(c)).Sum();
            }
            return 0;
        }
        private void CalculateTXSequence()
        {
            // Lấy giá trị từ các ô nhập liệu (Đảm bảo các controls này tồn tại trong Designer)
            // Nếu bạn đang dùng DevExpress, hãy dùng .Text.Trim()
            string input1 = txtInput0.Text.Trim(); // Giả định control tồn tại
            string input2 = txtInput1.Text.Trim(); // Giả định control tồn tại
            string input3 = txtInput2.Text.Trim(); // Giả định control tồn tại

            // 1. Áp dụng logic T/X cho từng chuỗi
            // Hàm NormalizeString đã được định nghĩa ở phần trước
            string tx1 = cong(input1); // "123" -> X
            string tx2 = cong(input2); // "345" -> T
            string tx3 = cong(input3); // "321" -> X

            // 2. Ghép chuỗi lại
            string finalSequence = tx1 + tx2 + tx3;

            // 3. Gán kết quả vào txtInput4 (Giả định control tồn tại)
            txtInput4.Text = finalSequence;
        }
        private string NormalizeString1(string digitString)
        {
            // Loại bỏ khoảng trắng và kiểm tra độ dài tối thiểu
            digitString = digitString.Trim();
            if (digitString.Length < 3)
            {
                return string.Empty; // Trả về rỗng nếu không đủ dữ liệu
            }

            int sum = 0;
            foreach (char c in digitString)
            {
                if (char.IsDigit(c))
                {
                    sum += (int)char.GetNumericValue(c);
                }
            }

            // Logic chuyển đổi: T nếu Tổng > 10, X nếu Tổng <= 10
            return sum > 10 ? "T" : "X";
        }
        // ========================= PHẦN TẢI DỮ LIỆU BAN ĐẦU VÀ THÊM CỘT ẨN =========================
        private void LoadGridData()
        {
            if (this.gridControl5 == null)
            {
                MessageBox.Show("gridControl5 không tìm thấy.", "Lỗi Cấu hình", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Đảm bảo dtGoc và con (SqlConnection) đã được khai báo ở phạm vi class
            // Ví dụ: private DataTable dtGoc = new DataTable();
            //         private SqlConnection con = new SqlConnection(...);

            try
            {
                string spName = "[dbo].[Pivot_D_Data_new]"; // Tên Stored Procedure lấy dữ liệu xoay

                using (SqlCommand cmd = new SqlCommand(spName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    if (con.State == ConnectionState.Closed) con.Open();
                    dtGoc.Clear();
                    da.Fill(dtGoc); // 1. Điền dữ liệu vào DataTable gốc
                    con.Close();

                    // =================================================================
                    // 2. THÊM CÁC CỘT ẨN ĐÃ CHUẨN HÓA (Normalized Columns)
                    // =================================================================

                    // THÊM CỘT GHÉP CHUỖI MỚI: TTX_Sequence
                    if (!dtGoc.Columns.Contains("TTX_Sequence"))
                    {
                        dtGoc.Columns.Add("TTX_Sequence", typeof(string));
                    }

                    // Thêm Cot1_Normalized
                    if (dtGoc.Columns.Contains("Cot1") && !dtGoc.Columns.Contains("Cot1_Normalized"))
                    {
                        dtGoc.Columns.Add("Cot1_Normalized", typeof(string));
                    }

                    // Thêm Cot2_Normalized
                    if (dtGoc.Columns.Contains("Cot2") && !dtGoc.Columns.Contains("Cot2_Normalized"))
                    {
                        dtGoc.Columns.Add("Cot2_Normalized", typeof(string));
                    }
                    if (dtGoc.Columns.Contains("Cot3") && !dtGoc.Columns.Contains("Cot3_Normalized"))
                    {
                        dtGoc.Columns.Add("Cot3_Normalized", typeof(string));
                    }
                    // =================================================================
                    // 3. ĐIỀN DỮ LIỆU ĐÃ CHUẨN HÓA VÀO CÁC CỘT MỚI
                    // =================================================================
                    foreach (DataRow row in dtGoc.Rows)
                    {
                        string normalized1 = string.Empty;
                        string normalized2 = string.Empty;
                        string normalized3 = string.Empty;

                        // Xử lý Cot1
                        if (dtGoc.Columns.Contains("Cot1_Normalized"))
                        {
                            string originalCot1 = row["Cot1"] == DBNull.Value ? string.Empty : row["Cot1"].ToString();
                            normalized1 = NormalizeString1(originalCot1);
                            row["Cot1_Normalized"] = normalized1;
                        }

                        // Xử lý Cot2
                        if (dtGoc.Columns.Contains("Cot2_Normalized"))
                        {
                            string originalCot2 = row["Cot2"] == DBNull.Value ? string.Empty : row["Cot2"].ToString();
                            normalized2 = NormalizeString1(originalCot2);
                            row["Cot2_Normalized"] = normalized2;
                        }

                        // Xử lý Cot3
                        if (dtGoc.Columns.Contains("Cot3_Normalized"))
                        {
                            string originalCot3 = row["Cot3"] == DBNull.Value ? string.Empty : row["Cot3"].ToString();
                            normalized3 = NormalizeString1(originalCot3);
                            row["Cot3_Normalized"] = normalized3;
                        }

                        // =================================================================
                        // 4. TÍNH VÀ GHÉP CHUỖI TTX (Yêu cầu mới)
                        // =================================================================
                        if (dtGoc.Columns.Contains("TTX_Sequence"))
                        {
                            // Ghép các giá trị Normalized lại: Ví dụ: "X" + "T" + "T" = "XTT"
                            string sequence = normalized1 + normalized2 + normalized3;
                            row["TTX_Sequence"] = sequence;
                        }
                    }

                    this.gridControl5.DataSource = dtGoc;

                    // Bạn nên ẩn các cột Normalized (Cot1_Normalized, Cot2_Normalized, Cot3_Normalized)
                    // và chỉ hiển thị cột TTX_Sequence và các cột gốc Cot1, Cot2, Cot3
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu gốc: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
        private enum FilterMode { Prefix2Digit, BasicFull }
        // ========================= PHẦN LỌC DỮ LIỆU ĐỘNG VỚI TỰ ĐỘNG CHUYỂN ĐỔI =========================
        private const int MAX_LENGTH_NUMERIC = 3; // Giới hạn 3 số cho input
        private const int MAX_LENGTH_GOP7COT = 6; // Giới hạn 7 ký tự cho Gop7Cot (txtInput0)    private Timer filterTimer;  // Thêm tham số isSecondTry để tránh vòng lặp đệ quy vô hạn
                                                  // Sửa định nghĩa hàm: Bỏ filterCot3_Typing và isSecondTry
                                                  // Sửa định nghĩa hàm: Chỉ nhận 3 tham số
        private void AttachNumberButtonEvents()
        {
            this.btn1.Click += new System.EventHandler(this.NumberButton_Click);
            this.btn2.Click += new System.EventHandler(this.NumberButton_Click);
            this.btn3.Click += new System.EventHandler(this.NumberButton_Click);
            this.btn4.Click += new System.EventHandler(this.NumberButton_Click);
            this.btn5.Click += new System.EventHandler(this.NumberButton_Click);
            this.btn6.Click += new System.EventHandler(this.NumberButton_Click);

            this.simpleButton6.Click += new System.EventHandler(this.btnXoa_Click);
            this.simpleButton7.Click += new System.EventHandler(this.btnOK_Click);

        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton clickedButton = sender as DevExpress.XtraEditors.SimpleButton;
            if (clickedButton == null) return;

            string newDigit = clickedButton.Text;
            string nextInput = currentInput + newDigit;

            if (nextInput.Length <= MAX_LENGTH_NUMERIC)
            {
                // 1. Cập nhật txtInput3 (đang nhập)
                currentInput = nextInput;
                this.txtInput3.Text = currentInput;

                // 2. Nếu đã đủ 3 số, thực hiện Trượt và Cập nhật TXTINPUT0
                if (nextInput.Length == MAX_LENGTH_NUMERIC)
                {
                    txtInput0.Text = this.txtInput1.Text;
                    string oldInput1 = this.txtInput1.Text;
                    this.txtInput1.Text = this.txtInput2.Text;
                    this.txtInput2.Text = nextInput;
                    currentInput = string.Empty;
                    this.txtInput3.Text = string.Empty;
                    //ApplyFilter();

                }
            }
        }


      

        // ========================= PHẦN NÚT HÀNH ĐỘNG VÀ MÀU SẮC =========================

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa toàn bộ 3 ô chính
            this.txtInput0.Text = string.Empty;
            this.txtInput1.Text = string.Empty;
            this.txtInput2.Text = string.Empty;

            // Xóa bộ lọc
            var gridView = this.gridControl5.MainView as GridView;
            if (gridView != null)
            {
                gridView.ClearColumnsFilter();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
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

        private void GridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;

            if (e.Column.FieldName == "Cot1" || e.Column.FieldName == "Cot2"||  e.Column.FieldName == "Cot23")
            {
                object cellObj = view.GetRowCellValue(e.RowHandle, e.Column);
                string cellValue = cellObj == null || cellObj == DBNull.Value ? string.Empty : cellObj.ToString();

                int sum = CalculateSumOfDigits(cellValue);

                if (e.Column.FieldName == "Cot4")
                {
                    int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "Cot4"));
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
                else
                {
                    if (sum > 10)
                    {
                        e.Appearance.BackColor = System.Drawing.Color.Maroon;
                        e.Appearance.ForeColor = System.Drawing.Color.White;
                    }
                    else if (sum <= 10 && sum > 0)
                    {
                        e.Appearance.BackColor = System.Drawing.Color.Green;
                        e.Appearance.ForeColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        e.Appearance.BackColor = e.Column.AppearanceCell.BackColor;
                        e.Appearance.ForeColor = e.Column.AppearanceCell.ForeColor;
                    }
                }
            }
        }
        private string relaxedGop7Filter = string.Empty;
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
                    //MessageBox.Show("Chạy TABLE GOM THÀNH CÔNG!");
                }
            }
        }
        private void InsertIntoDatabase(string connectionString, string valueB, string valueC)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Chèn dữ liệu vào cột DATA
                string query = "INSERT INTO INF (DATA,CHUOI) VALUES (@ValueB,@ValueC)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ValueB", valueB);
                    command.Parameters.AddWithValue("@ValueC", valueC);
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
                    string valueC = row.Cell(1).GetValue<string>(); // Cell(1) là cột C


                    // Chèn dữ liệu vào SQL Server
                    InsertIntoDatabase(connectionString, valueB, valueC);
                }
            }

            // Thực thi stored procedure sau khi chèn dữ liệu
            ExecuteStoredProcedure(connectionString);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ImportExcelToSQL();
                //MessageBox.Show("Dữ liệu đã được chèn thành công từ Sheet2, cột B!");
                INS_GOM();
                LoadGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void CHITIET_SOcs_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Áp dụng bộ lọc cho DataTable gốc dựa trên các giá trị nhập vào.
        /// Sử dụng DataView để lọc và hiển thị kết quả trên gridControl5.
        /// </summary>
        //private void ApplyFilter()
        //{
        //    string filterCot1Input = this.txtInput0.Text.Trim();
        //    string filterCot2Input = this.txtInput1.Text.Trim();
        //    string filterCot3Input = this.txtInput2.Text.Trim();

        //    // 1. Kiểm tra không có input nào
        //    if (string.IsNullOrEmpty(filterCot1Input) && string.IsNullOrEmpty(filterCot2Input) && string.IsNullOrEmpty(filterCot3Input))
        //    {
        //        this.gridControl5.DataSource = dtGoc;
        //        return;
        //    }

        //    string filterExpression = "";

        //    // Khai báo các biến chế độ lọc mới
        //    bool mode1 = this.checkbox1.Checked; // Cot1 Hoán vị, Cot2/3 Chính xác
        //    bool mode2 = this.checkbox2.Checked; // Cot1/2 Hoán vị, Cot3 Chính xác
        //    bool mode3 = this.checkbox3.Checked; // Cot1/2/3 Chính xác
        //    bool mode4 = this.checkbox4.Checked; // MỚI: Cot1/2/3 Hoán vị
        //    bool mode5 = this.checkbox5.Checked; // MỚI: Bỏ Cot1, Cot2/3 Chính xác

        //    // Mặc định nếu không có checkbox nào được chọn là Chế độ 3 (Chính xác)
        //    if (!mode1 && !mode2 && !mode3 && !mode4 && !mode5)
        //    {
        //        mode3 = true;
        //    }

        //    try
        //    {
        //        // === Chế độ 4: Lọc Hoán vị Toàn bộ (Cot1, Cot2, Cot3) ===
        //        if (mode4)
        //        {
        //            // Cot1, Cot2, Cot3 đều lọc Hoán vị
        //            filterExpression = BuildNormalizedFilter("Cot1_Normalized", filterCot1Input);
        //            filterExpression += AppendFilter(filterExpression, BuildNormalizedFilter("Cot2_Normalized", filterCot2Input));
        //            filterExpression += AppendFilter(filterExpression, BuildNormalizedFilter("Cot3_Normalized", filterCot3Input));
        //        }
        //        // === Chế độ 5: Lọc Chính xác Tối thiểu (Bỏ Cot1) ===
        //        else if (mode5)
        //        {
        //            // Cot1 không lọc, Cot2/3 Chính xác
        //            // Bắt đầu từ Cot2, không cần kiểm tra Cot1
        //            filterExpression = BuildExactFilter("Cot2", filterCot2Input);
        //            filterExpression += AppendFilter(filterExpression, BuildExactFilter("Cot3", filterCot3Input));

        //            // Lưu ý: Nếu chỉ nhập txtInput0 mà mode5 đang bật, sẽ không có lọc nào được áp dụng.
        //        }
        //        // === Các chế độ cũ (1, 2, 3) ===
        //        else if (mode3) // Chế độ 3: Cot1/2/3 Chính xác
        //        {
        //            filterExpression = BuildExactFilter("Cot1", filterCot1Input);
        //            filterExpression += AppendFilter(filterExpression, BuildExactFilter("Cot2", filterCot2Input));
        //            filterExpression += AppendFilter(filterExpression, BuildExactFilter("Cot3", filterCot3Input));
        //        }
        //        else if (mode1) // Chế độ 1: Cot1 Hoán vị, Cot2/3 Chính xác
        //        {
        //            filterExpression = BuildNormalizedFilter("Cot1_Normalized", filterCot1Input);
        //            filterExpression += AppendFilter(filterExpression, BuildExactFilter("Cot2", filterCot2Input));
        //            filterExpression += AppendFilter(filterExpression, BuildExactFilter("Cot3", filterCot3Input));
        //        }
        //        else if (mode2) // Chế độ 2: Cot1/2 Hoán vị, Cot3 Chính xác
        //        {
        //            filterExpression = BuildNormalizedFilter("Cot1_Normalized", filterCot1Input);
        //            filterExpression += AppendFilter(filterExpression, BuildNormalizedFilter("Cot2_Normalized", filterCot2Input));
        //            filterExpression += AppendFilter(filterExpression, BuildExactFilter("Cot3", filterCot3Input));
        //        }


        //        // Nếu filterExpression trống, hiển thị lại dữ liệu gốc
        //        if (string.IsNullOrEmpty(filterExpression))
        //        {
        //            this.gridControl5.DataSource = dtGoc;
        //            return;
        //        }

        //        // Áp dụng bộ lọc lên DataView
        //        DataView dv = new DataView(dtGoc);
        //        dv.RowFilter = filterExpression;

        //        this.gridControl5.DataSource = dv;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi áp dụng bộ lọc: " + ex.Message, "Lỗi Lọc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        this.gridControl5.DataSource = dtGoc;
        //    }
        //}
        private void simpleButton6_Click(object sender, EventArgs e)


        {    // Xóa toàn bộ 3 ô chính
            this.txtInput0.Text = string.Empty;
            this.txtInput1.Text = string.Empty;
            this.txtInput2.Text = string.Empty;
            this.txtInput3.Text = string.Empty; // Thêm xóa txtInput3
            this.currentInput = string.Empty; // Reset input

            // Xóa bộ lọc trên GridView (Đây là cách DevExpress xóa bộ lọc)
            var gridView = this.gridControl5.MainView as GridView;
            if (gridView != null)
            {
                gridView.ClearColumnsFilter();
            }

            // Gán lại nguồn dữ liệu gốc để đảm bảo tất cả bộ lọc biến mất
            this.gridControl5.DataSource = dtGoc;
        
        }

        private void gridView5_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.Column.FieldName == "Cot4")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "Cot4"));
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

        private void gridView5_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == "Cot1"|| e.Column.FieldName == "Cot2"||e.Column.FieldName == "Cot3")
            //{
            //    string ketQuaValue = e.CellValue as string;

            //    if (!string.IsNullOrEmpty(ketQuaValue))
            //    {
            //        e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            //        // Lấy 5 ký tự cuối cùng của chuỗi
            //        string displayedValue = ketQuaValue;
            //        if (ketQuaValue.Length > 10)
            //        {
            //            displayedValue = ketQuaValue.Substring(ketQuaValue.Length - 5);
            //        }

            //        float currentX = e.Bounds.X;
            //        float charWidth;

            //        Font boldFont = new Font(e.Appearance.Font, FontStyle.Bold);

            //        // Chia chuỗi hiển thị thành các ký tự
            //        char[] chars = displayedValue.ToCharArray();

            //        foreach (char character in chars)
            //        {
            //            string charString = character.ToString();

            //            // Xác định màu dựa trên logic "X" và "T"
            //            Color charColor;
            //            if (charString == "X") // Giả sử "X" là ký tự
            //            {
            //                charColor = Color.Blue; // Màu xanh lam cho X
            //            }
            //            else if (charString == "T") // Giả sử "T" là ký tự
            //            {
            //                charColor = Color.Maroon; // Màu đỏ sẫm cho T
            //            }
            //            else
            //            {
            //                charColor = e.Appearance.ForeColor; // Giữ màu mặc định cho các ký tự khác
            //            }

            //            using (SolidBrush brush = new SolidBrush(charColor))
            //            {
            //                SizeF charSize = e.Graphics.MeasureString(charString, boldFont);

            //                // Vẽ ký tự
            //                e.Graphics.DrawString(charString, boldFont, brush,
            //                    new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - charSize.Height) / 2));

            //                charWidth = charSize.Width;
            //                currentX += charWidth; // Cập nhật vị trí X cho ký tự tiếp theo
            //            }
            //        }

            //        boldFont.Dispose();
            //        e.Handled = true;
            //    }
            //}
        }
        private string BuildExactFilter(string columnName, string inputValue)
        {
            if (string.IsNullOrEmpty(inputValue)) return string.Empty;
            // Sử dụng LIKE '%{value}%' để tìm kiếm chuỗi con trong cột
            return string.Format("{0} LIKE '%{1}%'", columnName, inputValue.Replace("'", "''"));
        }

        // Helper function để xây dựng biểu thức lọc hoán vị (so sánh chính xác trên cột Normalized)
        private string BuildNormalizedFilter(string normalizedColumnName, string inputValue)
        {
            // Chỉ áp dụng Hoán vị cho input 3 chữ số hợp lệ
            if (string.IsNullOrEmpty(inputValue) || inputValue.Length != MAX_LENGTH_NUMERIC || !inputValue.All(char.IsDigit)) return string.Empty;

            // Chuẩn hóa input người dùng
            string normalizedInput = NormalizeString(inputValue);

            // Lọc chính xác trên cột đã chuẩn hóa
            return string.Format("{0} = '{1}'", normalizedColumnName, normalizedInput.Replace("'", "''"));
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            // Chế độ 1: Cot1 Hoán vị
            // Kiểm tra xem checkbox1 có đang được chọn (Check = true) không
            if (this.checkbox1.Checked)
            {
                // Nếu đang chọn checkbox1, hãy tắt các checkbox khác
                this.checkbox2.Checked = false;
                this.checkbox3.Checked = false;
            }

            // Gọi hàm lọc để áp dụng bộ lọc mới
            //ApplyFilter();
        }

        private void checkbox2_CheckedChanged(object sender, EventArgs e)
        {
            // Chế độ 2: Cot1 & Cot2 Hoán vị
            if (this.checkbox2.Checked)
            {
                // Nếu đang chọn checkbox2, hãy tắt các checkbox khác
                this.checkbox1.Checked = false;
                this.checkbox3.Checked = false;
            }

            // Gọi hàm lọc để áp dụng bộ lọc mới
            //ApplyFilter();
        }

        private void checkbox3_CheckedChanged(object sender, EventArgs e)
        {
            // Chế độ 3: Lọc Chính xác
            if (this.checkbox3.Checked)
            {
                // Nếu đang chọn checkbox3, hãy tắt các checkbox khác
                this.checkbox1.Checked = false;
                this.checkbox2.Checked = false;
            }

            // Gọi hàm lọc để áp dụng bộ lọc mới
            //ApplyFilter();
        }

        private void checkbox4_CheckedChanged(object sender, EventArgs e)
        {
            // Chế độ 4: Hoán vị Cot1/2/3
            if (this.checkbox4.Checked)
            {
                // Tắt tất cả các chế độ khác
                this.checkbox1.Checked = false;
                this.checkbox2.Checked = false;
                this.checkbox3.Checked = false;
                this.checkbox5.Checked = false;
            }
            ///*ApplyFilter*/();
        }

        private void checkbox5_CheckedChanged(object sender, EventArgs e)
        {
            // Chế độ 5: Bỏ Cot1, Cot2/3 Chính xác
            if (this.checkbox5.Checked)
            {
                // Tắt tất cả các chế độ khác
                this.checkbox1.Checked = false;
                this.checkbox2.Checked = false;
                this.checkbox3.Checked = false;
                this.checkbox4.Checked = false;
            }
            //ApplyFilter();
        }
        private void FilterGridCombined(string Cot1, string Cot2, string Cot3, string TTX_Sequence)
        {
            if (gridView5 != null)
            {
                List<string> filterParts = new List<string>();

                // --- Xử lý Cot1 ---
                if (!string.IsNullOrEmpty(Cot1) && Cot1.Length >= 2)
                {
                    // Lấy 2 ký tự đầu và tạo chuỗi lọc
                    string filterValue = Cot1.Substring(0, 2);
                    filterParts.Add($"[Cot1] LIKE '{filterValue}%'");
                }
                else if (!string.IsNullOrEmpty(Cot1) && Cot1.Length == 1)
                {
                    // Xử lý trường hợp chỉ có 1 ký tự (có thể lọc theo 1 ký tự)
                    filterParts.Add($"[Cot1] LIKE '{Cot1}%'");
                }

                // --- Xử lý Cot2 ---
                if (!string.IsNullOrEmpty(Cot2) && Cot2.Length >= 2)
                {
                    // Lấy 2 ký tự đầu và tạo chuỗi lọc
                    string filterValue = Cot2.Substring(0, 2);
                    filterParts.Add($"[Cot2] LIKE '{filterValue}%'");
                }
                else if (!string.IsNullOrEmpty(Cot2) && Cot2.Length == 1)
                {
                    // Xử lý trường hợp chỉ có 1 ký tự
                    filterParts.Add($"[Cot2] LIKE '{Cot2}%'");
                }

                // --- Xử lý Cot3 ---
                if (!string.IsNullOrEmpty(Cot3) && Cot3.Length >= 3)
                {
                    // Lấy 2 ký tự đầu và tạo chuỗi lọc
                    string filterValue = Cot3.Substring(0, 2);
                    filterParts.Add($"[Cot3] like '{filterValue}%'");
                }
                //else if (!string.IsNullOrEmpty(Cot3) && Cot3.Length == 1)
                //{
                //    Xử lý trường hợp chỉ có 1 ký tự
                //    filterParts.Add($"[Cot3] LIKE '{Cot3}%'");
                //}
                if (!string.IsNullOrEmpty(TTX_Sequence))
                {
                    filterParts.Add($"[TTX_Sequence] = '{TTX_Sequence}'");
                }

                // Áp dụng chuỗi lọc (sử dụng toán tử AND giữa các bộ lọc)
                gridView5.ActiveFilterString = string.Join(" AND ", filterParts);
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CalculateTXSequence();
            FilterGridCombined(txtInput0.Text,txtInput1.Text,txtInput2.Text,txtInput4.Text);
        }

        private void txtInput0_TextChanged(object sender, EventArgs e)
        {
            if(txtInput3.Text.Length==3)
            {
                CalculateTXSequence();
                //FilterGridCombined(txtInput0.Text, txtInput1.Text, txtInput2.Text, txtInput4.Text);

            }
        }
    }

}