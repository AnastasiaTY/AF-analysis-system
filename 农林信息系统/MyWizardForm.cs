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
    public partial class 水土流失敏感性评价 : Form
    {
        public 水土流失敏感性评价()
        {
            InitializeComponent();
            Controls.AddRange(new Control[] {
		        new FirstPage_JS(),
                new SecondPage_JY(),
                new ThirdPage_DX(),
                new ForthPage_TR(),
                new FifthPage_End()
            });
		        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
