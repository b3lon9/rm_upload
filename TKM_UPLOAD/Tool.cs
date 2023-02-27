﻿using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using TKM_UPLOAD.Data;
using static TKM_UPLOAD.Data.Enum;

namespace TKM_UPLOAD
{
    public partial class Tool : Form
    {
        private bool DEBUG = true;

        // Data
        private string mServerType = null;
        private string mCategory = null;
        private ArrayList mUploadFiles;
        private ArrayList mUploadVerFiles;

        private Button ServerTypeBtn = null;    // 서버선택
        private Button CategoryBtn = null;    // 유형선택

        // UI
        private Color SelectedColor = Color.Tomato;
        private string Caption = "";

        public Tool()
        {
            InitializeComponent();

            // init instance
            mUploadFiles = new ArrayList();
            mUploadVerFiles = new ArrayList();
            btn_start.Enabled = DEBUG;
        }

        private void btn_urlsetting_Click(object sender, EventArgs e)
        {
            Config.ReadURL();
        }


        /* 서버, 파일유형
         * ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
         */
        // Server Select Button
        private void server_button_Click(object sender, EventArgs e)
        {
            if (ServerTypeBtn == null)
            {
                ServerTypeBtn = (Button)sender;
            }
            else
            {
                ServerTypeBtn.BackColor = Color.Transparent;
                ServerTypeBtn = (Button)sender;
            }

            switch (ServerTypeBtn.Text)
            {
                case "TEST": mServerType = Server.Type.TEST; break;
                case "BETA": mServerType = Server.Type.BETA; break;
                case "REAL": mServerType = Server.Type.REAL; break;
            }
            log_write(mServerType + "서버 선택", Result.일반);
            ServerTypeBtn.BackColor = SelectedColor;
        }

        // Type Select Button
        private void type_button_Click(object sender, EventArgs e)
        {
            if (CategoryBtn != null)
            {
                CategoryBtn.BackColor = Color.Transparent;
            }
            CategoryBtn = (Button)sender;

            if (CategoryBtn == btn_category_program)
            {
                mCategory = Server.Category.Program;
            }
            else
            {
                mCategory = Server.Category.Image;
            }
            log_write(mCategory + "유형 선택");
            CategoryBtn.BackColor = SelectedColor;
        }



        /* 파일, 버전파일 업로드
         * ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
         */
        // Upload Files Button
        private void upload_file_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog filesDialog = new OpenFileDialog();
            filesDialog.Multiselect = true;

            if (filesDialog.ShowDialog() == DialogResult.OK)
            {
                // FileBeforePath = filesDialog.FileName;
                foreach (var filepath in filesDialog.FileNames)
                {
                    Console.WriteLine("upload_file_button_click : {0}", Path.GetFileNameWithoutExtension(filepath));
                    listBox1.Items.Add(Path.GetFileName(filepath));
                    mUploadFiles.Add(filepath);
                }
            }
        }

