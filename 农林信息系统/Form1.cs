using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
namespace 农林信息系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void axToolbarControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IToolbarControlEvents_OnMouseDownEvent e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void axMapControl2_OnMapReplaced(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMapReplacedEvent e)
        {
            
        }

        private void axMapControl1_OnMapReplaced(object sender, IMapControlEvents2_OnMapReplacedEvent e)
        {

            //这个函数不会刷新，但是只对地图文档有用，shp无效
            {
                for (int i = axMapControl1.Map.LayerCount - 1; i >= 0; i--)
                    // if (axMapControl1.Map.get_Layer(i).Visible==true)
                    axMapControl2.Map.AddLayer(axMapControl1.Map.get_Layer(i));
                axMapControl2.Extent = axMapControl2.FullExtent;
                axMapControl2.Refresh();

            }
        }

        private void axMapControl2_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            IPoint pPoint = new PointClass();
                pPoint.PutCoords(e.mapX, e.mapY);
                axMapControl1.CenterAt(pPoint);
                axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);          
     }
    private void axMapControl1_OnExtentUpdated_1(object sender, IMapControlEvents2_OnExtentUpdatedEvent e)
    {
        IEnvelope pEnvelope = (IEnvelope)e.newEnvelope;//外接矩形
        IGraphicsContainer pGraphicsContainer = axMapControl2.Map as IGraphicsContainer;//告诉矩形在哪里画
        IActiveView pActiveView = pGraphicsContainer as IActiveView;//激活
        pGraphicsContainer.DeleteAllElements();
        IRectangleElement pRectangleEle = new RectangleElementClass();
        IElement pElement = pRectangleEle as IElement;
        pElement.Geometry = pEnvelope;     //分别设置矩形的边框颜色 和 填充颜色           
         IRgbColor pColor = new RgbColorClass();
        pColor.Red = 255;
        pColor.Green = 0;
        pColor.Blue = 0;
        pColor.Transparency = 255;
        ILineSymbol pOutline = new SimpleLineSymbolClass();
        pOutline.Width = 3;
        pOutline.Color = pColor;
       IRgbColor eColor = new RgbColorClass();
        eColor.Red = 255;
        eColor.Green = 0;
        eColor.Blue = 0;
        eColor.Transparency = 0;
        SimpleFillSymbolClass pFillSymbol = new SimpleFillSymbolClass();
        pFillSymbol.Color = eColor;
        pFillSymbol.Outline = pOutline;
        IFillShapeElement pFillShapeEle = pElement as IFillShapeElement;
        pFillShapeEle.Symbol = pFillSymbol;            pGraphicsContainer.AddElement((IElement)pFillShapeEle, 0);
        pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);  
    
    
        }

    private void 出图ToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int num = (int)Math.Round(this.axMapControl1.ActiveView.ScreenDisplay.DisplayTransformation.Resolution);

        CreateJPEGHiResolutionFromActiveView(this.axMapControl1.ActiveView, @"D:\文档\开发\农林信息系统\test.jpeg", 80);
        //ExportPDF();
        MessageBox.Show("完成");
    }

    private void CreateJPEGHiResolutionFromActiveView(IActiveView pActiveView, String pFileName, Int32 pOutputResolution)
    {
        ESRI.ArcGIS.Output.IExport pExport = new ESRI.ArcGIS.Output.ExportJPEGClass();//输出类型
            pExport.ExportFileName = pFileName;//输出路径
            pExport.Resolution = pOutputResolution;//输出分辨率

            tagRECT pExportRECT;//以像素为单位的图片大小
            pExportRECT.left = 0;
            pExportRECT.top = 0;
            pExportRECT.right = pActiveView.ExportFrame.right;//所见即所得，即控件大小；如果小于，那么相当于缩小，再导出
            pExportRECT.bottom = pActiveView.ExportFrame.bottom;//所见即所得，即控件大小；如果小于，那么相当于缩小，再导出

            //设备的坐标
            ESRI.ArcGIS.Geometry.IEnvelope pEnvelope = new ESRI.ArcGIS.Geometry.EnvelopeClass();
            pEnvelope.PutCoords(pExportRECT.left, pExportRECT.top, pExportRECT.right, pExportRECT.bottom);//采用PutCoords设置矩形
            pExport.PixelBounds = pEnvelope;//输出的像素范围

            System.Int32 hDC = pExport.StartExporting();//开始
            pActiveView.Output(hDC, (System.Int16)pExport.Resolution, ref pExportRECT, null, null);//输出
            pExport.FinishExporting();//结束
            pExport.Cleanup();//清除
    }

    private void 种植建议ToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void 加载shapefile文件ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        
{
    OpenFileDialog OpFileDialog=new OpenFileDialog();//OpenFileDialog：打开文件对话框
    OpFileDialog.Title="添加矢量数据";
    OpFileDialog.Filter="(*.shp)|*.shp";//filter：过滤器;"(*.shp)|*.shp":筛掉其他数据，只留下shp数据
    if (OpFileDialog.ShowDialog()==DialogResult.OK)//判断打开的当前选择数据的窗口，有没有点击“确定”按钮
    {
        string fullpath=OpFileDialog.FileName;
        string path=fullpath.Substring(0,fullpath.LastIndexOf("\\"));//从路径fullpath中检索子字符串,从开始截取到最后一个“\”
        string name=fullpath.Substring(fullpath.LastIndexOf("\\")+1);//从最后一个“\”的后一个开始，到最后（省略不写，默认到最后）
        axMapControl1.AddShapeFile(path,name);//AddShapeFile：加载shp文件的工具
        axMapControl1.Refresh();//刷新一下界面
    }
}

    }

    

        private void 加载JPG文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Open jpg Data|*.jpg|Open TIF|*.tif|Open BMP|&.bmp";
            dlg.Multiselect = false;
            dlg.Title = "Open ImageFile";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                string pathfile = dlg.FileName;
                pathfile.IndexOf('\\');
                int index = pathfile.LastIndexOf('\\');//查找最后一个\\字符的位置；
                string path = pathfile.Substring(0, index);
                string name = pathfile.Substring(index + 1);

                //raster以文件方式存在  要打开一个文件夹  用datasourseraster创建工作空间工厂
                IWorkspaceFactory pWorkSpaceFac = new RasterWorkspaceFactory();//创建出一个可以进行栅格数据访问的栅格数据工作空间工厂的创建
                IWorkspace pWorkSpace = pWorkSpaceFac.OpenFromFile(path, 0);//用创建的栅格数据工作空间工厂对象的Iworkspace接口的openfromfile方法 以打开数据

                IRasterWorkspace pRasterWorSpa = pWorkSpace as IRasterWorkspace;//接口查询实现IrasterWorkspace的创建  
                IRasterDataset pRasterDataSet = pRasterWorSpa.OpenRasterDataset(name); //IRasterWorkspace接口有openrasterdataset方法：打开栅格数据集

                ILayer pLayer = new RasterLayer(); //创建栅格图层 但此时还没有栅格数据
                //ILayer也是一个公共接口  并未对所有层都有接口   RasterLayer有一个IRasterLayer接口
                IRasterLayer pRasterLayer = pLayer as IRasterLayer;//用pLayer查询
                pRasterLayer.CreateFromDataset(pRasterDataSet);//在栅格层中加载栅格数据

                axMapControl1.AddLayer(pLayer);// prasterlayer是数据 但这个参数需要一个pLayer接口
                axMapControl1.Refresh();


            }
        }

     

        private void 距离量测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
           
        }

        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
           
        }

        private void axMapControl1_OnDoubleClick(object sender, IMapControlEvents2_OnDoubleClickEvent e)
        {
           
        }

        private void 新增书签ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strbookname = Microsoft.VisualBasic.Interaction.InputBox("请输入新书签的名字", "新增书签", "", 100, 100);
            if (strbookname == "")
            {
                MessageBox.Show("请输入名字");
                return;
            }

            //书签进行重名判断
            IMapBookmarks mapBookmarks = axMapControl1.Map as IMapBookmarks;
            IEnumSpatialBookmark enumSpatialBookmarks = mapBookmarks.Bookmarks;
            enumSpatialBookmarks.Reset();
            ISpatialBookmark pSpatialBookmark;

            while ((pSpatialBookmark = enumSpatialBookmarks.Next()) != null)
            {
                if (strbookname == pSpatialBookmark.Name)
                {
                    DialogResult dr = MessageBox.Show("此书签名已存在！是否替换？", "提示", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Yes)
                    {
                        mapBookmarks.RemoveBookmark(pSpatialBookmark);
                    }
                    else if (dr == DialogResult.No)
                    {
                        MessageBox.Show("请重新点击并输入");
                    }
                    else
                    {
                        return;
                    }
                }
            }

            //创建一个新的书签并设置其位置范围为当前视图的范围
            IAOIBookmark pBookmark = new AOIBookmarkClass();
            pBookmark.Location = this.axMapControl1.Extent;

            //获得书签名
            pBookmark.Name = strbookname;
            //通过IMapBookmarks接口访问当前地图书签集，添加书签到地图的书签集中
            IMapBookmarks pMapBookmarks = axMapControl1.Map as IMapBookmarks;
            pMapBookmarks.AddBookmark(pBookmark);
        }

        private void 管理书签ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel2.Visible = !panel2.Visible;

            listBox1.Items.Clear();

            IMapBookmarks mapBookmarks = this.axMapControl1.Map as IMapBookmarks;
            IEnumSpatialBookmark enumSpatialBookmarks = mapBookmarks.Bookmarks;

            enumSpatialBookmarks.Reset();
            ISpatialBookmark pSpatialbookmark = enumSpatialBookmarks.Next();

            while (pSpatialbookmark != null)
            {
                listBox1.Items.Add(pSpatialbookmark.Name);
                pSpatialbookmark = enumSpatialBookmarks.Next();
            }
            
        }

        private void 面积量测ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            IMapBookmarks mapBookmarks = this.axMapControl1.Map as IMapBookmarks;
            IEnumSpatialBookmark enumSpatialBookmarks = mapBookmarks.Bookmarks;

            enumSpatialBookmarks.Reset();

            //书签的名字“”，找书签
            string bookmarkname = this.listBox1.SelectedItem.ToString();

            ISpatialBookmark pSpatialbookmark = enumSpatialBookmarks.Next();

            while (pSpatialbookmark != null)
            {
                if (pSpatialbookmark.Name == bookmarkname)
                {
                    pSpatialbookmark.ZoomTo(this.axMapControl1.Map);
                    this.axMapControl1.ActiveView.Refresh();
                }
                pSpatialbookmark = enumSpatialBookmarks.Next();
            }      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IMapBookmarks mapBookmarks = this.axMapControl1.Map as IMapBookmarks;
            mapBookmarks.RemoveAllBookmarks();
            管理书签ToolStripMenuItem_Click(sender, e);
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            IMapBookmarks mapBookmarks = this.axMapControl1.Map as IMapBookmarks;
            IEnumSpatialBookmark enumSpatialBookmarks = mapBookmarks.Bookmarks;

            //书签的名字“”，找书签
            string bookmarkname = this.listBox1.SelectedItem.ToString();

            ISpatialBookmark pSpatialbookmark = enumSpatialBookmarks.Next();

            while (pSpatialbookmark != null)
            {
                if (pSpatialbookmark.Name == bookmarkname)
                {
                    mapBookmarks.RemoveBookmark(pSpatialbookmark);//移除书签的实质操作语句
                }
                pSpatialbookmark = enumSpatialBookmarks.Next();
            }

            管理书签ToolStripMenuItem_Click(sender, e);
        }

        private void 水文分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Honglao fm = new Honglao();
            fm.Show();
        }

        private void 土壤侵蚀性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            土壤 fm = new 土壤();
            fm.Show();
        }

        private void 大气污染检测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            大气 fm = new 大气();
            fm.Show();
        }

        private void 植被适宜性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            植被 fm = new 植被();
            fm.Show();
        }

      

        
    }
    }
