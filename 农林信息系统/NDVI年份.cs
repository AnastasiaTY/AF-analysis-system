using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;

namespace 农林信息系统
{
    public partial class NDVI年份 : Form
    {
       //private AxMapControl pAxMap;
        /// <summary>
        /// 传值事件
        /// </summary>
        //public delegate void operation2018(string value);
        //public event operation2018 TransferEvent;

       /// <summary>
       /// 构造函数
       /// </summary>
        //植被 f1;
        //NDVI年份 f2;
        
        public NDVI年份()
        {
            InitializeComponent();
            //f1 = ff;
        }

        /// <summary>
        /// 传值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        #region NDVI年份的属性operation
        string operation2018 = "";
        string operation2017 = "";
        string operation2016 = "";
        string operation2015 = "";
        string operation2014 = "";
        string operation2013 = "";
        string operation2012 = "";
        #endregion

        #region NDVI年份设置
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            operation2018 = "1";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            operation2017 = "1";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            operation2016 = "1";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            operation2015 = "1";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            operation2014 = "1";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            operation2013 = "1";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            operation2012 = "1";
        }
        #endregion

        public void button2_Click(object sender, EventArgs e)
        {
            if (operation2018 == "1")
            {
                this.Close();
                //TransferEvent(label1.Text);
            }
        }
        //private void NDVI年份_FormClosing(object sender, FormClosedEventArgs e)
        //{
        //    f1. = null;
        //}
    }
}
