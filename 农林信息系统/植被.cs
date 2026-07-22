using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Carto;

namespace 农林信息系统
{
    public partial class 植被 : Form
    {
        //private NDVI年份 childform;
        public NDVI年份 childform = null;
        public 植被()
        {
            InitializeComponent();
        }

                #region 植被的四个选项
        string operation1zb = "";
        string operation2zb = "";
        string operation3zb = "";
        string operation4zb = "";
        string operationzb = "";

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            operation1zb = "NDVI";
            Console.WriteLine();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            operation2zb = "植被带";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            operation3zb = "覆盖度";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            operation4zb = "生态因子";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operation1zb == "NDVI")
            {
                NDVI年份 fm = new NDVI年份();
                fm.Show();
                //if (childform == null || childform.IsDisposed)
                //{
                    //if (childform.operation2018 += operation1zb)
                    //{
                if (childform != null)
                {
                    Console.WriteLine();
                    //MessageBox.Show("载入2018年NDVI数据");
                    string pPath = @"D:\KF_GIS\数据\NDVI(1998-2018)";
                    string pFileName = "ndvi2018a.tif";
                    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                    IRasterLayer pRasterLayer = new RasterLayerClass();
                    pRasterLayer.CreateFromRaster(pRaster);
                    axMapControl1.AddLayer(pRasterLayer);
                    axMapControl1.ActiveView.Refresh();
                }
                else
                    return;
                    //}
                //}
            }
        }
    }
}
