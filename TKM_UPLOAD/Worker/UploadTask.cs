using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKM_UPLOAD.Worker
{
    /// <summary>
    /// 인터페이스 사용이 오히려 혼란을 야기할 수 있고,
    /// C# 인터페이스는 클래스와 함께 사용하기에 
    /// 부분적 데이터 전달 메시지 용도로 용이하지 않음
    /// </summary>
    public class UploadTask
    {
        private UploadListener uploadListener;
        private string Server_URL = "";
        private string Login_ID = "";
        private string Login_PW = "";
        private string Upload_FilePath = "";
        private string Upload_FileName = "";

        public UploadTask(UploadListener uploadListener)
        {
            this.uploadListener = uploadListener;
        }

        
    }

    public interface UploadListener
    {
        void PreSubProgressLevel(int totalBytes);
        void DoInBackgroundByte(int uploadBytes);
        void PostMainProgressLevel(int totalBytes);
    }
}
