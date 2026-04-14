using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using ClosedXML.Excel;
using System.Diagnostics;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;


namespace KIEMSOAT_RAVAO
{
    public partial class N_TX_SQL : Form
    {
        // Biến lưu giá trị trước đó của labelControl3 để so sánh
        private int previousLabelCount3 = 0;
        
        public N_TX_SQL()
        {
            InitializeComponent();
            BalanceTableLayoutPanel(this.tableLayoutPanel2);
            BalanceTableLayoutPanel(this.tableLayoutPanel1);
            BalanceTableLayoutPanel(this.tableLayoutPanel4);
            //BalanceTableLayoutPanel(this.tableLayoutPanel5);

        }
        private void get_thongtin()
        {
            string sql = @"select top 1 1,CONVERT(VARCHAR, ngaytao, 108) as SID from datatable1 order by id desc";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = default(SqlDataReader);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                labelCount1.Text = reader["SID"].ToString();
               
            }
            reader.Close();
            con.Close();
        }
        private void get_moi()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    cn.Open();
                    using (SqlCommand command = new SqlCommand("PREDICT_LOAD_DATA_6_2TX_4SO_DUONGDI", cn))
                    {
                        command.CommandTimeout = 0;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Pattern6", SqlDbType.NVarChar)).Value = richTextBox2.Text;

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            
                            gridControl7.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void get_sid()
        {
            get_thongtin();
            if (comboBoxEdit1.Text == "0")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_2", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "8")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_8", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "9")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_9", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "10")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_10", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "11")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_11", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "12")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_12", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "13")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_13", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "14")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_14", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "15")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_15", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "16")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_16", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "17")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_17", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "18")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_18", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "19")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_19", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit1.Text == "21")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_21", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                //gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "1")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_1", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit1.Text == "2")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_2", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxEdit1.Text == "3")
            {
               
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                        {
                            cn.Open();
                            using (SqlCommand command = new SqlCommand("LOAD_DATA_18_3", cn))
                            {
                                command.CommandTimeout = 0;
                                command.CommandType = CommandType.StoredProcedure;

                                using (SqlDataAdapter da = new SqlDataAdapter(command))
                                {
                                    DataSet ds = new DataSet();
                                    da.Fill(ds);
                                //gridControl3.DataSource = ds.Tables[0];
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               
            }
            if (comboBoxEdit1.Text == "4")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_4", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];


                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //try
                //{
                //    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                //    {
                //        cn.Open();
                //        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_4", cn))
                //        {
                //            command.CommandTimeout = 0;
                //            command.CommandType = CommandType.StoredProcedure;

                //            using (SqlDataAdapter da = new SqlDataAdapter(command))
                //            {
                //                DataSet ds = new DataSet();
                //                da.Fill(ds);
                //                gridControl5.DataSource = ds.Tables[0];

                //            }
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            if (comboBoxEdit1.Text == "5")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_5", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //try
                //{
                //    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                //    {
                //        cn.Open();
                //        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_6", cn))
                //        {
                //            command.CommandTimeout = 0;
                //            command.CommandType = CommandType.StoredProcedure;

                //            using (SqlDataAdapter da = new SqlDataAdapter(command))
                //            {
                //                DataSet ds = new DataSet();
                //                da.Fill(ds);
                //                gridControl7.DataSource = ds.Tables[0];


                //            }
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            if (comboBoxEdit1.Text == "6")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_6", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (comboBoxEdit1.Text == "8")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("LOAD_DATA_18_8", cn))
                        {
                            command.CommandTimeout = 0;
                            command.CommandType = CommandType.StoredProcedure;

                            using (SqlDataAdapter da = new SqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                gridControl3.DataSource = ds.Tables[0];
                                gridControl5.DataSource = ds.Tables[0];
                                gridControl7.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


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


        private void InsertIntoDatabase(string connectionString, string valueB, string valueC)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
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
        private void ExecuteStoredProcedure(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
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
            txtInput.Text = string.Empty;
            richTextBox2.Text = string.Empty;

        }

        private void N_TX_SQL_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;
            Rectangle workingArea = screen.WorkingArea;

            this.Left = workingArea.Right - this.Width;
            this.Top = workingArea.Top;

            comboBoxEdit1.Text = "21";
            cbosodongloc.Text = "15";
            
            get_sid();
            
            if (int.TryParse(labelControl3.Text, out int initialCount))
            {
                previousLabelCount3 = initialCount;
            }
        }
        private void simpleButton7_Click(object sender, EventArgs e)
        {
        }
        private DataTable GetDataFromStoredProcedure()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LOAD_DATA_10", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
        private void ExportDataTableToExcel(DataTable dt, string filePath)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dt.Columns[i].ColumnName;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = dt.Rows[i][j]?.ToString();
                    }
                }

                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(filePath);
            }
        }
        private DataTable ReadExcelToDataTable(string filePath)
        {
            DataTable dt = new DataTable();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheets.First(); // Lấy sheet đầu tiên

                // Đọc tiêu đề cột từ hàng đầu tiên
                bool isFirstRow = true;
                foreach (var row in worksheet.Rows())
                {
                    if (isFirstRow)
                    {
                        foreach (var cell in row.Cells())
                        {
                            dt.Columns.Add(cell.Value.ToString());
                        }
                        isFirstRow = false;
                    }
                    else
                    {
                        // Thêm dữ liệu vào DataTable
                        var dataRow = dt.NewRow();
                        for (int i = 0; i < row.CellCount(); i++)
                        {
                            dataRow[i] = row.Cell(i + 1).Value.ToString();
                        }
                        dt.Rows.Add(dataRow);
                    }
                }
            }

            return dt;
        }
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ stored procedure
            DataTable dt = GetDataFromStoredProcedure();

            // Hiển thị SaveFileDialog để người dùng chọn đường dẫn lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "DATA.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Xuất dữ liệu ra Excel
                    ExportDataTableToExcel(dt, saveFileDialog.FileName);
                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            get_sid();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.EditValue = gridView2.GetRowCellValue(e.FocusedRowHandle, "ID");
            txtSS.EditValue = gridView2.GetRowCellValue(e.FocusedRowHandle, "RANGES");
        }

        private void gridView3_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            //if (e.Column.FieldName == "DATA") // Đảm bảo FieldName chính xác của cột
            //{
            //    string ketQuaValue = e.CellValue as string; // Lấy giá trị cột

            //    if (!string.IsNullOrEmpty(ketQuaValue))
            //    {
            //        e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; // Cải thiện hiển thị văn bản

            //        float currentX = e.Bounds.X; // Vị trí X bắt đầu vẽ văn bản
            //        float charWidth;

            //        // Tạo font chữ đậm dựa trên font hiện tại
            //        Font boldFont = new Font(e.Appearance.Font, FontStyle.Bold);

            //        // Chia chuỗi thành mảng số
            //        string[] numbers = ketQuaValue.Split(',');

            //        // Lặp qua từng số trong mảng
            //        foreach (string numberStr in numbers)
            //        {
            //            if (int.TryParse(numberStr.Trim(), out int number)) // Chuyển đổi số và kiểm tra
            //            {
            //                Color numberColor = number > 10 ? Color.Maroon : Color.Blue; // Màu sắc dựa trên giá trị số

            //                using (SolidBrush brush = new SolidBrush(numberColor)) // Brush với màu tương ứng
            //                {
            //                    string numberString = number.ToString();
            //                    SizeF numberSize = e.Graphics.MeasureString(numberString, boldFont); // Đo kích thước số với font đậm

            //                    // Vẽ số với font đậm
            //                    e.Graphics.DrawString(numberString, boldFont, brush,
            //                        new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - numberSize.Height) / 2));

            //                    charWidth = numberSize.Width;
            //                    currentX += charWidth + 5; // Cập nhật vị trí X cho số tiếp theo (+5 để tạo khoảng cách nhỏ giữa các số)
            //                }
            //            }
            //        }

            //        // Giải phóng font đậm sau khi sử dụng
            //        boldFont.Dispose();

            //        e.Handled = true; // Đánh dấu là đã tự xử lý vẽ ô này, GridControl không cần vẽ nữa
            //    }
            //}


        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            string excelPath = @"C:\Users\SVAO89\Desktop\DATA.xlsx";
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

            using (var workbook = new XLWorkbook(excelPath))
            {
                var worksheet = workbook.Worksheet("OK");

                foreach (var row in worksheet.RowsUsed())
                {
                    string valueB = row.Cell(2).GetValue<string>();
                    string valueC = row.Cell(1).GetValue<string>();
                    InsertIntoDatabase(connectionString, valueB, valueC);
                }
            }
        }
        private void simpleButton10_Click_2(object sender, EventArgs e)
        {
            string excelPath = @"C:\Users\SVAO89\Desktop\DATA.xlsx";

            try
            {
                Process.Start(excelPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở tệp Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
        }
        private void ImportExcelToSQL()
        {
            string excelPath = @"C:\Users\SVAO89\Desktop\DATA.xlsx";
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

            using (var workbook = new XLWorkbook(excelPath))
            {
                var worksheet = workbook.Worksheet("Sheet2");

                foreach (var row in worksheet.RowsUsed())
                {
                    string valueB = row.Cell(2).GetValue<string>();
                    string valueC = row.Cell(1).GetValue<string>();
                    InsertIntoDatabase(connectionString, valueB, valueC);
                }
            }
            ExecuteStoredProcedure(connectionString);
        }

        private void INS_GOM()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("ins_gom", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        private void INS_GOM3()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cnsv3"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("ins_gom", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        private void simpleButton5_Click_3(object sender, EventArgs e)
        {
            try
            {
                ImportExcelToSQL();
                INS_GOM();
                get_sid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        #region Number Button Handlers
        private void btn11_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn11.Text);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn12.Text);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn13.Text);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn14.Text);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn15.Text);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn16.Text);
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn17.Text);
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn18.Text);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn10.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn9.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn8.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn7.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn6.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn5.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn4.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync(btn3.Text);
        }
        #endregion

        private string FindBestFilterString(DataTable sourceTable, string initialFilter)
        {
            if (string.IsNullOrEmpty(initialFilter)) return string.Empty;

            string[] allTokens = initialFilter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                             .Select(t => t.Trim())
                                             .ToArray();

            if (!int.TryParse(cbosodongloc.Text, out int MIN_TOKEN_LIMIT)) MIN_TOKEN_LIMIT = 5;
            if (!int.TryParse(cborow.Text, out int requiredRows)) requiredRows = 1;

            DataView dv = new DataView(sourceTable);
            int startIndex = 0;

            while (allTokens.Length - startIndex >= MIN_TOKEN_LIMIT)
            {
                string currentFilter = string.Join(",", allTokens, startIndex, allTokens.Length - startIndex);

                dv.RowFilter = $"DATA LIKE '%{currentFilter}'";

                if (dv.Count >= requiredRows)
                {
                    return currentFilter;
                }

                startIndex++;
            }

            int finalCount = Math.Max(MIN_TOKEN_LIMIT, 0);
            int finalStart = Math.Max(0, allTokens.Length - finalCount);

            return string.Join(",", allTokens, finalStart, allTokens.Length - finalStart);
        }

        private void PerformOptimizedGridFiltering()
        {
            string searchText = richTextBox2.Text;
            DataTable sourceTable = gridControl7.DataSource as DataTable;

            if (sourceTable == null) return;

            string lastFilterString = FindBestFilterString(sourceTable, searchText);

            if (gridView8 != null)
            {
                // 1. Áp dụng filter trước
                gridView8.ActiveFilterString = $"[DATA] like '%{lastFilterString}'";
                
                // Lưu giá trị trước đó
                int currentCount = 0;
                if (int.TryParse(labelControl3.Text, out int parsed))
                {
                    currentCount = parsed;
                }
                
                if (gridView8.DataRowCount >= 2)
                {
                    cborow.Text = "1";
                }
                else if (gridView8.DataRowCount == 1)
                {
                    cborow.Text = "2";
                }
                
                // Nếu không có dòng nào trả về, set cbosodongloc = 15
                if (gridView8.DataRowCount == 0)
                {
                    cbosodongloc.Text = "15";
                }
                
                    // 2. KIỂM TRA: Nếu còn dòng dữ liệu thỏa mãn thì mới thực hiện xoa1()
                    // DataRowCount trả về số lượng dòng sau khi đã áp dụng filter
                    if (ckxoa.Checked == true)
                {
                    if (gridView8.DataRowCount >= 1)
                    {
                        xoa1();
                    }
                }
            }

            // Cập nhật giá trị mới của labelControl3
            int count = CountFilteredCharacters();
            labelControl3.Text = $"{count}";
            
            // Lưu giá trị mới vào previousLabelCount3 để so sánh lần sau
            previousLabelCount3 = count;
        }
        private void PerformOptimizedGridFiltering6()

        {

            string searchText = richTextBox2.Text;

            DataTable sourceTable = gridControl5.DataSource as DataTable;

            if (sourceTable == null) return;

            string lastFilterString = FindBestFilterString(sourceTable, searchText);
            if (gridView5 != null)

            {

                gridView5.ActiveFilterString = $"[DATA] like  '%{lastFilterString}'";

            }
           
        }

        private void FilterGridCombined(string searchSS9, string searchDATA)
        {
            if (gridView5 != null)
            {
                List<string> filterParts = new List<string>();

                if (!string.IsNullOrEmpty(searchSS9))
                {
                    filterParts.Add($"[SS9] LIKE '{searchSS9}%'");
                }

                if (!string.IsNullOrEmpty(searchDATA))
                {
                    filterParts.Add($"[DATA] like '%{searchDATA}'");
                }

                gridView5.ActiveFilterString = string.Join(" AND ", filterParts);
            }
        }
        private void a()
        {
            string input = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                return;
            }
            if (comboBoxEdit1.Text == "0")
            {
                try
                {
                    string[] values = input.Split(',');

                    for (int i = 0; i < Math.Min(10, values.Length); i++)
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

                    string result = string.Join(",", values);
                    richTextBox2.Text = result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
            if (comboBoxEdit1.Text == "14")
            {
                try
                {
                    string[] values = input.Split(',');

                    for (int i = 0; i < Math.Min(11, values.Length); i++)
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

                    string result = string.Join(",", values);
                    richTextBox2.Text = result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
            if (comboBoxEdit1.Text == "15")
            {
                try
                {
                    string[] values = input.Split(',');

                    for (int i = 0; i < Math.Min(13, values.Length); i++)
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

                    string result = string.Join(",", values);
                    richTextBox2.Text = result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
            if (comboBoxEdit1.Text == "16")
            {
                try
                {
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(15, values.Length); i++)
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
            if (comboBoxEdit1.Text == "17")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(17, values.Length); i++)
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
            if (comboBoxEdit1.Text == "18")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(22, values.Length); i++)
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
            if (comboBoxEdit1.Text == "19")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(22, values.Length); i++)
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
            if (comboBoxEdit1.Text == "21")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(22, values.Length); i++)
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

            if (comboBoxEdit1.Text == "1")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(17, values.Length); i++)
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

            if (comboBoxEdit1.Text == "2")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(16, values.Length); i++)
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
            if (comboBoxEdit1.Text == "3")
            {

                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(7, values.Length); i++)
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

            if (comboBoxEdit1.Text == "4")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(0, values.Length); i++)
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
            if (comboBoxEdit1.Text == "5")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(0, values.Length); i++)
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
            if (comboBoxEdit1.Text == "6")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(2, values.Length); i++)
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
            if (comboBoxEdit1.Text == "8")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(4, values.Length); i++)
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
            if (comboBoxEdit1.Text == "9")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(6, values.Length); i++)
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
            if (comboBoxEdit1.Text == "10")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(6, values.Length); i++)
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
            if (comboBoxEdit1.Text == "11")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(8, values.Length); i++)
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
            if (comboBoxEdit1.Text == "12")
            {
                try
                {
                    // Chia chuỗi thành mảng các phần tử
                    string[] values = input.Split(',');

                    // Xử lý 5 phần tử đầu tiên
                    for (int i = 0; i < Math.Min(9, values.Length); i++)
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


        }
        private void AddNumberToInputAsync(string newNumber)
        {
            string inputNumbers = txtInput.Text.Trim();

            List<string> numbers = string.IsNullOrEmpty(inputNumbers)
                ? new List<string>()
                : inputNumbers.Split(',').ToList();
            if (comboBoxEdit1.Text == "0")
            {
                if (numbers.Count >= 12)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "3")
            {
                if (numbers.Count >= 10)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "4")
            {
                if (numbers.Count >= 4)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "5")
            {
                if (numbers.Count >= 5)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "6")
            {
                if (numbers.Count >= 7)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "8")
            {
                if (numbers.Count >= 8)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "9")
            {
                if (numbers.Count >= 9)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "10")
            {
                if (numbers.Count >= 10)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "11")
            {
                if (numbers.Count >= 11)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "12")
            {
                if (numbers.Count >= 12)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "13")
            {
                if (numbers.Count >= 13)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "14")
            {
                if (numbers.Count >= 14)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }

            if (comboBoxEdit1.Text == "15")
            {
                if (numbers.Count >= 15)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "16")
            {
                if (numbers.Count >= 16)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "17")
            {
                if (numbers.Count >= 17)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "18")
            {
                if (numbers.Count >= 18)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "19")
            {
                if (numbers.Count >= 19)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
            if (comboBoxEdit1.Text == "21")
            {
                if (numbers.Count >= 21)
                { numbers.RemoveAt(0); }
                numbers.Add(newNumber);
                txtInput.Text = string.Join(",", numbers);
            }
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {

            string inputNumbers = txtInput.Text.Trim();

            List<string> numbers = string.IsNullOrEmpty(inputNumbers)
                ? new List<string>()
                : inputNumbers.Split(',').ToList();
            a();
            if (comboBoxEdit1.Text == "0")
            {
                if (numbers.Count >= 12)
                {

                    PerformOptimizedGridFiltering(); PerformOptimizedGridFiltering6();


                }
            }
            if (comboBoxEdit1.Text == "3")
            {
                if (numbers.Count >= 10)
                {

                    PerformOptimizedGridFiltering(); PerformOptimizedGridFiltering6();


                }
            }
            if (comboBoxEdit1.Text == "4")
            {
                if (numbers.Count >= 4)
                {

                    PerformOptimizedGridFiltering();
                    //PerformOptimizedGridFiltering6();


                }
            }
            if (comboBoxEdit1.Text == "5")
            {
                if (numbers.Count >= 5)
                {

                    PerformOptimizedGridFiltering();
                    PerformOptimizedGridFiltering6();
                }
            }
            if (comboBoxEdit1.Text == "6")
            {
                if (numbers.Count >= 6)
                {
                    if (ckdudoan.Checked == true)
                    {
                        gridControl7.DataSource = null;
                        get_moi();
                    }
                    else if (ckdudoan.Checked == false)
                    {
                        PerformOptimizedGridFiltering();
                    }


                }
            }
            if (comboBoxEdit1.Text == "8")
            {
                if (numbers.Count >= 8)
                {

                    PerformOptimizedGridFiltering();
                    PerformOptimizedGridFiltering6();
                }
            }
            if (comboBoxEdit1.Text == "9")
            {
                if (numbers.Count >= 9)
                {

                    PerformOptimizedGridFiltering();
                    //PerformOptimizedGridFiltering6();


                }
            }
            if (comboBoxEdit1.Text == "10")
            {
                if (numbers.Count >= 10)
                {
                    if (ckdudoan.Checked == true)
                    {
                        gridControl7.DataSource = null;
                        get_moi();
                    }
                    else if (ckdudoan.Checked == false)
                    {
                        PerformOptimizedGridFiltering();
                    }


                }
            }
            if (comboBoxEdit1.Text == "11")
            {
                if (numbers.Count >= 11)
                {

                    PerformOptimizedGridFiltering(); PerformOptimizedGridFiltering6();


                }
            }
            if (comboBoxEdit1.Text == "12")
            {
                if (numbers.Count >= 12)
                {

                    PerformOptimizedGridFiltering(); PerformOptimizedGridFiltering6();


                }
            }
            if (comboBoxEdit1.Text == "13")
            {
                if (numbers.Count >= 13)
                {

                    PerformOptimizedGridFiltering(); PerformOptimizedGridFiltering6();


                }
            }
            if (comboBoxEdit1.Text == "14")
            {
                if (numbers.Count >= 14)
                {

                    PerformOptimizedGridFiltering(); PerformOptimizedGridFiltering6();


                }
            }
            if (comboBoxEdit1.Text == "15")
            {
                if (numbers.Count >= 15 )
                {

                    PerformOptimizedGridFiltering();
                    PerformOptimizedGridFiltering6();

                }
            }
            if (comboBoxEdit1.Text == "16")
            {
                if (numbers.Count >= 16 )
                {

                    PerformOptimizedGridFiltering();
                    PerformOptimizedGridFiltering6();


                }
            }
            if (comboBoxEdit1.Text == "17")
            { 
                    if (numbers.Count >= 17 )
                    {

                        PerformOptimizedGridFiltering(); PerformOptimizedGridFiltering6();



                        }
            }
            if (comboBoxEdit1.Text == "18")
            {
                if (numbers.Count >= 18 )
                {

                    PerformOptimizedGridFiltering();
                    PerformOptimizedGridFiltering6();


                }
            }
            if (comboBoxEdit1.Text == "19")
            {
                if (numbers.Count >= 19)
                {

                    PerformOptimizedGridFiltering();
                    PerformOptimizedGridFiltering6();


                }
            }
            if (comboBoxEdit1.Text == "21")
            {
                if (numbers.Count >= 21)
                //{
                //    if (ckdudoan.Checked == true)
                //    {
                //        gridControl7.DataSource = null;
                //        get_moi();
                //    }
                //    else if (ckdudoan.Checked == false)
                //    {
                        PerformOptimizedGridFiltering();
                        PerformOptimizedGridFiltering6();
                    //}


                //}
               
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
            if (e.Column.FieldName == "SS10")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS10"));
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


            //if (e.Column.FieldName == "SS9")
            //{
            //    int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS9"));
            //    if (VALUE <= 10)
            //    {
            //        e.Appearance.BackColor = Color.LightYellow;
            //    }
            //    else if (VALUE > 10)
            //    {
            //        e.Appearance.BackColor = Color.Pink;
            //    }
            //    else { e.Appearance.BackColor = Color.Aqua; }
            //}
            //if (e.Column.FieldName == "SS10")
            //{
            //    string value = view.GetRowCellValue(e.RowHandle, "SS10")?.ToString();
            //    if (value.Contains("X"))
            //    {
            //        e.Appearance.BackColor = System.Drawing.Color.LightYellow;
            //    }
            //    else if (value.Contains("T"))
            //    {
            //        e.Appearance.BackColor = System.Drawing.Color.Pink;
            //    }
            //    else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            //}

        }
        private void gridView5_RowCellStyle_1(object sender, RowCellStyleEventArgs e)
        {
        }

        private void gridView5_CustomDrawCell_1(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            // 1. Thêm cột "SS10" vào điều kiện kiểm tra cột
            if (e.Column.FieldName == "DATA")
            {
                string cellValue = e.CellValue as string;

                if (string.IsNullOrEmpty(cellValue))
                {
                    return; // Dừng nếu giá trị rỗng
                }

                // --- Xử lý riêng cho cột "SS10" ---
                if (e.Column.FieldName == "SS101")
                {
                    // Tách các giá trị số trong chuỗi (ví dụ: "9,16,10")
                    string[] values = cellValue.Split(',');
                    float currentX = e.Bounds.X;
                    Font boldFont = new Font(e.Appearance.Font, FontStyle.Bold);

                    e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                    foreach (string value in values)
                    {
                        // Cố gắng chuyển giá trị thành số nguyên
                        if (int.TryParse(value.Trim(), out int number))
                        {
                            Color charColor;

                            // Áp dụng logic màu sắc: >10 màu đỏ, <=10 màu xanh
                            if (number > 10)
                            {
                                charColor = Color.Red; // Màu đỏ nếu > 10
                            }
                            else
                            {
                                charColor = Color.Green; // Màu xanh lá nếu <= 10
                            }

                            using (SolidBrush brush = new SolidBrush(charColor))
                            {
                                string displayedValue = value.Trim();
                                SizeF charSize = e.Graphics.MeasureString(displayedValue, boldFont);

                                // Vẽ giá trị số
                                e.Graphics.DrawString(displayedValue, boldFont, brush,
                                    new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - charSize.Height) / 2));

                                currentX += charSize.Width + 5; // Cập nhật vị trí X, thêm khoảng cách 5 pixel
                            }
                        }
                    }

                    boldFont.Dispose();
                    e.Handled = true;
                    return; // Dừng xử lý sau khi vẽ cột SS10
                }

                // --- Logic cũ cho cột "DATA" và "SS9" (chỉ lấy 5 ký tự cuối và tô màu X/T) ---
                else if (e.Column.FieldName == "DATA" || e.Column.FieldName == "SS9")
                {
                    e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                    // Lấy 5 ký tự cuối cùng của chuỗi
                    string displayedValue = cellValue;
                    if (cellValue.Length > 5)
                    {
                        displayedValue = cellValue.Substring(cellValue.Length - 5);
                    }

                    float currentX = e.Bounds.X;
                    Font boldFont = new Font(e.Appearance.Font, FontStyle.Bold);

                    // Chia chuỗi hiển thị thành các ký tự
                    char[] chars = displayedValue.ToCharArray();

                    foreach (char character in chars)
                    {
                        string charString = character.ToString();

                        // Xác định màu dựa trên logic "X" và "T"
                        Color charColor;
                        if (charString == "X")
                        {
                            charColor = Color.Blue;
                        }
                        else if (charString == "T")
                        {
                            charColor = Color.Maroon;
                        }
                        else
                        {
                            charColor = e.Appearance.ForeColor;
                        }

                        using (SolidBrush brush = new SolidBrush(charColor))
                        {
                            SizeF charSize = e.Graphics.MeasureString(charString, boldFont);

                            // Vẽ ký tự
                            e.Graphics.DrawString(charString, boldFont, brush,
                                new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - charSize.Height) / 2));

                            currentX += charSize.Width; // Cập nhật vị trí X cho ký tự tiếp theo
                        }
                    }

                    boldFont.Dispose();
                    e.Handled = true;
                }
            }
        }

        private int CountFilteredCharacters()
        {
            // Lấy chuỗi lọc hoàn chỉnh từ GridView
            string filterString = gridView8.ActiveFilterString;

            // Kiểm tra nếu không có bộ lọc nào được áp dụng
            if (string.IsNullOrEmpty(filterString))
            {
                return 0;
            }

            // Tách chuỗi để lấy phần dữ liệu
            int startIndex = filterString.IndexOf("'") + 1;
            int endIndex = filterString.LastIndexOf("'");

            if (startIndex > 0 && endIndex > startIndex)
            {
                string dataPart = filterString.Substring(startIndex, endIndex - startIndex);

                // Loại bỏ dấu '%' nếu có
                string cleanString = dataPart.TrimStart('%');

                // **Phần quan trọng:** Tách chuỗi thành một mảng các phần tử và đếm số lượng
                // Tùy chọn StringSplitOptions.RemoveEmptyEntries để bỏ qua các phần tử rỗng
                string[] elements = cleanString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                int count = elements.Length;
                return count;
            }

            return 0;
        }
        int clickCount_W = 0;
        int clickCount_L = 0;
        private void xoa1()
        {
            // 1. Lấy giá trị hiện tại từ dòng lọc tự động
            object filterValue = gridView8.GetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "DATA");

            if (filterValue is string filterString && !string.IsNullOrWhiteSpace(filterString))
            {
                // Loại bỏ dấu % ở đầu nếu có để xử lý chuỗi sạch
                string cleanString = filterString.TrimStart('%');

                // 2. Tách chuỗi thành danh sách các phần tử
                List<string> parts = cleanString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(p => p.Trim())
                                                .ToList();

                if (parts.Count > 1)
                {
                    // 3. Xóa phần tử đầu tiên
                    parts.RemoveAt(0);

                    // 4. Nối lại thành chuỗi mới và THÊM DẤU % Ở ĐẦU
                    string newFilterString = "%" + string.Join(",", parts);

                    // 5. Cập nhật lại GridView
                    gridView8.SetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "DATA", newFilterString);
                }
                else
                {
                    // Nếu chỉ còn 1 phần tử hoặc chuỗi rỗng sau khi xóa, làm trống ô lọc
                    gridView8.SetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, "DATA", string.Empty);
                }
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
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
        private void FormatRichTextBox()
        {
            // Lấy chuỗi từ RichTextBox
            string text = richTextBox2.Text;

            // Tắt cập nhật giao diện để tránh nhấp nháy
            richTextBox2.SuspendLayout();

            // Xóa tất cả định dạng cũ
            richTextBox2.SelectAll();
            richTextBox2.SelectionColor = System.Drawing.Color.Black;

            // Tách chuỗi thành các phần tử (số hoặc ký tự)
            string[] elements = text.Split(',');

            int currentPosition = 0;
            foreach (string element in elements)
            {
                // Loại bỏ khoảng trắng
                string trimmedElement = element.Trim();

                if (!string.IsNullOrEmpty(trimmedElement))
                {
                    // Mặc định là màu đỏ sẫm cho ký tự T và số > 10
                    System.Drawing.Color color = System.Drawing.Color.Maroon;

                    // Kiểm tra xem phần tử có phải là số không
                    if (int.TryParse(trimmedElement, out int number))
                    {
                        // Nếu là số và <= 10, đặt màu xanh lam
                        if (number <= 10)
                        {
                            color = System.Drawing.Color.Blue;
                        }
                    }
                    // Nếu phần tử không phải số, kiểm tra xem có phải là 'X' không
                    else if (trimmedElement.Equals("X", StringComparison.OrdinalIgnoreCase))
                    {
                        // Nếu là 'X', đặt màu xanh lam
                        color = System.Drawing.Color.Blue;
                    }

                    // Chọn phần văn bản và tô màu
                    richTextBox2.Select(currentPosition, trimmedElement.Length);
                    richTextBox2.SelectionColor = color;
                }

                // Cập nhật vị trí cho phần tử tiếp theo (bao gồm dấu phẩy và khoảng trắng)
                currentPosition += element.Length + 1;
            }

            // Bật lại cập nhật giao diện và đặt con trỏ về cuối
            richTextBox2.ResumeLayout();
            richTextBox2.SelectionStart = richTextBox2.Text.Length;
            richTextBox2.SelectionLength = 0;
        }
       
        private void FormatRichTextBox3()
        {
            // Lấy chuỗi từ RichTextBox
            string text = richTextBox3.Text;

            // Tắt cập nhật giao diện để tránh nhấp nháy
            richTextBox3.SuspendLayout();

            // Xóa tất cả định dạng cũ
            richTextBox3.SelectAll();
            richTextBox3.SelectionColor = System.Drawing.Color.Black;

            // Tách chuỗi thành các phần tử (số hoặc ký tự)
            string[] elements = text.Split(',');

            int currentPosition = 0;
            foreach (string element in elements)
            {
                // Loại bỏ khoảng trắng
                string trimmedElement = element.Trim();

                if (!string.IsNullOrEmpty(trimmedElement))
                {
                    // Mặc định là màu đỏ sẫm cho ký tự T và số > 10
                    System.Drawing.Color color = System.Drawing.Color.Maroon;

                    // Kiểm tra xem phần tử có phải là số không
                    if (int.TryParse(trimmedElement, out int number))
                    {
                        // Nếu là số và <= 10, đặt màu xanh lam
                        if (number <= 10)
                        {
                            color = System.Drawing.Color.Blue;
                        }
                    }
                    // Nếu phần tử không phải số, kiểm tra xem có phải là 'X' không
                    else if (trimmedElement.Equals("X", StringComparison.OrdinalIgnoreCase))
                    {
                        // Nếu là 'X', đặt màu xanh lam
                        color = System.Drawing.Color.Blue;
                    }

                    // Chọn phần văn bản và tô màu
                    richTextBox3.Select(currentPosition, trimmedElement.Length);
                    richTextBox3.SelectionColor = color;
                }

                // Cập nhật vị trí cho phần tử tiếp theo (bao gồm dấu phẩy và khoảng trắng)
                currentPosition += element.Length + 1;
            }

            // Bật lại cập nhật giao diện và đặt con trỏ về cuối
            richTextBox3.ResumeLayout();
            richTextBox3.SelectionStart = richTextBox3.Text.Length;
            richTextBox3.SelectionLength = 0;
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
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            FormatRichTextBox();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_sid();
        }
       
        private void simpleButton20_Click(object sender, EventArgs e)
        {
            clickCount_W++;
            lb_w.Text = clickCount_W.ToString();
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {


            clickCount_L++;
            lb_l.Text = clickCount_L.ToString();
            //string fullString = txtInput.Text;
            //string[] numbers = fullString.Split(',');
            //string lastTwoNumbers = numbers[numbers.Length - 2] + "," + numbers[numbers.Length - 1];
            //string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            //DateTime ngayTaoHienTai = DateTime.Now;
            //InsertIntoDatabase_VITRI(connectionString, 0, Convert.ToInt32(labelCount.Text), ngayTaoHienTai, lastTwoNumbers);
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            clickCount_W = 0; clickCount_L = 0;
            lb_w.Text = clickCount_W.ToString(); ;
            lb_l.Text = clickCount_L.ToString(); ;
        }

     

        private void gridView5_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "DATA" || e.Column.FieldName == "SS9")
            {
                string ketQuaValue = e.CellValue as string;

                if (!string.IsNullOrEmpty(ketQuaValue))
                {
                    e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                    // Lấy 5 ký tự cuối cùng của chuỗi
                    string displayedValue = ketQuaValue;
                    if (ketQuaValue.Length >=18)
                    {
                        displayedValue = ketQuaValue.Substring(ketQuaValue.Length - 10);
                    }

                    float currentX = e.Bounds.X;
                    float charWidth;

                    Font boldFont = new Font(e.Appearance.Font, FontStyle.Bold);

                    // Chia chuỗi hiển thị thành các ký tự
                    char[] chars = displayedValue.ToCharArray();

                    foreach (char character in chars)
                    {
                        string charString = character.ToString();

                        // Xác định màu dựa trên logic "X" và "T"
                        Color charColor;
                        if (charString == "X") // Giả sử "X" là ký tự
                        {
                            charColor = Color.Blue; // Màu xanh lam cho X
                        }
                        else if (charString == "T") // Giả sử "T" là ký tự
                        {
                            charColor = Color.Maroon; // Màu đỏ sẫm cho T
                        }
                        else
                        {
                            charColor = e.Appearance.ForeColor; // Giữ màu mặc định cho các ký tự khác
                        }

                        using (SolidBrush brush = new SolidBrush(charColor))
                        {
                            SizeF charSize = e.Graphics.MeasureString(charString, boldFont);

                            // Vẽ ký tự
                            e.Graphics.DrawString(charString, boldFont, brush,
                                new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - charSize.Height) / 2));

                            charWidth = charSize.Width;
                            currentX += charWidth; // Cập nhật vị trí X cho ký tự tiếp theo
                        }
                    }

                    boldFont.Dispose();
                    e.Handled = true;
                }
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            FormatRichTextBox3();
        }

        private void gridControl5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton7_Click_2(object sender, EventArgs e)
        {
            //xoa_23();
            // Lấy nội dung hiện tại của RichTextBox (giả sử tên là richTextBox1)
            string currentText = txtInput.Text;

            // Kiểm tra xem chuỗi có nội dung và có dấu phẩy nào không
            if (!string.IsNullOrEmpty(currentText))
            {
                // 1. Tìm vị trí của dấu phẩy cuối cùng
                int lastCommaIndex = currentText.LastIndexOf(',');

                // 2. Nếu tìm thấy dấu phẩy, tiến hành cắt chuỗi
                if (lastCommaIndex >= 0)
                {
                    // Cắt chuỗi từ đầu đến vị trí dấu phẩy cuối cùng (không bao gồm dấu phẩy đó)
                    string newText = currentText.Substring(0, lastCommaIndex);

                    // Gán lại nội dung đã cắt vào RichTextBox
                    txtInput.Text = newText;
                }
                else
                {
                    // Xử lý trường hợp chỉ còn 1 số hoặc không có dấu phẩy nào
                    // Nếu bạn muốn xóa toàn bộ chuỗi nếu chỉ còn 1 số, bạn có thể đặt:
                    // richTextBox1.Text = string.Empty;
                    // Hoặc để nguyên:
                    // MessageBox.Show("Chuỗi chỉ còn một phần tử hoặc không có dấu phẩy.");
                }
            }
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
            richTextBox2.Text = string.Empty;
        }

        private void simpleButton11_Click_1(object sender, EventArgs e)
        {
            AddNumberToInputAsync("11");    // Thêm số vào txtInput
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            AddNumberToInputAsync("10");    // Thêm số vào txtInput
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
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

        private void ck_so_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_so.Checked == true)
            {
                dockManager1.ActivePanel = dockPanel3;
            }

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = richTextBox4.SelectionStart;

            // Chuyển toàn bộ văn bản thành chữ hoa
            richTextBox4.Text = richTextBox4.Text.ToUpper();
            // Phục hồi vị trí con trỏ
            richTextBox4.SelectionStart = cursorPosition;
            UpdateRichTextBoxColors4();
            FilterGridCombined(richTextBox4.Text, richTextBox2.Text);
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {

            //AddNumberToInputAsync("11");    // Thêm số vào txtInput
            cborow.Text = "1";
        }

        private void simpleButton13_Click_1(object sender, EventArgs e)
        {

            //AddNumberToInputAsync("10");    // Thêm số vào txtInput
            //////
            ////xoa1();
            ///
            cborow.Text = "2";
        }

        private void labelCount1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            clickCount_W = 0; clickCount_L = 0;
            lb_w.Text = clickCount_W.ToString(); ;
            lb_l.Text = clickCount_L.ToString(); ;
            //xoa1();
        }

        private void gridView3_CustomDrawCell_1(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "DATA" || e.Column.FieldName == "SS9")
            {
                string ketQuaValue = e.CellValue as string;

                if (!string.IsNullOrEmpty(ketQuaValue))
                {
                    e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                    // Lấy 5 ký tự cuối cùng của chuỗi
                    string displayedValue = ketQuaValue;
                    if (ketQuaValue.Length >= 18)
                    {
                        displayedValue = ketQuaValue.Substring(ketQuaValue.Length - 10);
                    }

                    float currentX = e.Bounds.X;
                    float charWidth;

                    Font boldFont = new Font(e.Appearance.Font, FontStyle.Bold);

                    // Chia chuỗi hiển thị thành các ký tự
                    char[] chars = displayedValue.ToCharArray();

                    foreach (char character in chars)
                    {
                        string charString = character.ToString();

                        // Xác định màu dựa trên logic "X" và "T"
                        Color charColor;
                        if (charString == "X") // Giả sử "X" là ký tự
                        {
                            charColor = Color.Blue; // Màu xanh lam cho X
                        }
                        else if (charString == "T") // Giả sử "T" là ký tự
                        {
                            charColor = Color.Maroon; // Màu đỏ sẫm cho T
                        }
                        else
                        {
                            charColor = e.Appearance.ForeColor; // Giữ màu mặc định cho các ký tự khác
                        }

                        using (SolidBrush brush = new SolidBrush(charColor))
                        {
                            SizeF charSize = e.Graphics.MeasureString(charString, boldFont);

                            // Vẽ ký tự
                            e.Graphics.DrawString(charString, boldFont, brush,
                                new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - charSize.Height) / 2));

                            charWidth = charSize.Width;
                            currentX += charWidth; // Cập nhật vị trí X cho ký tự tiếp theo
                        }
                    }

                    boldFont.Dispose();
                    e.Handled = true;
                }
            }
        }

        private void gridView3_RowCellStyle_1(object sender, RowCellStyleEventArgs e)
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
            //if (e.Column.FieldName == "SS10")
            //{
            //    int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS10"));
            //    if (VALUE <= 10)
            //    {
            //        e.Appearance.BackColor = Color.LightYellow;
            //    }
            //    else if (VALUE > 10)
            //    {
            //        e.Appearance.BackColor = Color.Pink;
            //    }
            //    else { e.Appearance.BackColor = Color.Aqua; }
            //}
            //if (e.Column.FieldName == "SS11")
            //{
            //    int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS11"));
            //    if (VALUE <= 10)
            //    {
            //        e.Appearance.BackColor = Color.LightYellow;
            //    }
            //    else if (VALUE > 10)
            //    {
            //        e.Appearance.BackColor = Color.Pink;
            //    }
            //    else { e.Appearance.BackColor = Color.Aqua; }
            //}
            if (e.Column.FieldName == "SS8")
            {
                string value = view.GetRowCellValue(e.RowHandle, "SS8")?.ToString();
                if (value.Contains("X"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (value.Contains("T"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }
            if (e.Column.FieldName == "SS9")
            {
                string value = view.GetRowCellValue(e.RowHandle, "SS9")?.ToString();
                if (value.Contains("X"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (value.Contains("T"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }
            if (e.Column.FieldName == "SS10")
            {
                string value = view.GetRowCellValue(e.RowHandle, "SS10")?.ToString();
                if (value.Contains("X"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (value.Contains("T"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }


            if (e.Column.FieldName == "SS8_C")
            {
                string value = view.GetRowCellValue(e.RowHandle, "SS8_C")?.ToString();
                if (value.Contains("X"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (value.Contains("T"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }
            if (e.Column.FieldName == "SS8_C")
            {
                string value = view.GetRowCellValue(e.RowHandle, "SS8_C")?.ToString();
                if (value.Contains("X"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (value.Contains("T"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }
            if (e.Column.FieldName == "SS8_C")
            {
                string value = view.GetRowCellValue(e.RowHandle, "SS8_C")?.ToString();
                if (value.Contains("X"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (value.Contains("T"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }
            if (e.Column.FieldName == "PredictedTX")
            {
                string value = view.GetRowCellValue(e.RowHandle, "PredictedTX")?.ToString();
                if (value.Contains("X"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (value.Contains("T"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.Pink;
                }
                else { e.Appearance.BackColor = System.Drawing.Color.Aqua; }
            }

            if (e.Column.FieldName == "SS8_S")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS8_S"));
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
            if (e.Column.FieldName == "SS9_S")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS9_S"));
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
            if (e.Column.FieldName == "SS10_S")
            {
                int VALUE = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "SS10_S"));
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

        private void gridView8_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "DATA")
            {
                string ketQuaValue = e.CellValue as string;

                if (!string.IsNullOrEmpty(ketQuaValue))
                {
                    e.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                    // Lấy 5 ký tự cuối cùng của chuỗi
                    string displayedValue = ketQuaValue;
                    if (ketQuaValue.Length >= 18)
                    {
                        displayedValue = ketQuaValue.Substring(ketQuaValue.Length - 10);
                    }

                    float currentX = e.Bounds.X;
                    float charWidth;

                    Font boldFont = new Font(e.Appearance.Font, FontStyle.Bold);

                    // Chia chuỗi hiển thị thành các ký tự
                    char[] chars = displayedValue.ToCharArray();

                    foreach (char character in chars)
                    {
                        string charString = character.ToString();

                        // Xác định màu dựa trên logic "X" và "T"
                        Color charColor;
                        if (charString == "X") // Giả sử "X" là ký tự
                        {
                            charColor = Color.Blue; // Màu xanh lam cho X
                        }
                        else if (charString == "T") // Giả sử "T" là ký tự
                        {
                            charColor = Color.Maroon; // Màu đỏ sẫm cho T
                        }
                        else
                        {
                            charColor = e.Appearance.ForeColor; // Giữ màu mặc định cho các ký tự khác
                        }

                        using (SolidBrush brush = new SolidBrush(charColor))
                        {
                            SizeF charSize = e.Graphics.MeasureString(charString, boldFont);

                            // Vẽ ký tự
                            e.Graphics.DrawString(charString, boldFont, brush,
                                new PointF(currentX, e.Bounds.Y + (e.Bounds.Height - charSize.Height) / 2));

                            charWidth = charSize.Width;
                            currentX += charWidth; // Cập nhật vị trí X cho ký tự tiếp theo
                        }
                    }

                    boldFont.Dispose();
                    e.Handled = true;
                }
            }
        }

        private void lb_w_Click(object sender, EventArgs e)
        {

        }

        private void lb_l_Click(object sender, EventArgs e)
        {

        }

        private void gridView5_RowCellStyle_2(object sender, RowCellStyleEventArgs e)
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

        private void btn10_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn10.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn9.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn8.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn7.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn6.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn5.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn4.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn3.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn15_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn15.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn12_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn12.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn13_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn13.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn14_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn14.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn11_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn11.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn16_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn16.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn17_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn17.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void btn18_Click_1(object sender, EventArgs e)
        {
            string clickedNumber = btn18.Text; // Lấy số từ nút được click
            AddNumberToInputAsync(clickedNumber);    // Thêm số vào txtInput
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            int countBefore = previousLabelCount3;
            AddNumberToInputAsync("11");
            System.Windows.Forms.Application.DoEvents();

            int countAfter = 0;
            if (int.TryParse(labelControl3.Text, out int parsedAfter))
            {
                countAfter = parsedAfter;
            }

            int change = countAfter - countBefore;

            if (change == 1)
            {
                gridColumn27.Visible = true;
            }
            else
            {
                gridColumn27.Visible = false;
            }
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            int countBefore = previousLabelCount3;
            AddNumberToInputAsync("10");
            System.Windows.Forms.Application.DoEvents();

            int countAfter = 0;
            if (int.TryParse(labelControl3.Text, out int parsedAfter))
            {
                countAfter = parsedAfter;
            }

            int change = countAfter - countBefore;

            if (change == 1)
            {
                gridColumn27.Visible = true;
            }
            else
            {
                gridColumn27.Visible = false;
            }
        }
    }
}
