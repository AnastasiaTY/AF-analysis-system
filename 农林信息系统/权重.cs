using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 农林信息系统
{
    public partial class 权重 : Form
    {
        public 权重()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_fugaidu_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDown1_fugaidu.Value = Program.quanzhong1;

        }

        private void numericUpDown1_zhibeidai_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDown1_fugaidu.Value = Program.quanzhong2;
        }

        private void numericUpDown1_dixing_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDown1_fugaidu.Value = Program.quanzhong3;
        }

        private void button1_queding_Click(object sender, EventArgs e)
        {
            //Program.quanzhong = false;
            //Program.quanzhong1 = numericUpDown1_fugaidu.Value;
            //Program.quanzhong2 = numericUpDown1_fugaidu.Value;
            //Program.quanzhong3 = numericUpDown1_fugaidu.Value;

            //Program.quanzhong = true;
            //this.Close();

        }

        private void button1_queding_Click_1(object sender, EventArgs e)
        {
            Program.quanzhong = false;
            Program.quanzhong1 = numericUpDown1_fugaidu.Value;
            Program.quanzhong2 = numericUpDown1_fugaidu.Value;
            Program.quanzhong3 = numericUpDown1_fugaidu.Value;
            Program.quanzhong = true;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
