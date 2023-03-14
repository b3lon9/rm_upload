using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TKM_UPLOAD.Data
{
    public class Config
    {
        public delegate void Log_Write(string message, Enum.Result result = Enum.Result.일반);

        public static void ReadURL(Log_Write log_write)
        {
            log_write("URL확인");

            // ini 파일 경로
            string iniFilePath = $"{Server.URL_INI}/{Server.FilePath.FileIni}";

            // ini 파일 유무 확인
            if (!File.Exists(iniFilePath))
            {
                if (!Directory.Exists(Server.URL_INI))
                {
                    Directory.CreateDirectory(Server.URL_INI);
                    Console.WriteLine("create directory ! " + Server.URL_INI);
                    log_write($"Create Directory : {Server.URL_INI}");
                }

                IniFile ini = new IniFile(iniFilePath);

                try
                {
                    ini.WriteValue("Info", "TEST URL", "www.test.co.kr");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("error ! : " + ex.Message);
                }
            }
            else
            {
                
                IniFile ini = new IniFile(iniFilePath);

                try
                { 
                    Server.URL_TEST = ini.ReadValue("Info", "TEST URL", "www.nothing.co.kr");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("read error : " + ex.Message);
                }
            }
        }

        // ini파일 설계서
        private class IniFile
        {
            private string iniFilePath = "";
            public IniFile(string iniFilePath)
            {
                this.iniFilePath = iniFilePath;
            }

            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

            public void WriteValue(string Section, string Key, string Value)
            {
                WritePrivateProfileString(Section, Key, Value, this.iniFilePath);
            }

            public string ReadValue(string Section, string Key, string Default)
            {
                StringBuilder buffer = new StringBuilder(255);
                GetPrivateProfileString(Section, Key, Default, buffer, 255, this.iniFilePath);

                return buffer.ToString();
            }

            public void WriteValue(string Section, string Key, int Value)
            {
                WritePrivateProfileString(Section, Key, Value.ToString(), this.iniFilePath);
            }

            public int ReadValue(string Section, string Key, int Default)
            {
                StringBuilder buffer = new StringBuilder(255);
                GetPrivateProfileString(Section, Key, Default.ToString(), buffer, 255, this.iniFilePath);

                return int.Parse(buffer.ToString());
            }
        }
    }
}
