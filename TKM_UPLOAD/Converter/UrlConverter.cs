using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKM_UPLOAD.Data;

namespace TKM_UPLOAD.Converter
{
    public class UrlConverter
    {
        public static void Convert(Info info)
        {
            // filepath check
            if (info.Upload_FileName.Contains("detail.ver"))
            {
                info.Upload_FilePath = Server.FilePath.Detail;
            }
            else if (info.Upload_FileName.Contains(".apk"))
            {
                info.Upload_FilePath = Server.FilePath.APK;
            }
            else if (info.Upload_FileName.Contains(".ver"))
            {
                info.Upload_FilePath = Server.FilePath.Ver;
            }
            else
            {
                info.Upload_FilePath = Server.FilePath.Normal;
            }

        }
    }
}
