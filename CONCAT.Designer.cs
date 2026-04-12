namespace KIEMSOAT_RAVAO
{
    partial class CONCAT
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONCAT));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton13 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtInput = new DevExpress.XtraEditors.TextEdit();
            this.btn6 = new DevExpress.XtraEditors.SimpleButton();
            this.btn1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn5 = new DevExpress.XtraEditors.SimpleButton();
            this.btn2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn4 = new DevExpress.XtraEditors.SimpleButton();
            this.btn3 = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.txtInput0 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput0.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControl5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(746, 688);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridControl5
            // 
            this.gridControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl5.Location = new System.Drawing.Point(0, 0);
            this.gridControl5.MainView = this.gridView5;
            this.gridControl5.Name = "gridControl5";
            this.gridControl5.Size = new System.Drawing.Size(746, 403);
            this.gridControl5.TabIndex = 4;
            this.gridControl5.UseEmbeddedNavigator = true;
            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.gridView5.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView5.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridView5.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView5.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView5.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView5.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView5.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.gridView5.Appearance.Row.Options.UseFont = true;
            this.gridView5.Appearance.Row.Options.UseTextOptions = true;
            this.gridView5.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView5.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn15,
            this.gridColumn13,
            this.gridColumn14});
            this.gridView5.CustomizationFormBounds = new System.Drawing.Rectangle(563, 225, 252, 326);
            this.gridView5.GridControl = this.gridControl5;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView5.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView5.VertScrollTipFieldName = "DATA";
            this.gridView5.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView5.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView5_RowCellStyle);
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "SID_Start";
            this.gridColumn15.FieldName = "SID_Start";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Width = 147;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "DATA";
            this.gridColumn13.FieldName = "DATA";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Width = 526;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Cot10";
            this.gridColumn14.FieldName = "Cot10";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 0;
            this.gridColumn14.Width = 247;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer2.Size = new System.Drawing.Size(746, 281);
            this.splitContainer2.SplitterDistance = 151;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Controls.Add(this.txtInput0, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInput, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(746, 151);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // simpleButton13
            // 
            this.simpleButton13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpleButton13.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.simpleButton13.Appearance.Options.UseBackColor = true;
            this.simpleButton13.Appearance.Options.UseFont = true;
            this.simpleButton13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton13.ImageOptions.Image")));
            this.simpleButton13.Location = new System.Drawing.Point(491, 78);
            this.simpleButton13.Name = "simpleButton13";
            this.simpleButton13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton13.Size = new System.Drawing.Size(143, 70);
            this.simpleButton13.TabIndex = 80;
            this.simpleButton13.Text = "XÓA 1";
            this.simpleButton13.Click += new System.EventHandler(this.simpleButton13_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(640, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton1.Size = new System.Drawing.Size(103, 69);
            this.simpleButton1.TabIndex = 79;
            this.simpleButton1.Text = "CLEAN ALL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.EditValue = "";
            this.txtInput.Location = new System.Drawing.Point(307, 78);
            this.txtInput.Name = "txtInput";
            this.txtInput.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInput.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.txtInput.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtInput.Properties.Appearance.Options.UseBackColor = true;
            this.txtInput.Properties.Appearance.Options.UseFont = true;
            this.txtInput.Properties.Appearance.Options.UseForeColor = true;
            this.txtInput.Properties.Appearance.Options.UseTextOptions = true;
            this.txtInput.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtInput.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtInput.Properties.AutoHeight = false;
            this.txtInput.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInput.Properties.NullText = "SS0";
            this.txtInput.Size = new System.Drawing.Size(178, 70);
            this.txtInput.TabIndex = 77;
            // 
            // btn6
            // 
            this.btn6.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.btn6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn6.Appearance.Options.UseFont = true;
            this.btn6.Appearance.Options.UseForeColor = true;
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(155, 78);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(146, 70);
            this.btn6.TabIndex = 71;
            this.btn6.Text = "6";
            // 
            // btn1
            // 
            this.btn1.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.btn1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btn1.Appearance.Options.UseFont = true;
            this.btn1.Appearance.Options.UseForeColor = true;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(146, 69);
            this.btn1.TabIndex = 66;
            this.btn1.Text = "1";
            // 
            // btn5
            // 
            this.btn5.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.btn5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn5.Appearance.Options.UseFont = true;
            this.btn5.Appearance.Options.UseForeColor = true;
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(3, 78);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(146, 70);
            this.btn5.TabIndex = 70;
            this.btn5.Text = "5";
            // 
            // btn2
            // 
            this.btn2.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.btn2.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btn2.Appearance.Options.UseFont = true;
            this.btn2.Appearance.Options.UseForeColor = true;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(155, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(146, 69);
            this.btn2.TabIndex = 67;
            this.btn2.Text = "2";
            // 
            // btn4
            // 
            this.btn4.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.btn4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn4.Appearance.Options.UseFont = true;
            this.btn4.Appearance.Options.UseForeColor = true;
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(491, 3);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(143, 69);
            this.btn4.TabIndex = 69;
            this.btn4.Text = "4";
            // 
            // btn3
            // 
            this.btn3.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.btn3.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btn3.Appearance.Options.UseFont = true;
            this.btn3.Appearance.Options.UseForeColor = true;
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(307, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(178, 69);
            this.btn3.TabIndex = 68;
            this.btn3.Text = "3";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(746, 126);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "";
            // 
            // txtInput0
            // 
            this.txtInput0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput0.EditValue = "";
            this.txtInput0.Location = new System.Drawing.Point(640, 78);
            this.txtInput0.Name = "txtInput0";
            this.txtInput0.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtInput0.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.txtInput0.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtInput0.Properties.Appearance.Options.UseBackColor = true;
            this.txtInput0.Properties.Appearance.Options.UseFont = true;
            this.txtInput0.Properties.Appearance.Options.UseForeColor = true;
            this.txtInput0.Properties.Appearance.Options.UseTextOptions = true;
            this.txtInput0.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtInput0.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtInput0.Properties.AutoHeight = false;
            this.txtInput0.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInput0.Properties.NullText = "SS0";
            this.txtInput0.Size = new System.Drawing.Size(103, 70);
            this.txtInput0.TabIndex = 81;
            // 
            // CONCAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 688);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CONCAT";
            this.Text = "CONCAT";
            this.Load += new System.EventHandler(this.CONCAT_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput0.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn6;
        private DevExpress.XtraEditors.SimpleButton btn1;
        private DevExpress.XtraEditors.SimpleButton btn5;
        private DevExpress.XtraEditors.SimpleButton btn2;
        private DevExpress.XtraEditors.SimpleButton btn3;
        private DevExpress.XtraEditors.TextEdit txtInput;
        private DevExpress.XtraGrid.GridControl gridControl5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraEditors.SimpleButton btn4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton13;
        private DevExpress.XtraEditors.TextEdit txtInput0;
    }
}