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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using Oracle.ManagedDataAccess.Client;
using System.IO;

namespace KIEMSOAT_RAVAO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void get_khoa()
        {
            OracleConnection conn = ConfigKetNoi.GetDBConnection();
            conn.Open();
            string sql = @"SELECT ID,DEPARTMENT_NAME FROM HIS_RS.HIS_DEPARTMENT";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            grid_khoa.Properties.DataSource = ds.Tables[0];
            grid_khoa.Properties.DisplayMember = "DEPARTMENT_NAME";
            grid_khoa.Properties.ValueMember = "ID";
            conn.Close();

        }
        private void fill_bn()
        {
            
            string sql = @"select BA.ID
            ,VIR_PATIENT_NAME
            ,TREATMENT_CODE AS MADT
			,PATIENT_CODE AS MABN
            from HIS_RS.HIS_TREATMENT BA
            join HIS_RS.HIS_DEPARTMENT KhoaDT on KhoaDT.ID = BA.LAST_DEPARTMENT_ID
            JOIN HIS_RS.HIS_PATIENT BN ON BN.ID = BA.PATIENT_ID
            where  TDL_TREATMENT_TYPE_ID in (2,3,4)  
                    AND BA.IS_ACTIVE =1
                    and KhoaDT.ID =" + grid_khoa.EditValue;
            OracleConnection conn = ConfigKetNoi.GetDBConnection();
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            grid_tenbn.Properties.DataSource = ds.Tables[0];
            grid_tenbn.Properties.DisplayMember = "VIR_PATIENT_NAME";
            grid_tenbn.Properties.ValueMember = "ID";

            grid_tenbn1.Properties.DataSource = ds.Tables[0];
            grid_tenbn1.Properties.DisplayMember = "VIR_PATIENT_NAME";
            grid_tenbn1.Properties.ValueMember = "ID";

            grid_tenbn2.Properties.DataSource = ds.Tables[0];
            grid_tenbn2.Properties.DisplayMember = "VIR_PATIENT_NAME";
            grid_tenbn2.Properties.ValueMember = "ID";

            grid_tenbn3.Properties.DataSource = ds.Tables[0];
            grid_tenbn3.Properties.DisplayMember = "VIR_PATIENT_NAME";
            grid_tenbn3.Properties.ValueMember = "ID";
            conn.Close();
           
        }
      
        private void capthe()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            SqlCommand com = new SqlCommand("INS_THENUOIBENH_4", con);
            //com.Parameters.AddWithValue("@MaChamCong", cb_user.Value);
            com.Parameters.AddWithValue("@TREATMENT_ID", grid_tenbn.EditValue);
            com.Parameters.AddWithValue("@TREATMENT_ID1", grid_tenbn1.EditValue);
            com.Parameters.AddWithValue("@TREATMENT_ID2", grid_tenbn2.EditValue);
            com.Parameters.AddWithValue("@TREATMENT_ID3", grid_tenbn3.EditValue);

            com.Parameters.AddWithValue("@TENBN",grid_tenbn.Text);
            com.Parameters.AddWithValue("@TENBN1", grid_tenbn1.Text);
            com.Parameters.AddWithValue("@TENBN2", grid_tenbn2.Text);
            com.Parameters.AddWithValue("@TENBN3", grid_tenbn3.Text);

            com.Parameters.AddWithValue("@NGUOI_NUOI", txt_nguoinuoi.Text);
            com.Parameters.AddWithValue("@NGUOI_NUOI1", txt_nguoinuoi1.Text);
            com.Parameters.AddWithValue("@NGUOI_NUOI2", txt_nguoinuoi2.Text);
            com.Parameters.AddWithValue("@NGUOI_NUOI3", txt_nguoinuoi3.Text);
            com.Parameters.AddWithValue("@CMND", txtcmnd.Text);
            com.Parameters.AddWithValue("@CMND1", txtcmnd_1.Text);
            com.Parameters.AddWithValue("@CMND2", txtcmnd_2.Text);
            com.Parameters.AddWithValue("@CMND3", txtcmnd3.Text);
            com.Parameters.AddWithValue("@KHOADT", grid_khoa.Text);
            if (pb.Image == null)
            {
                com.Parameters.Add(new SqlParameter("@Image", SqlDbType.Image)).Value = null;
            }
            else
            {
                com.Parameters.Add(new SqlParameter("@Image", SqlDbType.Image)).Value = ConvertImageToBinary(pb.Image);
            }
            if (pb1.Image == null)
            {
                com.Parameters.Add(new SqlParameter("@Image1", SqlDbType.Image)).Value = null;
            }
            else
            {
                com.Parameters.Add(new SqlParameter("@Image1", SqlDbType.Image)).Value = ConvertImageToBinary(pb1.Image);
            }


            if (pb2.Image == null)
            {
                com.Parameters.Add(new SqlParameter("@Image2", SqlDbType.Image)).Value = null;
            }
            else
            {
                com.Parameters.Add(new SqlParameter("@Image2", SqlDbType.Image)).Value = ConvertImageToBinary(pb2.Image);
            }


            if (pb3.Image == null)
            {
                com.Parameters.Add(new SqlParameter("@Image3", SqlDbType.Image)).Value = null;
            }
            else
            {
                com.Parameters.Add(new SqlParameter("@Image3", SqlDbType.Image)).Value = ConvertImageToBinary(pb3.Image);
            }
            com.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                //command.CommandTimeout = 0;
                com.ExecuteNonQuery();
                MessageBox.Show("CẤP THẺ THÀNH CÔNG","THÔNG BÁO", MessageBoxButtons.OK);
                string the = com.Parameters["@id"].Value.ToString(); 
                txt_id.Text = the;
                IN_THE1 report = new IN_THE1();
                report.Parameters["parameter0"].Value = txt_id.Text;
                report.ShowPrintMarginsWarning = false;
                report.Parameters["parameter0"].Visible = false;
                report.ShowPreview();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            get_khoa();
            grid_khoa.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            grid_khoa.Properties.ImmediatePopup = true;
            grid_khoa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            grid_tenbn.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            grid_tenbn.Properties.ImmediatePopup = true;
            grid_tenbn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            grid_tenbn1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            grid_tenbn1.Properties.ImmediatePopup = true;
            grid_tenbn1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            grid_tenbn2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            grid_tenbn2.Properties.ImmediatePopup = true;
            grid_tenbn2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            grid_tenbn3.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            grid_tenbn3.Properties.ImmediatePopup = true;
            grid_tenbn3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void grid_khoa_EditValueChanged(object sender, EventArgs e)
        {
            fill_bn();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            capthe();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtcmnd.Text = ""; txtcmnd_1.Text = ""; txtcmnd_2.Text = ""; txtcmnd3.Text = "";
            txt_nguoinuoi.Text = ""; txt_nguoinuoi1.Text = ""; txt_nguoinuoi2.Text = ""; txt_nguoinuoi3.Text = "";
            grid_tenbn.EditValue = ""; grid_tenbn1.EditValue = ""; grid_tenbn2.EditValue = ""; grid_tenbn3.EditValue = "";
            pb.Image = null; pb1.Image = null; pb2.Image = null; pb3.Image = null;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            IN_THE1 report = new IN_THE1();
            report.Parameters["parameter0"].Value = txt_id.Text;
            report.ShowPrintMarginsWarning = false;
            report.Parameters["parameter0"].Visible = false;
            report.ShowPreview();
        }
        string imgloc = null;
        string imgloc1 = null;
        string imgloc2 = null;
        string imgloc3 = null;
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }
        private void pb3_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dgl = new OpenFileDialog();
                dgl.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|ALL Files (*.*)|*.*";
                dgl.Title = "Chọn File";
                if (dgl.ShowDialog() == DialogResult.OK)
                {
                    imgloc3 = dgl.FileName.ToString();
                    pb3.ImageLocation = imgloc3;

                }
            }
            catch
            {


            }
        }

        private void pb_Click(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog dgl = new OpenFileDialog();
                dgl.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|ALL Files (*.*)|*.*";
                dgl.Title = "Chọn File";
                if (dgl.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dgl.FileName.ToString();
                    pb.ImageLocation = imgloc;

                }
            }
            catch
            {


            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dgl = new OpenFileDialog();
                dgl.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|ALL Files (*.*)|*.*";
                dgl.Title = "Chọn File";
                if (dgl.ShowDialog() == DialogResult.OK)
                {
                    imgloc1 = dgl.FileName.ToString();
                    pb1.ImageLocation = imgloc1;

                }
            }
            catch
            {


            }
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dgl = new OpenFileDialog();
                dgl.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|ALL Files (*.*)|*.*";
                dgl.Title = "Chọn File";
                if (dgl.ShowDialog() == DialogResult.OK)
                {
                    imgloc2 = dgl.FileName.ToString();
                    pb2.ImageLocation = imgloc2;

                }
            }
            catch
            {


            }
        }
    }
}
