
namespace KIEMSOAT_RAVAO
{
    partial class QR_CDEO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_CDEO));
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator4 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator3 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator2 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.eHospital_NinhThuanDataSet1 = new KIEMSOAT_RAVAO.eHospital_NinhThuanDataSet();
            this.parameter1 = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameter2 = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameter3 = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameter4 = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameter5 = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameter6 = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrBarCode2 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrBarCode3 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrBarCode4 = new DevExpress.XtraReports.UI.XRBarCode();
            ((System.ComponentModel.ISupportInitialize)(this.eHospital_NinhThuanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 19.79167F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // eHospital_NinhThuanDataSet1
            // 
            this.eHospital_NinhThuanDataSet1.DataSetName = "eHospital_NinhThuanDataSet";
            this.eHospital_NinhThuanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parameter1
            // 
            this.parameter1.Name = "parameter1";
            // 
            // parameter2
            // 
            this.parameter2.Name = "parameter2";
            // 
            // parameter3
            // 
            this.parameter3.Name = "parameter3";
            // 
            // parameter4
            // 
            this.parameter4.Name = "parameter4";
            // 
            // parameter5
            // 
            this.parameter5.Name = "parameter5";
            // 
            // parameter6
            // 
            this.parameter6.Name = "parameter6";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "cn";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "QR";
            queryParameter1.Name = "@P1";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?parameter1", typeof(string));
            queryParameter2.Name = "@P2";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?parameter2", typeof(string));
            queryParameter3.Name = "@P3";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?parameter3", typeof(string));
            queryParameter4.Name = "@P4";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?parameter4", typeof(string));
            queryParameter5.Name = "@P5";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?parameter5", typeof(string));
            queryParameter6.Name = "@P6";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("?parameter6", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.Parameters.Add(queryParameter6);
            storedProcQuery1.StoredProcName = "QR";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode4,
            this.xrBarCode3,
            this.xrBarCode2,
            this.xrBarCode1});
            this.ReportHeader.HeightF = 709.375F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.Name = "PageFooter";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_1]")});
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(30.91666F, 45.83335F);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode1.ShowText = false;
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(315.625F, 320.8333F);
            qrCodeGenerator4.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator4.Logo = new DevExpress.XtraPrinting.Drawing.ImageSource(global::KIEMSOAT_RAVAO.Properties.Resources.screenshot_1709005584, true);
            this.xrBarCode1.Symbology = qrCodeGenerator4;
            // 
            // xrBarCode2
            // 
            this.xrBarCode2.AutoModule = true;
            this.xrBarCode2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_2]")});
            this.xrBarCode2.LocationFloat = new DevExpress.Utils.PointFloat(386.75F, 45.83337F);
            this.xrBarCode2.Name = "xrBarCode2";
            this.xrBarCode2.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode2.SizeF = new System.Drawing.SizeF(315.625F, 320.8333F);
            qrCodeGenerator3.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator3.Logo = new DevExpress.XtraPrinting.Drawing.ImageSource(global::KIEMSOAT_RAVAO.Properties.Resources.screenshot_1709005584, true);
            this.xrBarCode2.Symbology = qrCodeGenerator3;
            // 
            // xrBarCode3
            // 
            this.xrBarCode3.AutoModule = true;
            this.xrBarCode3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_3]")});
            this.xrBarCode3.LocationFloat = new DevExpress.Utils.PointFloat(30.91666F, 388.5417F);
            this.xrBarCode3.Name = "xrBarCode3";
            this.xrBarCode3.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode3.SizeF = new System.Drawing.SizeF(315.625F, 320.8333F);
            qrCodeGenerator2.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator2.Logo = new DevExpress.XtraPrinting.Drawing.ImageSource(global::KIEMSOAT_RAVAO.Properties.Resources.screenshot_1709005584, true);
            this.xrBarCode3.Symbology = qrCodeGenerator2;
            // 
            // xrBarCode4
            // 
            this.xrBarCode4.AutoModule = true;
            this.xrBarCode4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_4]")});
            this.xrBarCode4.LocationFloat = new DevExpress.Utils.PointFloat(386.75F, 388.5417F);
            this.xrBarCode4.Name = "xrBarCode4";
            this.xrBarCode4.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode4.SizeF = new System.Drawing.SizeF(315.625F, 320.8333F);
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator1.Logo = new DevExpress.XtraPrinting.Drawing.ImageSource(global::KIEMSOAT_RAVAO.Properties.Resources.screenshot_1709005584, true);
            this.xrBarCode4.Symbology = qrCodeGenerator1;
            // 
            // QR_CDEO
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.eHospital_NinhThuanDataSet1,
            this.sqlDataSource1});
            this.DataMember = "QR";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(42, 46, 20, 100);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.parameter1,
            this.parameter2,
            this.parameter3,
            this.parameter4,
            this.parameter5,
            this.parameter6});
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.eHospital_NinhThuanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private eHospital_NinhThuanDataSet eHospital_NinhThuanDataSet1;
        private DevExpress.XtraReports.Parameters.Parameter parameter1;
        private DevExpress.XtraReports.Parameters.Parameter parameter2;
        private DevExpress.XtraReports.Parameters.Parameter parameter3;
        private DevExpress.XtraReports.Parameters.Parameter parameter4;
        private DevExpress.XtraReports.Parameters.Parameter parameter5;
        private DevExpress.XtraReports.Parameters.Parameter parameter6;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode4;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode3;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode2;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
    }
}
