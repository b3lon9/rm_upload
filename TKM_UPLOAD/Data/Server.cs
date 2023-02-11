using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKM_UPLOAD.Data
{
    public class Server
    {
        public static String URL_TEST = "";
        public static String URL_BETA = "";
        public static String URL_REAL = "";

        // version
        public class Type
        {
            public static string TEST = "TEST/";
            public static string BETA = "BETA/";
            public static string REAL = "REAL/";
        }

        public class Category
        {
            public static string Program = "CON1/SystemFiles/tkm15/apk/";
            public static string Image = "CON1/SystemFiles/tkm15/rsc/";
        }
    }
}
