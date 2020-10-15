using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PdfViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzM1NDI1QDMxMzgyZTMzMmUzMFV3SGorRGdKcFFkbUx6V1cxbG9VUXM3Y2NveEJhUllGOGRlWTFYSlBnY2s9");
        }
    }
}
