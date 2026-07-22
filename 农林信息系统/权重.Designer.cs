namespace 农林信息系统
{
    partial class 权重
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
            this.button1_queding = new System.Windows.Forms.Button();
            this.numericUpDown1_dixing = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1_zhibeidai = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1_fugaidu = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_dixing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_zhibeidai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_fugaidu)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_queding
            // 
            this.button1_queding.Location = new System.Drawing.Point(131, 196);
            this.button1_queding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1_queding.Name = "button1_queding";
            this.button1_queding.Size = new System.Drawing.Size(79, 28);
            this.button1_queding.TabIndex = 14;
            this.button1_queding.Text = "确定";
            this.button1_queding.UseVisualStyleBackColor = true;
            this.button1_queding.Click += new System.EventHandler(this.button1_queding_Click_1);
            // 
            // numericUpDown1_dixing
            // 
            this.numericUpDown1_dixing.Location = new System.Drawing.Point(226, 112);
            this.numericUpDown1_dixing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1_dixing.Name = "numericUpDown1_dixing";
            this.numericUpDown1_dixing.Size = new System.Drawing.Size(107, 25);
            this.numericUpDown1_dixing.TabIndex = 13;
            this.numericUpDown1_dixing.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDown1_zhibeidai
            // 
            this.numericUpDown1_zhibeidai.Location = new System.Drawing.Point(226, 75);
            this.numericUpDown1_zhibeidai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1_zhibeidai.Name = "numericUpDown1_zhibeidai";
            this.numericUpDown1_zhibeidai.Size = new System.Drawing.Size(107, 25);
            this.numericUpDown1_zhibeidai.TabIndex = 12;
            this.numericUpDown1_zhibeidai.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // numericUpDown1_fugaidu
            // 
            this.numericUpDown1_fugaidu.Location = new System.Drawing.Point(226, 36);
            this.numericUpDown1_fugaidu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1_fugaidu.Name = "numericUpDown1_fugaidu";
            this.numericUpDown1_fugaidu.Size = new System.Drawing.Size(107, 25);
            this.numericUpDown1_fugaidu.TabIndex = 11;
            this.numericUpDown1_fugaidu.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "地形权重(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "植被带权重(%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "植被覆盖度权重(%)";
            // 
            // 权重
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 270);
            this.Controls.Add(this.button1_queding);
            this.Controls.Add(this.numericUpDown1_dixing);
            this.Controls.Add(this.numericUpDown1_zhibeidai);
            this.Controls.Add(this.numericUpDown1_fugaidu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "权重";
            this.Text = "权重";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_dixing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_zhibeidai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_fugaidu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_queding;
        private System.Windows.Forms.NumericUpDown numericUpDown1_dixing;
        private System.Windows.Forms.NumericUpDown numericUpDown1_zhibeidai;
        private System.Windows.Forms.NumericUpDown numericUpDown1_fugaidu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}