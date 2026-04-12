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
using System.Text;

namespace KIEMSOAT_RAVAO
{
    public partial class Login : Form
    {
        public static string sendtext;
        public Login()
        {
            InitializeComponent();
        }
        private void login()
        {
            String sql = "SELECT * FROM F_CS_KCB  where MACS ='" + txtmabs.Text + "'" + "and PASSWORD ='" + txtpass.Text + "'";
            //OracleConnection conn = ConfigKetNoi.GetDBConnection();
            //conn.Open();
            //OracleCommand cmd = new OracleCommand(sql, conn);
            //OracleDataReader reader = cmd.ExecuteReader((CommandBehavior.CloseConnection));

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sv3"].ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand(sql,cn);
            command.Connection = cn;
            SqlDataReader reader = command.ExecuteReader((CommandBehavior.CloseConnection));

            if (reader.Read() == true)
            {
                sendtext = txtmabs.Text;
                FX f = new FX();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng,Vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Text = "";
                //txtmabs.Text = "";
                txtpass.Focus();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                login();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtmabs_TextChanged(object sender, EventArgs e)
        {
            txtpass.Text = txtmabs.Text;
        }

        private void txtmabs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                login();
            }
        }
    }
}
