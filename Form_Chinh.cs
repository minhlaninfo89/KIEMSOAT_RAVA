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
using System.Xml;
using AutoUpdaterDotNET;

namespace KIEMSOAT_RAVAO
{
    public partial class Form_Chinh : Form
    {
        public Form_Chinh()
        {
            InitializeComponent();
        }
        public static string send_idBS;
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        private void get_user()
        {
            //string sql = @"SELECT * from F_CS_KCB WHERE MACS ='" + toolStrip_macs.Text+"'";
            ////OracleConnection conn = ConfigKetNoi.GetDBConnection();
            ////conn.Open();
            ////OracleCommand cmd = new OracleCommand(sql, conn);
            ////OracleDataReader reader = cmd.ExecuteReader((CommandBehavior.CloseConnection));

            //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sv3"].ConnectionString);
            //cn.Open();
            //SqlCommand command = new SqlCommand(sql,cn);
            //command.Connection = cn;
            //SqlDataReader reader = command.ExecuteReader((CommandBehavior.CloseConnection));

            //while (reader.Read())
            //{
            //    toolStrip_macs.Text = reader["MACS"].ToString();
            //    toolStrip_tencs.Text = reader["TENCS"].ToString();


            //}
            //reader.Close();
            //cn.Close();

        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             Main f = new Main();
            //this.Hide();
            f.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        private void load_xml()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("http://thongke.benhvienninhthuan.vn:89/NangCapPhienBanXML/update_capthe.xml");
            lb_version_web.Text = "Phiên bản mới nhất:" + xmldoc.SelectSingleNode("/item/version").FirstChild.Value;
        }
        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {

            if (args.IsUpdateAvailable)
            {
                DialogResult dialogResult;
                dialogResult =
                        MessageBox.Show(
                            $@"Phần mềm của bạn có phiên bản mới {args.CurrentVersion}. Phiên bản bạn đang sử dụng hiện tại  {args.InstalledVersion}. Bạn có muốn cập nhật phần mềm không?", @"Cập nhật phần mềm",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
                {
                    try
                    {
                        if (AutoUpdater.DownloadUpdate(args))
                        {
                            Application.Exit();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                //MessageBox.Show(@"Phiên bản bạn đang sử dụng đã được cập nhật mới nhất.", @"Cập nhật phần mềm",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Form_Chinh_Load(object sender, EventArgs e)
        {
            load_xml();
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            string version_wf = fvi.FileVersion;
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1, true, true);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            toolStrip_macs.Text = Login.sendtext;
            get_user();
            send_idBS = toolStrip_macs.Text;
            lb_version_wf.Text = "Phiên bản đang sử dụng:" + version_wf;

            if (lb_version_wf.Text != lb_version_web.Text)
            {
                AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
                AutoUpdater.DownloadPath = "update";
                AutoUpdater.Start("http://thongke.benhvienninhthuan.vn:89/NangCapPhienBanXML/update_capthe.xml");

            }


        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void Form_Chinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            N_TX t = new N_TX();
            t.Show();
            this.Hide();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //N_TX_SQL t = new N_TX_SQL();
            //t.Show();
            
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

          
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
    }
}
