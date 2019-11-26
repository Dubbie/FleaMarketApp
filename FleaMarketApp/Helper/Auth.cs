using FleaMarketApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FleaMarketApp.Helper
{
    public static class Auth
    {
        public static string xmlPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "") + "auth.xml";

        public static bool IsAdminUser()
        {
            User user = LoadUserFromXML();
            return user.Admin;
        }

        private static User LoadUserFromXML()
        {
            XmlSerializer ser = new XmlSerializer(typeof(User));

            // Megnézzük, hogy létezik-e az XML fájl amit olvasni szeretnénk
            if (!File.Exists(xmlPath))
            {
                // Nincs még fájl, hozzuk létre az alap esetet
                User defaultUser = new User
                {
                    Admin = true
                };

                // Szerializáljuk le
                using (TextWriter tw = new StreamWriter(xmlPath))
                {
                    ser.Serialize(tw, defaultUser);
                }

                return defaultUser;
            }
            else
            {
                // Deszerializáljuk
                using (StreamReader sr = new StreamReader(xmlPath))
                {
                    User user = (User)ser.Deserialize(sr);
                    return user;
                }
            }
        }
    }
}
