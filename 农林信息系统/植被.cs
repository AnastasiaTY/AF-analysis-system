using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using Microsoft.VisualBasic;
using ESRI.ArcGIS.Output;
using ESRI.ArcGIS.SpatialAnalyst;
using ESRI.ArcGIS.SpatialAnalystTools;
using ESRI.ArcGIS.GeoAnalyst;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.Geoprocessing;
using System.Runtime.InteropServices;


namespace 农林信息系统
{
    public partial class 植被_new : Form
    {
        public 植被_new()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axMapControl1_zhibei.ClearLayers();
            axTOCControl1_zhibei.Update();
            if (checkBox1_NDVI.Checked)
            {
                Program.choose_zb1 = true;
                #region NDVI
                if (comboBox1_nianfen.Text == "NDVI（年份）")
                {
                    MessageBox.Show("请选择年份");
                    return;
                }
                if (comboBox1_nianfen.Text == "2018")
                {
                    string pPath = @"D:\huben\数据\NDVI(1998-2018)";
                    string pFileName = "ndvi20181.tif";
                    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                    IRasterLayer pRasterLayer = new RasterLayerClass();
                    pRasterLayer.CreateFromRaster(pRaster);
                    axMapControl1_zhibei.AddLayer(pRasterLayer);
                    axMapControl1_zhibei.ActiveView.Refresh();
                }
                if (comboBox1_nianfen.Text == "2017")
                {
                    string pPath = @"D:\huben\数据\NDVI(1998-2018)";
                    string pFileName = "ndvi2017.tif";
                    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                    IRasterLayer pRasterLayer = new RasterLayerClass();
                    pRasterLayer.CreateFromRaster(pRaster);
                    axMapControl1_zhibei.AddLayer(pRasterLayer);
                    axMapControl1_zhibei.ActiveView.Refresh();
                }
                if (comboBox1_nianfen.Text == "2016")
                {
                    string pPath = @"D:\huben\数据\NDVI(1998-2018)";
                    string pFileName = "ndvi2016.tif";
                    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                    IRasterLayer pRasterLayer = new RasterLayerClass();
                    pRasterLayer.CreateFromRaster(pRaster);
                    axMapControl1_zhibei.AddLayer(pRasterLayer);
                    axMapControl1_zhibei.ActiveView.Refresh();
                }
                if (comboBox1_nianfen.Text == "2015")
                {
                    string pPath = @"D:\huben\数据\NDVI(1998-2018)";
                    string pFileName = "ndvi2015.tif";
                    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                    IRasterLayer pRasterLayer = new RasterLayerClass();
                    pRasterLayer.CreateFromRaster(pRaster);
                    axMapControl1_zhibei.AddLayer(pRasterLayer);
                    axMapControl1_zhibei.ActiveView.Refresh();
                }
                if (comboBox1_nianfen.Text == "2014")
                {
                    string pPath = @"D:\huben\数据\NDVI(1998-2018)";
                    string pFileName = "ndvi2014.tif";
                    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                    IRasterLayer pRasterLayer = new RasterLayerClass();
                    pRasterLayer.CreateFromRaster(pRaster);
                    axMapControl1_zhibei.AddLayer(pRasterLayer);
                    axMapControl1_zhibei.ActiveView.Refresh();
                }
                if (comboBox1_nianfen.Text == "2013")
                {
                    string pPath = @"D:\huben\数据\NDVI(1998-2018)";
                    string pFileName = "ndvi2013.tif";
                    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                    IRasterLayer pRasterLayer = new RasterLayerClass();
                    pRasterLayer.CreateFromRaster(pRaster);
                    axMapControl1_zhibei.AddLayer(pRasterLayer);
                    axMapControl1_zhibei.ActiveView.Refresh();
                }


                //NDVI_年份 fm = new NDVI_年份();
                //fm.ShowDialog();
                //if (Program.choose1 == true)
                //{
                //    //MessageBox.Show("载入2018年NDVI数据");
                //    string pPath = @"D:\huben\数据\NDVI(1998-2018)";
                //    string pFileName = "ndvi20181.tif";
                //    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                //    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                //    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                //    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                //    IRasterLayer pRasterLayer = new RasterLayerClass();
                //    pRasterLayer.CreateFromRaster(pRaster);
                //    axMapControl1.AddLayer(pRasterLayer);
                //    axMapControl1.ActiveView.Refresh();
                //}
                //if (Program.choose2 == true)
                //{
                //    //MessageBox.Show("载入2017年NDVI数据");
                //    string pPath = @"D:\huben\数据\NDVI(1998-2018)";
                //    string pFileName = "ndvi2017.tif";
                //    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                //    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                //    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                //    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                //    IRasterLayer pRasterLayer = new RasterLayerClass();
                //    pRasterLayer.CreateFromRaster(pRaster);
                //    axMapControl1.AddLayer(pRasterLayer);
                //    axMapControl1.ActiveView.Refresh();
                //}
                //if (Program.choose3 == true)
                //{
                //    //MessageBox.Show("载入2017年NDVI数据");
                //    string pPath = @"D:\huben\数据\NDVI(1998-2018)";
                //    string pFileName = "ndvi2016.tif";
                //    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                //    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                //    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                //    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                //    IRasterLayer pRasterLayer = new RasterLayerClass();
                //    pRasterLayer.CreateFromRaster(pRaster);
                //    axMapControl1.AddLayer(pRasterLayer);
                //    axMapControl1.ActiveView.Refresh();
                //}
                //if (Program.choose4 == true)
                //{
                //    //MessageBox.Show("载入2017年NDVI数据");
                //    string pPath = @"D:\huben\数据\NDVI(1998-2018)";
                //    string pFileName = "ndvi2015.tif";
                //    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                //    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                //    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                //    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                //    IRasterLayer pRasterLayer = new RasterLayerClass();
                //    pRasterLayer.CreateFromRaster(pRaster);
                //    axMapControl1.AddLayer(pRasterLayer);
                //    axMapControl1.ActiveView.Refresh();
                //}
                //if (Program.choose5 == true)
                //{
                //    //MessageBox.Show("载入2017年NDVI数据");
                //    string pPath = @"D:\huben\数据\NDVI(1998-2018)";
                //    string pFileName = "ndvi2014.tif";
                //    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                //    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                //    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                //    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                //    IRasterLayer pRasterLayer = new RasterLayerClass();
                //    pRasterLayer.CreateFromRaster(pRaster);
                //    axMapControl1.AddLayer(pRasterLayer);
                //    axMapControl1.ActiveView.Refresh();
                //}
                //if (Program.choose6 == true)
                //{
                //    //MessageBox.Show("载入2017年NDVI数据");
                //    string pPath = @"D:\huben\数据\NDVI(1998-2018)";
                //    string pFileName = "ndvi2013.tif";
                //    IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                //    IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                //    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                //    IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                //    IRasterLayer pRasterLayer = new RasterLayerClass();
                //    pRasterLayer.CreateFromRaster(pRaster);
                //    axMapControl1.AddLayer(pRasterLayer);
                //    axMapControl1.ActiveView.Refresh();
                //}
                //else
                //{

                //}
                #endregion
            }
            if (checkBox2_zhibeidai.Checked)
            {
                Program.choose_zb2 = true;
                if (checkBox2_zhibeidai.Checked)
                {
                    ReadLyr(); //MessageBox.Show("载入植被带");

                    //openFileDialog1.Filter = "(植被带.tif.lyr)|植被带.tif.lyr";
                    //openFileDialog1.InitialDirectory = @"D:\huben\数据\植被带";
                    //openFileDialog1.Multiselect = false;
                    //DialogResult pDialogResult = openFileDialog1.ShowDialog();
                    //if (pDialogResult != DialogResult.OK)
                    //    return;
                    //if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    //{
                    //    string pFileName = openFileDialog1.FileName;
                    //    axMapControl1_zhibei.AddLayerFromFile(pFileName);
                    //    axMapControl1_zhibei.ActiveView.Refresh();

                    //}
                }
            }
            if (checkBox3_fugaidu.Checked)
            {
                Program.choose_zb3 = true;
                string pPath = @"D:\huben\数据\植被覆盖度";
                string pFileName = "植被覆盖度.tif";
                IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                IRasterLayer pRasterLayer = new RasterLayerClass();
                pRasterLayer.CreateFromRaster(pRaster);
                axMapControl1_zhibei.AddLayer(pRasterLayer);
                axMapControl1_zhibei.ActiveView.Refresh();
            }
        }


