using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKM_UPLOAD.Data
{
    // 업로드 정보를 한 곳으로 모아 저장
    public class Info
    {
        private string _Server_URL = "";
        private string _Login_ID = "";
        private string _Login_PW = "";
        private string _Upload_FilePath = "";
        private string _Upload_FileName = "";

        public string ServerURL
        {
            get { return _Server_URL; }
            set { _Server_URL = value; }
        }

        public string Login_ID
        {
            get { return _Login_ID; }
            set { _Login_ID = value; }
        }

        public string Login_PW
        {
            get { return _Login_PW; }
            set { _Login_PW = value; }
        }

        public string Upload_FilePath
        {
            get { return _Upload_FilePath; }
            set { _Upload_FilePath = value; }
        }

        public string Upload_FileName
        {
            get { return _Upload_FileName; }
            set { _Upload_FileName = value; }
        }
    }
}
