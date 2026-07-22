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

namespace 农林信息系统
{
    static class Program
    {
        private static LicenseInitializer m_AOLicenseInitializer = new 农林信息系统.LicenseInitializer();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ESRI License Initializer generated code.
            m_AOLicenseInitializer.InitializeApplication(new esriLicenseProductCode[] { esriLicenseProductCode.esriLicenseProductCodeEngine, esriLicenseProductCode.esriLicenseProductCodeEngineGeoDB, esriLicenseProductCode.esriLicenseProductCodeArcServer, esriLicenseProductCode.esriLicenseProductCodeBasic, esriLicenseProductCode.esriLicenseProductCodeStandard },
            new esriLicenseExtensionCode[] { esriLicenseExtensionCode.esriLicenseExtensionCode3DAnalyst, esriLicenseExtensionCode.esriLicenseExtensionCodeNetwork, esriLicenseExtensionCode.esriLicenseExtensionCodeSpatialAnalyst, esriLicenseExtensionCode.esriLicenseExtensionCodeSchematics, esriLicenseExtensionCode.esriLicenseExtensionCodeMLE, esriLicenseExtensionCode.esriLicenseExtensionCodeDataInteroperability, esriLicenseExtensionCode.esriLicenseExtensionCodeTracking });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //ESRI License Initializer generated code.
            //Do not make any call to ArcObjects after ShutDownApplication()
            m_AOLicenseInitializer.ShutdownApplication();
        }
        public static bool choose1 = false;
        public static bool choose2 = false;
        public static bool choose3 = false;
        public static bool choose4 = false;
        public static bool choose5 = false;
        public static bool choose6 = false;
        public static bool choose_zb1 = false; //NDVI
        public static bool choose_zb2 = false; //植被覆盖度
        public static bool choose_zb3 = false; //植被带
        public static bool choose_zb4 = false; //生态敏感度
        public static bool quanzhong = false;  //权重是否执行
        public static decimal quanzhong1 = 40m;//(默认)植被覆盖度权重
        public static decimal quanzhong2 = 40m;//（默认）植被带权重
        public static decimal quanzhong3 = 20m;//（默认）地形权重
        
    }
}