        private void 植被_new_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// GP栅格计算器
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <param name="output_raster">输出地址</param>
        private void GPRasterCalculatorAnalyst()
        {
            axMapControl1_zhibei.ClearLayers();
            IMapDocument pMapDocument = new MapDocument();
            pMapDocument.Open(@"D:\huben\数据\敏感度分析.mxd");//示例数据
            axMapControl1_zhibei.Map = pMapDocument.ActiveView.FocusMap;
            axMapControl1_zhibei.Map = pMapDocument.get_Map(0);//显示
            axMapControl1_zhibei.ActiveView.Refresh();
            double a = Convert.ToDouble(Program.quanzhong1) / 100;
            double b = Convert.ToDouble(Program.quanzhong2) / 100;
            double c = Convert.ToDouble(Program.quanzhong3) / 100;
            string expression = "\"植被覆盖度.tif\" *" + a + "+\"植被带.tif\" *" + b + "+\"可侵蚀性因子.tif\" *" + c + "";
            //a = a / 100;
            //b = b / 100;
            //c = c / 100;
            Geoprocessor gp = new Geoprocessor();
            gp.OverwriteOutput = true;
            ESRI.ArcGIS.SpatialAnalystTools.RasterCalculator rc = new RasterCalculator();
            rc.expression = expression;
            //rc.expression = @"'D:\植被覆盖度.tif'" + "*" + a + @"'D:\植被带.tif'" + "*" + b + @"'D:\可侵蚀性因子.tif'" + "*" + b;
            rc.output_raster = @"D:\huben\数据\mingandu.tif";
            gp.Execute(rc, null);
        }
        private void ReadLyr()
        {
            string pFileName = @"D:\huben\数据\植被带\植被带.tif.lyr";
            try
            {
                IMapControl2 myAddLayerMap = new MapControlClass();
                myAddLayerMap.AddLayerFromFile(pFileName, 0);
                this.axMapControl1_zhibei.AddLayer(myAddLayerMap.get_Layer(0));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.choose_zb4 = true;
            权重 fm = new 权重();
            fm.ShowDialog();
            if (Program.quanzhong == true)
            {
                GPRasterCalculatorAnalyst();
                string pPath = @"D:\huben\数据";
                string pFileName = "mingandu.tif";
                IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
                IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
                IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
                IRaster pRaster = pRasterDataset.CreateDefaultRaster();
                IRasterLayer pRasterLayer = new RasterLayerClass();
                pRasterLayer.CreateFromRaster(pRaster);
                axMapControl1_zhibei.AddLayer(pRasterLayer);
                axMapControl1_zhibei.ActiveView.Refresh();

                IRasterLayer pfeatRaster = this.axMapControl1_zhibei.get_Layer(0) as IRasterLayer; //landuse图层
                string Remap1 = "";//重分类区间字符串
                Remap1 = 0 + " " + 1 + " " + 1 + ";";   // [0 - 1] 重分类为1
                Remap1 = Remap1 + 1 + " " + 2 + " " + 2 + ";";// [1 - 2] 重分类为2
                Remap1 = Remap1 + 2 + " " + 3 + " " + 3 + ";";// [2 - 3] 重分类为3
                Remap1 = Remap1 + 3 + " " + 30000 + " " + 0 + ";";// [3 - 30000] 重分类为0
                ReClassRaster(pfeatRaster.Raster, @"d:\huben\数据\rastercls.img", Remap1);//调用重分类方法
                loadraster(axMapControl1_zhibei, @"d:\huben\数据", "rastercls.img");
                axMapControl1_zhibei.ClearLayers();
                addlay();
                MessageBox.Show("完成");
            }
        }
        //private void testToolStripMenuItem_Click(object sender,EventArgs e)
        //{
        //    IRasterLayer pfeatRaster = this.axMapControl1_zhibei.get_Layer(1) as IRasterLayer; //landuse图层

        //    string Remap1 = "";//重分类区间字符串
        //    Remap1 = 0 + " " + 1 + " " + 1 + ";";   // [0 - 1] 重分类为1
        //    Remap1 = Remap1 + 1 + " " + 2 + " " + 2 + ";";// [1 - 2] 重分类为2
        //    Remap1 = Remap1 + 2.01 + " " + 3 + " " + 3 + ";";// [2 - 3] 重分类为3
        //    Remap1 = Remap1 + 3.01 + " " + 30000 + " " + 0 + ";";// [3 - 3000] 重分类为0
        //    ReClassRaster(pfeatRaster.Raster, @"d:\rastercls.img", Remap1);//调用重分类方法
        //    loadraster(axMapControl1_zhibei, @"d:", "rastercls.img");

        //    MessageBox.Show("");
        //}

        //重分类方法gp实现
        public static void ReClassRaster(IRaster raster, string savepath, string remap)
        {
            Geoprocessor gp = new Geoprocessor();
            gp.OverwriteOutput = true;

            Reclassify Rec = new Reclassify();
            Rec.in_raster = raster;
            Rec.reclass_field = "Value";
            Rec.remap = remap;
            Rec.out_raster = savepath;

            gp.Execute(Rec, null);
        }
        private void loadraster(AxMapControl myMapControl, string pPath, string pFileName)
        {
            //获取文件名和文件路径
            IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
            IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);

            IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
            IRaster pRaster = pRasterDataset.CreateDefaultRaster();
            IRasterLayer pRasterLayer = new RasterLayerClass();
            pRasterLayer.CreateFromRaster(pRaster);

            myMapControl.AddLayer(pRasterLayer);
            myMapControl.ActiveView.Refresh();
        }
        private void addlay()
        {
            string pPath = @"D:\huben\数据";
            string pFileName = "rastercls.img";
            IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactory();
            IRasterWorkspace pRasterWorkspace = (IRasterWorkspace)pWorkspaceFactory.OpenFromFile(pPath, 0);
            IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pFileName);
            IRaster pRaster = pRasterDataset.CreateDefaultRaster();
            IRasterLayer pRasterLayer = new RasterLayerClass();
            pRasterLayer.CreateFromRaster(pRaster);
            axMapControl1_zhibei.AddLayer(pRasterLayer);
            axMapControl1_zhibei.ActiveView.Refresh();
        }

        private void axMapControl1_zhibei_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {

        }
    }
}
