using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKM_UPLOAD.Data
{
    public class Server
    {
        // ini
        public static String URL_INI  = $"{AppDomain.CurrentDomain.BaseDirectory}conf";

        public static String URL_TEST = "";
        public static String URL_BETA = "";
        public static String URL_REAL = "";

        // version
        public class Type
        {
            public static string TEST = "TEST";     // "http://test-URL/"
            public static string BETA = "BETA";     // "http://beta-URL/"
            public static string REAL = "REAL";     // "http://real_URL/"
        }

        // type
        public class Category
        {
            public static string Program = "Program";   // "temp/tkm15/apk/";
            public static string Image = "Image";       // "temp/tkm15/rsc/";
        }

        // file
        public class FilePath
        {
            public static string FileIni = "url.ini";
            public static string Normal = "test/";
            public static string APK = Normal + "app/";
            public static string Detail = Normal + "detail/";
            public static string Ver = Normal + "ver/";
            public static string Image = Normal + "rsc/";
        }
    }
}
