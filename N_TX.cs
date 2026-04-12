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
using System.Windows.Forms.DataVisualization.Charting;
using DevExpress.DataAccess.Excel;
using System.Data.OleDb;
using DevExpress.Spreadsheet;

using DevExpress.ClipboardSource.SpreadsheetML;
using System.Drawing.Drawing2D;
using DevExpress.XtraGrid.Columns;
using System.IO;
using DevExpress.XtraEditors;
using ClosedXML.Excel;
using OfficeOpenXml;
using DevExpress.XtraPrinting;

namespace KIEMSOAT_RAVAO
{
    public partial class N_TX : Form
    {
        public N_TX()
        {
            InitializeComponent();

        }
        private List<InputData> data;
        private string dataFilePath = @"G:\PHAN MEM LAN\KBYT\KBYT\KIEMSOAT_RAVAO_20240727\KIEMSOAT_RAVAO_20230213\KIEMSOAT_RAVAO_3SO\bin\Debug\data\data.xlsx";
        public class InputData
        {
            public string SOHT { get; set; }
            public string SS1 { get; set; }
            public string SS2 { get; set; }
            public string SS3 { get; set; }
            public string SS4 { get; set; }
            public string SS5 { get; set; }
            public string SS6 { get; set; }
            public string SS7 { get; set; }
            public string SS8 { get; set; }
            public string SS9 { get; set; }
            public string SS10 { get; set; }
            public string SS11 { get; set; }
            public string SS12 { get; set; }
            public string SS13 { get; set; }
            public string SS14 { get; set; }
            public string SS15 { get; set; }
            public string SS16 { get; set; }
            public int SS17 { get; set; }
            public int SS18 { get; set; }
            public int SS19 { get; set; }
            public int SS20 { get; set; }

        }

        private void LoadData()
        {
            if (File.Exists(dataFilePath))
            {
                using (var workbook = new XLWorkbook(dataFilePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RowsUsed().Skip(1); // Bỏ qua tiêu đề cột
                    data = new List<InputData>();

                    foreach (var row in rows)
                    {
                        var record = new InputData
                        {
                            SOHT = row.Cell(1).GetValue<string>(),
                            SS1 = row.Cell(2).GetValue<string>(),
                            SS2 = row.Cell(3).GetValue<string>(),
                            SS3 = row.Cell(4).GetValue<string>(),
                            SS4 = row.Cell(5).GetValue<string>(),
                            SS5 = row.Cell(6).GetValue<string>(),
                            SS6 = row.Cell(7).GetValue<string>(),
                            SS7 = row.Cell(8).GetValue<string>(),
                            SS8 = row.Cell(9).GetValue<string>(),
                            SS9 = row.Cell(10).GetValue<string>(),
                            SS10 = row.Cell(11).GetValue<string>(),
                            SS11 = row.Cell(12).GetValue<string>(),
                            SS12 = row.Cell(13).GetValue<string>(),
                            SS13 = row.Cell(14).GetValue<string>(),
                            SS14 = row.Cell(15).GetValue<string>(),
                            SS15 = row.Cell(16).GetValue<string>(),
                            SS16 = row.Cell(17).GetValue<string>(),
                            SS17 = row.Cell(18).GetValue<int>(),
                            SS18 = row.Cell(19).GetValue<int>(),
                            SS19 = row.Cell(20).GetValue<int>(),
                            SS20 = row.Cell(21).GetValue<int>(),


                        };
                        data.Add(record);
                    }
                }
            }
            else
            {
                data = new List<InputData>();
            }
        }

        private void get_sid()
        {

            try
            {

                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = cn;
                command.CommandTimeout = 0;
                command.CommandText = "get_lieniep9";
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.Add(new SqlParameter("@G", SqlDbType.NVarChar)).Value = comboBox1.Text;
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = command;
                da.Fill(ds);
                //gridControl1.DataSource = ds.Tables[0];
                //gridControl2.DataSource = ds.Tables[0];
                gridControl3.DataSource = ds.Tables[0];
                gridControl4.DataSource = ds.Tables[0];
                gridControl5.DataSource = ds.Tables[0];
                gridControl6.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //}    
        }

        private void N_TX_Load(object sender, EventArgs e)
        {
            
            this.THT1.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
            this.T19.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
            this.T18.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
            this.T17.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
            this.T16.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
            this.T15.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
            this.T14.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
            this.T13.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
            this.T12.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
            this.T11.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
            // Tiếp tục cho các TextBox khác

            //var source = new ExcelDataSource();
            //source.FileName = @"G:\PHAN MEM LAN\KBYT\KBYT\KIEMSOAT_RAVAO_20240727\KIEMSOAT_RAVAO_20230213\KIEMSOAT_RAVAO_3SO\bin\Debug\data\data.xlsx";
            //var worksheetSettings = new ExcelWorksheetSettings("Sheet", "A1:U170000");
            //source.SourceOptions = new ExcelSourceOptions(worksheetSettings);
            //source.Fill();
            ////gridControl3.DataSource = source;
            //open();
            get_sid();
            THT.Focus();
            T0.Text = "";
            T1.Text = "";
            T2.Text = "";
            T3.Text = "";
            T4.Text = "";
            T5.Text = "";
            T6.Text = "";
            T7.Text = "";
            T8.Text = "";
            T9.Text = "";
            T10.Text = "";
            T11.Text = "";
            T12.Text = "";
            T13.Text = "";
            T14.Text = "";
            T15.Text = "";
            T16.Text = "";
            T17.Text = "";
            T18.Text = "";
            T19.Text = "";

        }
        #region GET LOC
        private string CreateContainsFilter_SS0(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SOHT] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS1(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS1] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS2(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS2] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS3(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS3] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS4(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS4] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS5(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS5] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS6(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS6] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS7(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS7] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS8(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS8] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS9(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS9] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS10(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS10] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS11(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS11] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS12(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS12] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS13(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS13] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS14(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS14] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS15(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS15] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS151(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS151] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS16(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS16] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS161(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS161] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS17(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS17] = '{filterText_TR}'";
            return filter_T;
        }

        private string CreateContainsFilter_SS18(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS18] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_SS19(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = $"[SS19] = '{filterText_TR}'";
            return filter_T;
        }
        private string CreateContainsFilter_T191(string filterText_TR)
        {
            char[] characters = filterText_TR.ToCharArray();
            string filter_T = string.Join(" AND ", characters.Select(c => $"[SS191] LIKE '%{c}%'"));
            return filter_T;
        }
        #endregion

        #region LOC

        private void get_loc_18_1()
        {
            gridView3.ActiveFilter.Clear();

            string A0 = T0.Text;
            if (!string.IsNullOrEmpty(A0))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SOHT"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS0(A0)));
            }
            string A1 = T1.Text;
            if (!string.IsNullOrEmpty(A1))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS1"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS1(A1)));
            }
            string A2 = T2.Text;
            if (!string.IsNullOrEmpty(A2))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS2"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS2(A2)));
            }

