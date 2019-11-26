using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FleaMarketApp.Helper
{
    public static class Auth
    {
        public static string xmlPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "") + "auth.xml";

        public static bool IsAdminUser()
        {
            return true;
        }
    }
}