        private void upload_file_listBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {
                // listBox1.Items.Add(file);
                listBox1.Items.Add(Path.GetFileName(file));
                mUploadFiles.Add(file);
            }
        }

        private void upload_ver_file_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog filesDialog = new OpenFileDialog();
            filesDialog.Multiselect = true;
            // filesDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            if (filesDialog.ShowDialog() == DialogResult.OK)
            {
                // FileBeforePath = filesDialog.FileName;
                foreach (var filepath in filesDialog.FileNames)
                {
                    Console.WriteLine("upload_file_button_click : {0}", Path.GetFileNameWithoutExtension(filepath));
                    listBox2.Items.Add(Path.GetFileName(filepath));
                    mUploadVerFiles.Add(filepath);
                }
            }
        }

        private void upload_ver_file_listBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {
                // listBox1.Items.Add(file);
                listBox2.Items.Add(Path.GetFileName(file));
                mUploadVerFiles.Add(file);
            }
        }

        // drag&drop possible
        private void upload_file_listBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }



        /* 준비완료, 업로드 시작
        * ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
        */
        // Upload Ready Button
        private void ready_button_click(object sender, EventArgs e)
        {
            NetworkCheck();

            if (mServerType == null)
            {
                MessageBox.Show(Properties.Resources.MsgBoxSuggestServer, Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mCategory == null)
            {
                MessageBox.Show(Properties.Resources.MsgBoxSuggestCategory, Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mUploadFiles.Count == 0)
            {
                MessageBox.Show(Properties.Resources.MsgBoxSuggestUploadFile, Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mUploadVerFiles.Count == 0)
            {
                MessageBox.Show(Properties.Resources.MsgBoxSuggestUploadFileVer, Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (btn_start.Enabled)
            {

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("업로드 준비가 완료되었습니다", Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    foreach (var item in mUploadFiles)
                    {
                        Console.WriteLine(item);
                    }

                    // if all complete
                    btn_start.Enabled = true;
                }
            }
        }

        // Upload Start Button
        private void upload_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Click Current server : {0}", mServerType);
            UIEnabled(false);

            if (mUploadFiles != null)
            {
                log_write("File Upload...");
                backgroundWorker1.RunWorkerAsync();
            }

            if (mUploadVerFiles != null)
            {
                log_write("VerFile Upload...");
                backgroundWorker2.RunWorkerAsync();
            }
        }



        private void ClearFocus(object sender, EventArgs e)
        {
            listBox1.Focus();
        }

        private void UIEnabled(bool enabled)
        {
            groupBox1.Enabled = enabled;
            groupBox2.Enabled = enabled;
            groupBox3.Enabled = enabled;
            groupBox4.Enabled = enabled;
        }

        private void Tool_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("수정사항 문의\nb3xlon9@gmail.com", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            e.Cancel = true;
        }

        private bool first_append_text = true;

        private void log_write(string msg = "\r\n", Result result = Result.일반)
        {
            switch (result)
            {
                case Result.실패: richTextBox1.SelectionColor = Color.Red;   break;
                case Result.성공: richTextBox1.SelectionColor = Color.Green; break;
                case Result.일반: richTextBox1.SelectionColor = Color.Black; break;
            }

            // 최초 입력시 줄바꿈 관련
            if (first_append_text)
            {
                first_append_text = false;
                richTextBox1.AppendText(msg);
            }
            else
            {
                richTextBox1.AppendText("\r\n" + msg);
            }

            // 자동 스크롤
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }



        /*
         Background Working
         */
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // 2023.02.19. FTP Rest TEST ... 
            byte[] data;

            Console.WriteLine("...>??? : " + listBox1.Items[0].ToString());
            Console.WriteLine("...>??? : " + mUploadFiles[0].ToString());

            // file Size
            long filesize = 0;

            foreach (var file in mUploadFiles)
            {
                FileInfo fileInfo = new FileInfo(file.ToString());
                filesize += fileInfo.Length;
            }
            Console.WriteLine("...>??? : " + filesize);

            progressBar1.Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Maximum = (int)filesize;
            }));


            Console.WriteLine("....... progressbar.. : " + progressBar1.Maximum);
            Console.WriteLine("....... progressbar.. : " + progressBar1.Value);
            int count = 0;
            foreach (var file in mUploadFiles)
            {
                // backgroundWorker1.ReportProgress(0, "file size : " + filesize);
                Console.WriteLine("================== Other File : " + file);
                using (StreamReader sr = new StreamReader(file.ToString()))
                {
                    while (sr.EndOfStream == false)
                    {
                        var line = sr.ReadLine();
                        count += line.Length;
                        // var value = (int)(((decimal)line.Length / (decimal)fileInfo.Length)*(decimal)100);
                        backgroundWorker1.ReportProgress(count);
                    }
                    // data = Encoding.UTF8.GetBytes(sr.ReadToEnd());
                }
            }

            /*using (StreamReader reader = new StreamReader(new FileStream(mUploadFiles[0].ToString(), FileMode.Open), true))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    log_write(line);
                    line = reader.ReadLine();
                }
            }*/


            /*string server = "192.168.56.1/home/neander/Desktop";

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("");
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("login", "password");
            request.UseBinary = true;
            byte[] buffer = new byte[1024];     // memeory stream
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(buffer, 0, buffer.Length);
            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            response.Close();
            MessageBox.Show(Properties.Resources.MsgBoxSuggestUploadFileVer, Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
        }
        int value = 0;

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            // progressbar update
            Console.WriteLine("percentage : " + e.ProgressPercentage);
            // value += e.ProgressPercentage;
            progressBar1.Value = e.ProgressPercentage;

            // logbox update
            // log_write((string)e.UserState);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = progressBar1.Maximum;

            string msg = Properties.Resources.MsgBoxSuggestServer;
            log_write("... value : " + value);
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void backgroundWorker2_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }

        private void NetworkCheck()
        {
            const string URL = "192.168.56.1";

            var web = new WebClient();
            string result = web.DownloadString(URL);

            Console.WriteLine("Network TEST ..... : " + result);
        }
    }
}
