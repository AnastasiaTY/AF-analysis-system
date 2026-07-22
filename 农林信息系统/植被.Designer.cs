namespace 农林信息系统
{
    partial class 植被_new
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(植被_new));
            this.button2_chaxun = new System.Windows.Forms.Button();
            this.checkBox3_fugaidu = new System.Windows.Forms.CheckBox();
            this.checkBox2_zhibeidai = new System.Windows.Forms.CheckBox();
            this.checkBox1_NDVI = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.axMapControl1_zhibei = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axTOCControl1_zhibei = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1_nianfen = new System.Windows.Forms.ComboBox();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1_zhibei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1_zhibei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2_chaxun
            // 
            this.button2_chaxun.Location = new System.Drawing.Point(735, 34);
            this.button2_chaxun.Margin = new System.Windows.Forms.Padding(2);
            this.button2_chaxun.Name = "button2_chaxun";
            this.button2_chaxun.Size = new System.Drawing.Size(52, 24);
            this.button2_chaxun.TabIndex = 35;
            this.button2_chaxun.Text = "查询";
            this.button2_chaxun.UseVisualStyleBackColor = true;
            this.button2_chaxun.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox3_fugaidu
            // 
            this.checkBox3_fugaidu.AutoSize = true;
            this.checkBox3_fugaidu.Location = new System.Drawing.Point(521, 22);
            this.checkBox3_fugaidu.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3_fugaidu.Name = "checkBox3_fugaidu";
            this.checkBox3_fugaidu.Size = new System.Drawing.Size(104, 19);
            this.checkBox3_fugaidu.TabIndex = 34;
            this.checkBox3_fugaidu.Text = "植被覆盖度";
            this.checkBox3_fugaidu.UseVisualStyleBackColor = true;
            // 
            // checkBox2_zhibeidai
            // 
            this.checkBox2_zhibeidai.AutoSize = true;
            this.checkBox2_zhibeidai.Location = new System.Drawing.Point(107, 49);
            this.checkBox2_zhibeidai.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2_zhibeidai.Name = "checkBox2_zhibeidai";
            this.checkBox2_zhibeidai.Size = new System.Drawing.Size(74, 19);
            this.checkBox2_zhibeidai.TabIndex = 32;
            this.checkBox2_zhibeidai.Text = "植被带";
            this.checkBox2_zhibeidai.UseVisualStyleBackColor = true;
            // 
            // checkBox1_NDVI
            // 
            this.checkBox1_NDVI.AutoSize = true;
            this.checkBox1_NDVI.Location = new System.Drawing.Point(107, 22);
            this.checkBox1_NDVI.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1_NDVI.Name = "checkBox1_NDVI";
            this.checkBox1_NDVI.Size = new System.Drawing.Size(61, 19);
            this.checkBox1_NDVI.TabIndex = 31;
            this.checkBox1_NDVI.Text = "NDVI";
            this.checkBox1_NDVI.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox3.Location = new System.Drawing.Point(28, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(862, 61);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // axMapControl1_zhibei
            // 
            this.axMapControl1_zhibei.Location = new System.Drawing.Point(122, 63);
            this.axMapControl1_zhibei.Margin = new System.Windows.Forms.Padding(2);
            this.axMapControl1_zhibei.Name = "axMapControl1_zhibei";
            this.axMapControl1_zhibei.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1_zhibei.OcxState")));
            this.axMapControl1_zhibei.Size = new System.Drawing.Size(548, 312);
            this.axMapControl1_zhibei.TabIndex = 37;
            this.axMapControl1_zhibei.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_zhibei_OnMouseDown);
            // 
            // axTOCControl1_zhibei
            // 
            this.axTOCControl1_zhibei.Location = new System.Drawing.Point(10, 63);
            this.axTOCControl1_zhibei.Margin = new System.Windows.Forms.Padding(2);
            this.axTOCControl1_zhibei.Name = "axTOCControl1_zhibei";
            this.axTOCControl1_zhibei.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1_zhibei.OcxState")));
            this.axTOCControl1_zhibei.Size = new System.Drawing.Size(106, 312);
            this.axTOCControl1_zhibei.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = " ";
            // 
            // comboBox1_nianfen
            // 
            this.comboBox1_nianfen.FormattingEnabled = true;
            this.comboBox1_nianfen.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013"});
            this.comboBox1_nianfen.Location = new System.Drawing.Point(185, 22);
            this.comboBox1_nianfen.Name = "comboBox1_nianfen";
            this.comboBox1_nianfen.Size = new System.Drawing.Size(86, 23);
            this.comboBox1_nianfen.TabIndex = 40;
            this.comboBox1_nianfen.Text = "NDVI（年份）";
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(613, 323);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 42;
            this.button1.Text = "生态敏感度";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 植被_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.comboBox1_nianfen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2_chaxun);
            this.Controls.Add(this.checkBox3_fugaidu);
            this.Controls.Add(this.checkBox2_zhibeidai);
            this.Controls.Add(this.checkBox1_NDVI);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.axMapControl1_zhibei);
            this.Controls.Add(this.axTOCControl1_zhibei);
            this.Name = "植被_new";
            this.Text = "植被适宜性分析";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1_zhibei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1_zhibei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2_chaxun;
        private System.Windows.Forms.CheckBox checkBox3_fugaidu;
        private System.Windows.Forms.CheckBox checkBox2_zhibeidai;
        private System.Windows.Forms.CheckBox checkBox1_NDVI;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1_zhibei;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1_zhibei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1_nianfen;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.Button button1;

    }
}