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
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.GeoAnalyst;
using ESRI.ArcGIS.SpatialAnalyst;
using ESRI.ArcGIS.Controls;
namespace 农林信息系统
{
    public partial class Honglao : Form
    {
        public Honglao()
        {
            InitializeComponent();
        }

        
 //显示栅格结果
        public static void ShowRasterResult(AxMapControl myMapcontrol, IGeoDataset geoDataset, string interType)
        {
            IRasterLayer rasterLayer = new RasterLayerClass();
            IRaster raster = new Raster();
            raster = (IRaster)geoDataset;
            rasterLayer.CreateFromRaster(raster);
            rasterLayer.Name = interType;

            myMapcontrol.AddLayer((ILayer)rasterLayer, 0);
            myMapcontrol.ActiveView.Refresh();
        }
        

        private void axLicenseControl1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonYmfx_Click(object sender, EventArgs e)
        {
            IRasterLayer rasterlayer = this.axMapControl1.get_Layer(0) as IRasterLayer;
            IRaster raster = rasterlayer.Raster;
            IGeoDataset inGeodataset = raster as IGeoDataset;

            IQueryFilter queryFliter = new QueryFilterClass();
            string strSQL = "Value>"+textValue.Text ;
            queryFliter.WhereClause = strSQL;

            IRasterDescriptor rasterDes = new RasterDescriptorClass();
            rasterDes.Create(raster, queryFliter, "value");

            IExtractionOp extractop = new RasterExtractionOpClass();
            IGeoDataset outGeodataset = extractop.Attribute(rasterDes);
            ShowRasterResult(axMapControl1,outGeodataset,"ByAttribute");
        }

        }

        
    }