            string A3 = T3.Text;
            if (!string.IsNullOrEmpty(A3))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS3"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS3(A3)));
            }
            string A4 = T4.Text;
            if (!string.IsNullOrEmpty(A4))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS4"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS4(A4)));
            }
            string A5 = T5.Text;
            if (!string.IsNullOrEmpty(A5))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS5"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS5(A5)));
            }
            string A6 = T6.Text;
            if (!string.IsNullOrEmpty(A6))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS6"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS6(A6)));
            }
            string A7 = T7.Text;
            if (!string.IsNullOrEmpty(A7))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS7"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS7(A7)));
            }
            string A8 = T8.Text;
            if (!string.IsNullOrEmpty(A8))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS8"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS8(A8)));
            }
            string A9 = T9.Text;
            if (!string.IsNullOrEmpty(A9))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS9"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS9(A9)));
            }
            string A10 = T10.Text;
            if (!string.IsNullOrEmpty(A10))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS10"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS10(A10)));
            }
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }

            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }
        }
        private void get_loc_18_2()
        {
            gridView3.ActiveFilter.Clear();

            string A1 = T1.Text;
            if (!string.IsNullOrEmpty(A1))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS1"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS1(A1)));
            }
            string A2 = T2.Text;
            if (!string.IsNullOrEmpty(A2))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS2"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS2(A2)));
            }

            string A3 = T3.Text;
            if (!string.IsNullOrEmpty(A3))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS3"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS3(A3)));
            }
            string A4 = T4.Text;
            if (!string.IsNullOrEmpty(A4))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS4"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS4(A4)));
            }
            string A5 = T5.Text;
            if (!string.IsNullOrEmpty(A5))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS5"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS5(A5)));
            }
            string A6 = T6.Text;
            if (!string.IsNullOrEmpty(A6))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS6"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS6(A6)));
            }
            string A7 = T7.Text;
            if (!string.IsNullOrEmpty(A7))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS7"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS7(A7)));
            }
            string A8 = T8.Text;
            if (!string.IsNullOrEmpty(A8))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS8"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS8(A8)));
            }
            string A9 = T9.Text;
            if (!string.IsNullOrEmpty(A9))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS9"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS9(A9)));
            }
            string A10 = T10.Text;
            if (!string.IsNullOrEmpty(A10))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS10"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS10(A10)));
            }
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }

            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }
        }
        private void get_loc_18_3()
        {
            gridView3.ActiveFilter.Clear();
            string A2 = T2.Text;
            if (!string.IsNullOrEmpty(A2))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS2"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS2(A2)));
            }

            string A3 = T3.Text;
            if (!string.IsNullOrEmpty(A3))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS3"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS3(A3)));
            }
            string A4 = T4.Text;
            if (!string.IsNullOrEmpty(A4))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS4"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS4(A4)));
            }
            string A5 = T5.Text;
            if (!string.IsNullOrEmpty(A5))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS5"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS5(A5)));
            }
            string A6 = T6.Text;
            if (!string.IsNullOrEmpty(A6))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS6"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS6(A6)));
            }
            string A7 = T7.Text;
            if (!string.IsNullOrEmpty(A7))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS7"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS7(A7)));
            }
            string A8 = T8.Text;
            if (!string.IsNullOrEmpty(A8))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS8"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS8(A8)));
            }
            string A9 = T9.Text;
            if (!string.IsNullOrEmpty(A9))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS9"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS9(A9)));
            }
            string A10 = T10.Text;
            if (!string.IsNullOrEmpty(A10))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS10"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS10(A10)));
            }
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }

            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }
        }
        private void get_loc_18_4()
        {
            gridView3.ActiveFilter.Clear();
            string A3 = T3.Text;
            if (!string.IsNullOrEmpty(A3))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS3"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS3(A3)));
            }
            string A4 = T4.Text;
            if (!string.IsNullOrEmpty(A4))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS4"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS4(A4)));
            }
            string A5 = T5.Text;
            if (!string.IsNullOrEmpty(A5))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS5"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS5(A5)));
            }
            string A6 = T6.Text;
            if (!string.IsNullOrEmpty(A6))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS6"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS6(A6)));
            }
            string A7 = T7.Text;
            if (!string.IsNullOrEmpty(A7))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS7"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS7(A7)));
            }
            string A8 = T8.Text;
            if (!string.IsNullOrEmpty(A8))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS8"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS8(A8)));
            }
            string A9 = T9.Text;
            if (!string.IsNullOrEmpty(A9))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS9"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS9(A9)));
            }
            string A10 = T10.Text;
            if (!string.IsNullOrEmpty(A10))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS10"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS10(A10)));
            }
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }

            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }
        }
        private void get_loc_18_5()
        {
            gridView3.ActiveFilter.Clear();
            string A4 = T4.Text;
            if (!string.IsNullOrEmpty(A4))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS4"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS4(A4)));
            }
            string A5 = T5.Text;
            if (!string.IsNullOrEmpty(A5))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS5"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS5(A5)));
            }
            string A6 = T6.Text;
            if (!string.IsNullOrEmpty(A6))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS6"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS6(A6)));
            }
            string A7 = T7.Text;
            if (!string.IsNullOrEmpty(A7))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS7"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS7(A7)));
            }
            string A8 = T8.Text;
            if (!string.IsNullOrEmpty(A8))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS8"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS8(A8)));
            }
            string A9 = T9.Text;
            if (!string.IsNullOrEmpty(A9))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS9"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS9(A9)));
            }
            string A10 = T10.Text;
            if (!string.IsNullOrEmpty(A10))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS10"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS10(A10)));
            }
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }

            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_6()
        {
            gridView3.ActiveFilter.Clear();

            string A5 = T5.Text;
            if (!string.IsNullOrEmpty(A5))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS5"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS5(A5)));
            }
            string A6 = T6.Text;
            if (!string.IsNullOrEmpty(A6))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS6"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS6(A6)));
            }
            string A7 = T7.Text;
            if (!string.IsNullOrEmpty(A7))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS7"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS7(A7)));
            }
            string A8 = T8.Text;
            if (!string.IsNullOrEmpty(A8))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS8"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS8(A8)));
            }
            string A9 = T9.Text;
            if (!string.IsNullOrEmpty(A9))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS9"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS9(A9)));
            }
            string A10 = T10.Text;
            if (!string.IsNullOrEmpty(A10))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS10"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS10(A10)));
            }
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }

            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_7()
        {
            gridView3.ActiveFilter.Clear();

            string A6 = T6.Text;
            if (!string.IsNullOrEmpty(A6))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS6"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS6(A6)));
            }
            string A7 = T7.Text;
            if (!string.IsNullOrEmpty(A7))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS7"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS7(A7)));
            }
            string A8 = T8.Text;
            if (!string.IsNullOrEmpty(A8))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS8"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS8(A8)));
            }
            string A9 = T9.Text;
            if (!string.IsNullOrEmpty(A9))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS9"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS9(A9)));
            }
            string A10 = T10.Text;
            if (!string.IsNullOrEmpty(A10))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS10"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS10(A10)));
            }
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }

            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_8()
        {
            gridView3.ActiveFilter.Clear();
            string A7 = T7.Text;
            if (!string.IsNullOrEmpty(A7))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS7"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS7(A7)));
            }
            string A8 = T8.Text;
            if (!string.IsNullOrEmpty(A8))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS8"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS8(A8)));
            }
            string A9 = T9.Text;
            if (!string.IsNullOrEmpty(A9))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS9"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS9(A9)));
            }
            string A10 = T10.Text;
            if (!string.IsNullOrEmpty(A10))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS10"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS10(A10)));
            }
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }

            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_9()
        {
            gridView3.ActiveFilter.Clear();
            string A8 = T8.Text;
            if (!string.IsNullOrEmpty(A8))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS8"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS8(A8)));
            }
            string A9 = T9.Text;
            if (!string.IsNullOrEmpty(A9))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS9"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS9(A9)));
            }
            string A10 = T10.Text;
            if (!string.IsNullOrEmpty(A10))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS10"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS10(A10)));
            }
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }

            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_10()
        {

            gridView3.ActiveFilter.Clear();
            string A9 = T9.Text;
            if (!string.IsNullOrEmpty(A9))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS9"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS9(A9)));
            }
            string A10 = T10.Text;
            if (!string.IsNullOrEmpty(A10))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS10"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS10(A10)));
            }
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }

            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_11()
        {

            gridView3.ActiveFilter.Clear();
            string A10 = T10.Text;
            if (!string.IsNullOrEmpty(A10))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS10"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS10(A10)));
            }
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }

            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_12()
        {

            gridView3.ActiveFilter.Clear();
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }

            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_13()
        {
            gridView3.ActiveFilter.Clear();
            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_14()
        {
            gridView3.ActiveFilter.Clear();


            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_15()
        {
            gridView3.ActiveFilter.Clear();


            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_16()
        {
            gridView3.ActiveFilter.Clear();

            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_1511()
        {
            gridView3.ActiveFilter.Clear();
            string A11 = T11.Text;
            if (!string.IsNullOrEmpty(A11))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS11"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS11(A11)));
            }
            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_151()
        {
            gridView3.ActiveFilter.Clear();
            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A151 = T151.Text;
            if (!string.IsNullOrEmpty(A151))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS151"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS151(A151)));
            }

            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_151_1()
        {
            gridView3.ActiveFilter.Clear();
          
            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A151 = T151.Text;
            if (!string.IsNullOrEmpty(A151))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS151"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS151(A151)));
            }

            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_151_2()
        {
            gridView3.ActiveFilter.Clear();

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A151 = T151.Text;
            if (!string.IsNullOrEmpty(A151))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS151"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS151(A151)));
            }

            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_151_3()
        {
            gridView3.ActiveFilter.Clear();

          
            string A151 = T151.Text;
            if (!string.IsNullOrEmpty(A151))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS151"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS151(A151)));
            }

            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_191()
        {
            gridView3.ActiveFilter.Clear();
            string A12 = T12.Text;
            if (!string.IsNullOrEmpty(A12))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS12"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS12(A12)));
            }

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }

            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView3.ActiveFilter.Add(gridView3.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_191_2()
        {
            gridView4.ActiveFilter.Clear();

            string A13 = T13.Text;
            if (!string.IsNullOrEmpty(A13))
            {
                //gridView1.ActiveFilter.Clear();
                gridView4.ActiveFilter.Add(gridView4.Columns["SS13"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS13(A13)));
            }

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView4.ActiveFilter.Add(gridView4.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView4.ActiveFilter.Add(gridView4.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }

            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView4.ActiveFilter.Add(gridView4.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView4.ActiveFilter.Add(gridView4.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView4.ActiveFilter.Add(gridView4.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView4.ActiveFilter.Add(gridView4.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_191_3()
        {
            gridView5.ActiveFilter.Clear();

            string A14 = T14.Text;
            if (!string.IsNullOrEmpty(A14))
            {
                //gridView1.ActiveFilter.Clear();
                gridView5.ActiveFilter.Add(gridView5.Columns["SS14"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS14(A14)));
            }
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView5.ActiveFilter.Add(gridView5.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView5.ActiveFilter.Add(gridView5.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView5.ActiveFilter.Add(gridView5.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView5.ActiveFilter.Add(gridView5.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView5.ActiveFilter.Add(gridView5.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }
        private void get_loc_18_191_4()
        {
            gridView6.ActiveFilter.Clear();
            string A15 = T15.Text;
            if (!string.IsNullOrEmpty(A15))
            {
                //gridView1.ActiveFilter.Clear();
                gridView6.ActiveFilter.Add(gridView6.Columns["SS15"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS15(A15)));
            }
            string A16 = T16.Text;
            if (!string.IsNullOrEmpty(A16))
            {
                //gridView1.ActiveFilter.Clear();
                gridView6.ActiveFilter.Add(gridView6.Columns["SS16"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS16(A16)));
            }

            string A17 = T17.Text;
            if (!string.IsNullOrEmpty(A17))
            {
                //gridView1.ActiveFilter.Clear();
                gridView6.ActiveFilter.Add(gridView6.Columns["SS17"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS17(A17)));
            }
            string A18 = T18.Text;
            if (!string.IsNullOrEmpty(A18))
            {
                //gridView1.ActiveFilter.Clear();
                gridView6.ActiveFilter.Add(gridView6.Columns["SS18"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS18(A18)));
            }
            string A19 = T19.Text;
            if (!string.IsNullOrEmpty(A19))
            {
                //gridView1.ActiveFilter.Clear();
                gridView6.ActiveFilter.Add(gridView6.Columns["SS19"],
                    new DevExpress.XtraGrid.Columns.ColumnFilterInfo(CreateContainsFilter_SS19(A19)));
            }

        }


        // Phương thức helper để nhận bộ lọc từ một bước cụ thể
        //private string GetFilterFromStep(Action filterStep)
        //{
        //    filterStep.Invoke(); // Áp dụng bộ lọc
        //    gridView3.RefreshData(); // Làm mới để lấy đúng số lượng dòng dữ liệu

        //    // Nếu số dòng >= 2, trả về điều kiện lọc, nếu không thì bỏ qua
        //    if (gridView3.DataRowCount >= 1)
        //    {
        //        return gridView3.ActiveFilterString;
        //    }

        //    return null;
        //}
        private void get_loc_so1()
        {
            // Tạo một danh sách các hàm lọc cần gọi
            Action[] loc_methods = {
                  get_loc_18_191
                 };

            // Lặp qua từng hàm lọc cho đến khi tìm thấy dữ liệu
            foreach (var loc_method in loc_methods)
            {
                loc_method();

                // Kiểm tra số lượng dòng sau mỗi lần lọc
                if (gridView3.DataRowCount >= 1)
                {
                    // Nếu đã có dữ liệu thì dừng lại
                    break;
                }
            }


        }
        private void get_loc_so2()
        {
            // Tạo một danh sách các hàm lọc cần gọi
            Action[] loc_methods = {
                  get_loc_18_191_2
                 };

            // Lặp qua từng hàm lọc cho đến khi tìm thấy dữ liệu
            foreach (var loc_method in loc_methods)
            {
                loc_method();

                // Kiểm tra số lượng dòng sau mỗi lần lọc
                if (gridView4.DataRowCount >= 1)
                {
                    // Nếu đã có dữ liệu thì dừng lại
                    break;
                }
            }


        }
        private void get_loc_so3()
        {
            // Tạo một danh sách các hàm lọc cần gọi
            Action[] loc_methods = {
                  get_loc_18_191_3
                 };

            // Lặp qua từng hàm lọc cho đến khi tìm thấy dữ liệu
            foreach (var loc_method in loc_methods)
            {
                loc_method();

                // Kiểm tra số lượng dòng sau mỗi lần lọc
                if (gridView5.DataRowCount >= 1)
                {
                    // Nếu đã có dữ liệu thì dừng lại
                    break;
                }
            }


        }
        private void get_loc_so4()
        {
            // Tạo một danh sách các hàm lọc cần gọi
            Action[] loc_methods = {
                  get_loc_18_191_4
                 };

            // Lặp qua từng hàm lọc cho đến khi tìm thấy dữ liệu
            foreach (var loc_method in loc_methods)
            {
                loc_method();

                // Kiểm tra số lượng dòng sau mỗi lần lọc
                if (gridView6.DataRowCount >= 1)
                {
                    // Nếu đã có dữ liệu thì dừng lại
                    break;
                }
            }


        }
        private void get_loc_tong_bk()
        {
            // Tạo một danh sách các hàm lọc cần gọi
            Action[] loc_methods = { 
                  get_loc_18_13,get_loc_18_14,get_loc_18_15,get_loc_18_16
                 };

            // Lặp qua từng hàm lọc cho đến khi tìm thấy dữ liệu
            foreach (var loc_method in loc_methods)
            {
                loc_method();

                // Kiểm tra số lượng dòng sau mỗi lần lọc
                if (gridView3.DataRowCount >= 1)
                {
                    // Nếu đã có dữ liệu thì dừng lại
                    break;
                }
            }

            //int countGreaterThan10 = 0;
            //int countLessThanOrEqual10 = 0;

            //for (int i = 0; i < gridView3.RowCount; i++)
            //{
            //    int value = Convert.ToInt32(gridView3.GetRowCellValue(i, "SS20"));

            //    if (value > 10)
            //    {
            //        countGreaterThan10++;
            //    }
            //    else if (value <= 10)
            //    {
            //        countLessThanOrEqual10++;
            //    }
            //}
            //labelControl1.Text = "Số dòng <= 10: " + countLessThanOrEqual10.ToString();
            //label2.Text = "Số dòng >10: " + countGreaterThan10.ToString();


        }
        private void get_loc_tong_bk1()
        {
            // Tạo một danh sách các hàm lọc cần gọi
            Action[] loc_methods = {get_loc_18_151,get_loc_18_1511, get_loc_18_151_1,get_loc_18_151_2,get_loc_18_151_3
                 };

            // Lặp qua từng hàm lọc cho đến khi tìm thấy dữ liệu
            foreach (var loc_method in loc_methods)
            {
                loc_method();

                // Kiểm tra số lượng dòng sau mỗi lần lọc
                if (gridView3.DataRowCount >= 1)
                {
                    // Nếu đã có dữ liệu thì dừng lại
                    break;
                }
            }

           

        }
        private void get_loc_tong_bk2()
        {
            // Tạo một danh sách các hàm lọc cần gọi
            Action[] loc_methods = { get_loc_18_3,get_loc_18_4,get_loc_18_5,get_loc_18_6
                    ,get_loc_18_7,get_loc_18_8,get_loc_18_9,get_loc_18_10,get_loc_18_11,get_loc_18_12
                 };

            // Lặp qua từng hàm lọc cho đến khi tìm thấy dữ liệu
            foreach (var loc_method in loc_methods)
            {
                loc_method();

                // Kiểm tra số lượng dòng sau mỗi lần lọc
                if (gridView3.DataRowCount >= 1)
                {
                    // Nếu đã có dữ liệu thì dừng lại
                    break;
                }
            }

            int countGreaterThan10 = 0;
            int countLessThanOrEqual10 = 0;

            for (int i = 0; i < gridView3.RowCount; i++)
            {
                int value = Convert.ToInt32(gridView3.GetRowCellValue(i, "SS20"));

                if (value > 10)
                {
                    countGreaterThan10++;
                }
                else if (value <= 10)
                {
                    countLessThanOrEqual10++;
                }
            }
            labelControl1.Text = "Số dòng <= 10: " + countLessThanOrEqual10.ToString();
            label2.Text = "Số dòng >10: " + countGreaterThan10.ToString();


        }
        private void get_loc_tong_bk3()
        {
            // Tạo một danh sách các hàm lọc cần gọi
            Action[] loc_methods = { get_loc_18_4,get_loc_18_5,get_loc_18_6
                    ,get_loc_18_7,get_loc_18_8,get_loc_18_9,get_loc_18_10,get_loc_18_11,get_loc_18_12
                 };

            // Lặp qua từng hàm lọc cho đến khi tìm thấy dữ liệu
            foreach (var loc_method in loc_methods)
            {
                loc_method();

                // Kiểm tra số lượng dòng sau mỗi lần lọc
                if (gridView3.DataRowCount >= 1)
                {
                    // Nếu đã có dữ liệu thì dừng lại
                    break;
                }
            }

            int countGreaterThan10 = 0;
            int countLessThanOrEqual10 = 0;

            for (int i = 0; i < gridView3.RowCount; i++)
            {
                int value = Convert.ToInt32(gridView3.GetRowCellValue(i, "SS20"));

                if (value > 10)
                {
                    countGreaterThan10++;
                }
                else if (value <= 10)
                {
                    countLessThanOrEqual10++;
                }
            }
            labelControl1.Text = "Số dòng <= 10: " + countLessThanOrEqual10.ToString();
            label2.Text = "Số dòng >10: " + countGreaterThan10.ToString();


        }
        private void get_loc_tong_191()
        {
            // Tạo một danh sách các hàm lọc cần gọi
            Action[] loc_methods = {get_loc_18_191, get_loc_18_191_2,get_loc_18_191_3,get_loc_18_191_4
                 };

            // Lặp qua từng hàm lọc cho đến khi tìm thấy dữ liệu
            foreach (var loc_method in loc_methods)
            {
                loc_method();

                // Kiểm tra số lượng dòng sau mỗi lần lọc
                if (gridView3.DataRowCount >= 1)
                {
                    // Nếu đã có dữ liệu thì dừng lại
                    break;
                }
            }



        }

        #endregion
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            get_loc_tong_bk();
        }

        private void N_TX_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void simpleButton5_Click(object sender, EventArgs e)
        {

            var source = new ExcelDataSource();
            source.FileName = @"G:\PHAN MEM LAN\KBYT\KBYT\KIEMSOAT_RAVAO_20240727\KIEMSOAT_RAVAO_20230213\KIEMSOAT_RAVAO_3SO\bin\Debug\data";
            var worksheetSettings = new ExcelWorksheetSettings("Sheet", "A1:U170000");
            source.SourceOptions = new ExcelSourceOptions(worksheetSettings);
            source.Fill();
            gridControl3.DataSource = source;


        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = cn;
                command.CommandTimeout = 0;
                command.CommandText = "GET_SID_BY_NUM_new_bk_kieuchitiet_kieumoi";
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.Add(new SqlParameter("@G", SqlDbType.NVarChar)).Value = comboBox1.Text;
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = command;
                da.Fill(ds);
                gridControl1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
 
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void simpleButton12_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = cn;
                command.CommandTimeout = 0;
                command.CommandText = "GET_SID_BY_NUM_new_bk_kieuchitiet";
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.Add(new SqlParameter("@G", SqlDbType.NVarChar)).Value = comboBox1.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void simpleButton13_Click(object sender, EventArgs e)
        {
            foreach (GridColumn column in gridView1.Columns)
            {
                //make all export columns visible
                column.Visible = true;
            }
            gridView1.ExportToXlsx(@"D:\tx_chitiet.xlsx");
        }
        private void simpleButton14_Click(object sender, EventArgs e)
        {
            var source = new ExcelDataSource();
            source.FileName = @"D:\tx_chitiet.xlsx";
            var worksheetSettings = new ExcelWorksheetSettings("Sheet", "A1:AG150000");
            source.SourceOptions = new ExcelSourceOptions(worksheetSettings);
            source.Fill();
            gridControl1.DataSource = source;
        }
        private void simpleButton15_Click(object sender, EventArgs e)
        {
           
        }
        private void simpleButton16_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("F:\\PHAN MEM LAN\\KBYT\\GET_DATA.xlsx");
            if (fi.Exists)
            {
                System.Diagnostics.Process.Start(@"F:\PHAN MEM LAN\KBYT\GET_DATA.xlsx");
            }
            else
            {
                //file doesn't exist
            }
        }
        private void ins()
        {
            try
            {

                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = cn;
                command.CommandTimeout = 0;
                command.CommandText = "ins_5so";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@SS11", SqlDbType.Int)).Value = T11.Text;
                command.Parameters.Add(new SqlParameter("@SS12", SqlDbType.Int)).Value = T12.Text;
                command.Parameters.Add(new SqlParameter("@SS13", SqlDbType.Int)).Value = T13.Text;
                command.Parameters.Add(new SqlParameter("@SS14", SqlDbType.Int)).Value = T14.Text;
                command.Parameters.Add(new SqlParameter("@SS15", SqlDbType.Int)).Value = T15.Text;
                command.Parameters.Add(new SqlParameter("@SS16", SqlDbType.Int)).Value = T16.Text;
                command.Parameters.Add(new SqlParameter("@SS17", SqlDbType.Int)).Value = T17.Text;
                command.Parameters.Add(new SqlParameter("@SS18", SqlDbType.Int)).Value = T18.Text;
                command.Parameters.Add(new SqlParameter("@SS19", SqlDbType.Int)).Value = T19.Text;
                command.Parameters.Add(new SqlParameter("@SS20", SqlDbType.Int)).Value = THT1.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void simpleButton17_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = cn;
                command.CommandTimeout = 0;
                command.CommandText = "ins_5so";
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.Add(new SqlParameter("@G", SqlDbType.NVarChar)).Value = comboBox1.Text;
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = command;
                da.Fill(ds);
                gridControl1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void THT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                get_dulieu();
                THT.Focus();
            }
        }
        private void T17_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(T17.Text);
                if (A <= 10)
                {
                    T17.BackColor = Color.LightYellow;

                }
                else
                {
                    T17.BackColor = Color.LightPink;
                }
            }
            catch { }


        }

        private void T16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(T16.Text);
                if (A <= 10)
                {
                    T16.BackColor = Color.LightYellow;

                }
                else
                {
                    T16.BackColor = Color.LightPink;
                }
            }
            catch { }
        }

        private void T15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(T15.Text);
                if (A <= 10)
                {
                    T15.BackColor = Color.LightYellow;

                }
                else
                {
                    T15.BackColor = Color.LightPink;
                }
            }
            catch { }
        }

        private void T14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(T14.Text);
                if (A <= 10)
                {
                    T14.BackColor = Color.LightYellow;

                }
                else
                {
                    T14.BackColor = Color.LightPink;
                }
            }
            catch { }
        }

        private void T13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(T13.Text);
                if (A <= 10)
                {
                    T13.BackColor = Color.LightYellow;

                }
                else
                {
                    T13.BackColor = Color.LightPink;
                }
            }
            catch { }
        }

        private void T12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(T12.Text);
                if (A <= 10)
                {
                    T12.BackColor = Color.LightYellow;

                }
                else
                {
                    T12.BackColor = Color.LightPink;
                }
            }
            catch { }
        }

        private void T11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(T11.Text);
                if (A <= 10)
                {
                    T11.BackColor = Color.LightYellow;

                }
                else
                {
                    T11.BackColor = Color.LightPink;
                }
            }
            catch { }
        }

        private void T10_TextChanged(object sender, EventArgs e)
        {
            if (T10.Text == "X")
            {
                T10.BackColor = Color.LightYellow;
            }
            else
            {
                T10.BackColor = Color.LightPink;
            }
        }

        private void T9_TextChanged(object sender, EventArgs e)
        {
            if (T9.Text == "X")
            {
                T9.BackColor = Color.LightYellow;
            }
            else
            {
                T9.BackColor = Color.LightPink;
            }
        }

        private void T8_TextChanged(object sender, EventArgs e)
        {
            if (T8.Text == "X")
            {
                T8.BackColor = Color.LightYellow;
            }
            else
            {
                T8.BackColor = Color.LightPink;
            }
        }

        private void T7_TextChanged(object sender, EventArgs e)
        {
            if (T7.Text == "X")
            {
                T7.BackColor = Color.LightYellow;
            }
            else
            {
                T7.BackColor = Color.LightPink;
            }
        }

        private void T6_TextChanged(object sender, EventArgs e)
        {
            if (T6.Text == "X")
            {
                T6.BackColor = Color.LightYellow;
            }
            else
            {
                T6.BackColor = Color.LightPink;
            }
        }

        private void T5_TextChanged(object sender, EventArgs e)
        {
            if (T5.Text == "X")
            {
                T5.BackColor = Color.LightYellow;
            }
            else
            {
                T5.BackColor = Color.LightPink;
            }
        }

        private void T4_TextChanged(object sender, EventArgs e)
        {
            if (T4.Text == "X")
            {
                T4.BackColor = Color.LightYellow;
            }
            else
            {
                T4.BackColor = Color.LightPink;
            }
        }

        private void T3_TextChanged(object sender, EventArgs e)
        {
            if (T3.Text == "X")
            {
                T3.BackColor = Color.LightYellow;
            }
            else
            {
                T3.BackColor = Color.LightPink;
            }
        }

        private void T2_TextChanged(object sender, EventArgs e)
        {
            if (T2.Text == "X")
            {
                T2.BackColor = Color.LightYellow;
            }
            else
            {
                T2.BackColor = Color.LightPink;
            }
        }

        private void T1_TextChanged(object sender, EventArgs e)
        {
            if (T1.Text == "X")
            {
                T1.BackColor = Color.LightYellow;
            }
            else
            {
                T1.BackColor = Color.LightPink;
            }
        }

        private void T0_TextChanged(object sender, EventArgs e)
        {
            if (T0.Text == "X")
            {
                T0.BackColor = Color.LightYellow;
            }
            else
            {
                T0.BackColor = Color.LightPink;
            }
        }
        private void T14_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(T14.Text);
                if (A <= 10)
                {
                    T14.BackColor = Color.LightYellow;

                }
                else
                {
                    T14.BackColor = Color.LightPink;
                }
            }
            catch { }
        }

        private void THT_SelectedValueChanged(object sender, EventArgs e)
        {



        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            T0.Text = "";
            T1.Text = "";
            T2.Text = "";
            T3.Text = "";
            T4.Text = "";
            T5.Text = "";
            T6.Text = "";
            T7.Text = "";
            T8.Text = "";
            T9.Text = "";
            T10.Text = "";
            T11.Text = "";
            T12.Text = "";
            T13.Text = "";
            T14.Text = "";
            T15.Text = "";
            T16.Text = "";
            T17.Text = "";
            T18.Text = "";
            T19.Text = "";
            THT1.Text = "";

        }
        private void gridView3_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SS11")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS11"));
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


            if (e.Column.FieldName == "SS12")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS12"));
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
            if (e.Column.FieldName == "SS13")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS13"));
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
            if (e.Column.FieldName == "SS14")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS14"));
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

            if (e.Column.FieldName == "SS15")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS15"));
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

            if (e.Column.FieldName == "SS16")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS16"));
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
            if (e.Column.FieldName == "SS17")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS17"));
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
            if (e.Column.FieldName == "SS18")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS18"));
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

            if (e.Column.FieldName == "SS19")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS19"));
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

            if (e.Column.FieldName == "SS20")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS20"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = Color.Aqua;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                }
                else { e.Appearance.BackColor = Color.Aqua; }
            }
           
        }

        private void T18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(T18.Text);
                if (A <= 10)
                {
                    T18.BackColor = Color.LightYellow;

                }
                else
                {
                    T18.BackColor = Color.LightPink;
                }
            }
            catch { }

        }

        private void T19_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(T19.Text);
                if (A <= 10)
                {
                    T19.BackColor = Color.LightYellow;

                }
                else
                {
                    T19.BackColor = Color.LightPink;
                }
            }
            catch { }

        }

        private void simpleButton34_Click(object sender, EventArgs e)
        {
            THT1.Text = "6";get_dulieu();
        }

        private void simpleButton36_Click(object sender, EventArgs e)
        {
            THT1.Text = "7";get_dulieu();
        }

        private void simpleButton35_Click(object sender, EventArgs e)
        {
            THT1.Text = "8";get_dulieu();
        }

        private void simpleButton38_Click(object sender, EventArgs e)
        {
            THT1.Text = "9";get_dulieu();
        }

        private void simpleButton37_Click(object sender, EventArgs e)
        {
            THT1.Text = "10";get_dulieu();
        }

        private void simpleButton40_Click(object sender, EventArgs e)
        {
            THT1.Text = "11";get_dulieu();
        }

        private void simpleButton39_Click(object sender, EventArgs e)
        {
            THT1.Text = "12";get_dulieu();
        }

        private void simpleButton42_Click(object sender, EventArgs e)
        {
            THT1.Text = "13";get_dulieu();
        }

        private void simpleButton41_Click(object sender, EventArgs e)
        {
            THT1.Text = "14";get_dulieu();
        }

        private void simpleButton43_Click(object sender, EventArgs e)
        {
            THT1.Text = "15";get_dulieu();
        }

        private void simpleButton44_Click(object sender, EventArgs e)
        {
            THT1.Text = "16";get_dulieu();
        }
        private void get_t16()
        {

            int a = Convert.ToInt32(T15.Text);
            if (a > 10)
            {
                T14.Text = "T";
            }
            else {T14.Text = "X"; }
        } 
        private void get_dulieu()
        {

            ins();
            AddNewRowToGridView();
            if (checkEdit4.Checked == true)
            {
                T11.Text = T12.Text;
                T12.Text = T13.Text;
                T13.Text = T14.Text;
                T14.Text = T15.Text;
                T15.Text = T16.Text;
                T16.Text = T17.Text;
                T17.Text = T18.Text;
                T18.Text = T19.Text;
                T19.Text = THT1.Text;
                THT1.Text = "";
                THT1.Focus();
            }
            else if (checkEdit4.Checked == false)
            {
                T11.Text = T12.Text;
                T12.Text = T13.Text;
                T13.Text = T14.Text;
                T14.Text = T15.Text;
                T15.Text = T16.Text;
                T16.Text = T17.Text;
                T17.Text = T18.Text;
                T18.Text = T19.Text;
                T19.Text = THT1.Text;
                THT1.Text = "";
                THT1.Focus();
                get_loc_so1(); get_loc_so2(); get_loc_so3(); get_loc_so4();
            }
       
        }
        private void simpleButton47_Click(object sender, EventArgs e)
        {
            THT1.Text = "4";get_dulieu();
        }

        private void simpleButton46_Click(object sender, EventArgs e)
        {
            THT1.Text = "3";get_dulieu();
        }

        private void simpleButton48_Click(object sender, EventArgs e)
        {
            THT1.Text = "17";get_dulieu();
        }

        private void simpleButton49_Click_1(object sender, EventArgs e)
        {
            THT1.Text = "18";get_dulieu();
        }
        private void LoadExcelFileToGridView(string filePath, string password)
        {
            DataTable dt = new DataTable();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // Mở file Excel với mật khẩu
            using (var package = new ExcelPackage(new FileInfo(filePath), password))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                bool firstRow = true;

                foreach (var cell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                {
                    // Tạo cột trong DataTable cho mỗi cột trong Excel
                    if (firstRow)
                    {
                        dt.Columns.Add(cell.Text);
                    }
                }

                firstRow = false;

                // Đọc từng dòng và thêm dữ liệu vào DataTable
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow newRow = dt.NewRow();
                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        newRow[col - 1] = worksheet.Cells[row, col].Text;
                    }
                    dt.Rows.Add(newRow);
                }
            }

            // Bind DataTable vào GridView
            gridControl3.DataSource = dt;
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Yêu cầu người dùng nhập mật khẩu
                string password = Microsoft.VisualBasic.Interaction.InputBox("Nhập mật khẩu để mở file Excel", "Mật khẩu");

                // Kiểm tra xem người dùng có nhập mật khẩu không
                if (!string.IsNullOrEmpty(password))
                {
                    LoadExcelFileToGridView(openFileDialog.FileName, password);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu.");
                }
            }
        }
        private void open()
        {
            // Đường dẫn file cố định
            string filePath = @"G:\gridview_data.xlsx";  // Thay thế bằng đường dẫn file cố định của bạn

            // Mật khẩu được điền sẵn
            string password = "Abc123a@";  // Thay thế bằng mật khẩu mong muốn

            // Kiểm tra xem file có tồn tại hay không
            if (System.IO.File.Exists(filePath))
            {
                // Tải file Excel vào GridView và sử dụng mật khẩu đã điền sẵn
                LoadExcelFileToGridView(filePath, password);
            }
            else
            {
                MessageBox.Show("File không tồn tại. Vui lòng kiểm tra lại đường dẫn.");
            }
        }
        private void AddNewRowToGridView()
        {
            //if(checkEdit3.Checked==true)
            //{
            //    ins();
            //}    

            

        }
        private void addnewrow()
        {
            AddNewRowToGridView();
        }
        private void SetExcelFilePassword(string filePath, string password)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            // Mở file Excel bằng EPPlus
            using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
            {
                // Thiết lập mã hóa cho file và đặt mật khẩu
                excelPackage.SaveAs(new FileInfo(filePath), password);
            }
        }
        private void ExportGridToExcelWithPassword()
        {
            if (checkEdit2.Checked == true)
            {
                gridView3.ActiveFilter.Clear();
                // Đường dẫn lưu file Excel
                string filePath = @"G:\gridview_data.xlsx";

                try
                {
                    // Tạm thời hiển thị tất cả các cột bị ẩn trước khi xuất
                    GridView view = gridControl3.MainView as GridView;
                    if (view != null)
                    {
                        for (int i = 0; i < view.Columns.Count; i++)
                        {
                            if (!view.Columns[i].Visible)
                            {
                                view.Columns[i].Visible = true; // Hiển thị các cột bị ẩn
                            }
                        }
                    }

                    // Xuất dữ liệu từ GridControl sang file Excel
                    XlsxExportOptionsEx exportOptions = new XlsxExportOptionsEx
                    {
                        ExportType = DevExpress.Export.ExportType.WYSIWYG // Xuất dữ liệu bao gồm cột ẩn
                    };
                    gridControl3.ExportToXlsx(filePath, exportOptions);

                    // Đặt mật khẩu cho file Excel sau khi xuất xong
                    SetExcelFilePassword(filePath, "Abc123a@");




                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                Application.Exit();
            }    
          
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {

            get_sid();
        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            THT1.Text = "5";get_dulieu();
        }

        private void N_TX_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExportGridToExcelWithPassword();
            Application.Exit();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            get_loc_tong_bk1();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            get_loc_tong_bk2();
        }

        private void simpleButton11_Click_1(object sender, EventArgs e)
        {
            get_loc_tong_bk3();
        }

        private void T17_Validated(object sender, EventArgs e)
        {

        }

        private void simpleButton17_Click_1(object sender, EventArgs e)
        {
            THT1.Text = "3";get_dulieu();
        }

        private void simpleButton15_Click_1(object sender, EventArgs e)
        {
            THT1.Text = "18";get_dulieu();
        }

        private void THT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                get_dulieu();
            }    
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            clickCount_W = 0; clickCount_L = 0;
            //lb.Text = clickCount_W.ToString(); ;
            //labelControl3.Text = clickCount_L.ToString(); ;
        }
        int clickCount_W = 0;
        int clickCount_L = 0;
        private void simpleButton20_Click(object sender, EventArgs e)
        {

            clickCount_W++;

            // Hiển thị số lần nhấn trong Label
            //labelControl2.Text = clickCount_W.ToString();
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {

            clickCount_L++;

            // Hiển thị số lần nhấn trong Label
            //labelControl3.Text = clickCount_L.ToString();
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            get_loc_so1();get_loc_so2();get_loc_so3();get_loc_so4();
            
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            // Kiểm tra phím mũi tên trái
            if (e.KeyCode == Keys.Left)
            {
                // Lấy TabIndex hiện tại
                int currentTabIndex = currentTextBox.TabIndex;

                // Tìm TextBox trước đó theo TabIndex
                Control previousControl = this.GetNextControl(currentTextBox, false);
                if (previousControl != null && previousControl is TextBox)
                {
                    previousControl.Focus();
                }
            }

            // Kiểm tra phím mũi tên phải
            if (e.KeyCode == Keys.Right)
            {
                // Lấy TabIndex hiện tại
                int currentTabIndex = currentTextBox.TabIndex;

                // Tìm TextBox tiếp theo theo TabIndex
                Control nextControl = this.GetNextControl(currentTextBox, true);
                if (nextControl != null && nextControl is TextBox)
                {
                    nextControl.Focus();
                }
            }
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            get_sid();
        }

        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gridView4_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SS11")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS11"));
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


            if (e.Column.FieldName == "SS12")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS12"));
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
            if (e.Column.FieldName == "SS13")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS13"));
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
            if (e.Column.FieldName == "SS14")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS14"));
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

            if (e.Column.FieldName == "SS15")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS15"));
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

            if (e.Column.FieldName == "SS16")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS16"));
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
            if (e.Column.FieldName == "SS17")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS17"));
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
            if (e.Column.FieldName == "SS18")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS18"));
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

            if (e.Column.FieldName == "SS19")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS19"));
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

            if (e.Column.FieldName == "SS20")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS20"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = Color.Aqua;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                }
                else { e.Appearance.BackColor = Color.Aqua; }
            }
        }

        private void gridView5_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SS11")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS11"));
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


            if (e.Column.FieldName == "SS12")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS12"));
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
            if (e.Column.FieldName == "SS13")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS13"));
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
            if (e.Column.FieldName == "SS14")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS14"));
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

            if (e.Column.FieldName == "SS15")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS15"));
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

            if (e.Column.FieldName == "SS16")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS16"));
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
            if (e.Column.FieldName == "SS17")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS17"));
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
            if (e.Column.FieldName == "SS18")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS18"));
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

            if (e.Column.FieldName == "SS19")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS19"));
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

            if (e.Column.FieldName == "SS20")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS20"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = Color.Aqua;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                }
                else { e.Appearance.BackColor = Color.Aqua; }
            }
        }

        private void gridView6_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.FieldName == "SS11")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS11"));
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


            if (e.Column.FieldName == "SS12")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS12"));
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
            if (e.Column.FieldName == "SS13")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS13"));
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
            if (e.Column.FieldName == "SS14")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS14"));
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

            if (e.Column.FieldName == "SS15")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS15"));
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

            if (e.Column.FieldName == "SS16")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS16"));
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
            if (e.Column.FieldName == "SS17")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS17"));
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
            if (e.Column.FieldName == "SS18")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS18"));
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

            if (e.Column.FieldName == "SS19")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS19"));
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

            if (e.Column.FieldName == "SS20")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS20"));
                if (VALUE <= 10)
                {
                    e.Appearance.BackColor = Color.Aqua;
                }
                else if (VALUE > 10)
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                }
                else { e.Appearance.BackColor = Color.Aqua; }
            }
        }
    }


}
