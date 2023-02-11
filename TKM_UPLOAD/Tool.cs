﻿using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TKM_UPLOAD.Data;

namespace TKM_UPLOAD
{
    public partial class Tool : Form
    {
        // Data
        private string mServerType = null;
        private string mCategory = null;
        private ArrayList mUploadFiles;
        private ArrayList mUploadVerFiles;

        private Button ServerTypeBtn = null;    // 서버선택
        private Button CategoryBtn = null;    // 유형선택

        // UI
        private Color SelectedColor = Color.Tomato;
        private string FileBeforePath = "%USER_HOME%/";     // 재클릭시 이전 폴더가 표출되도록

        public Tool()
        {
            InitializeComponent();

            // init instance
            mUploadFiles = new ArrayList();
            mUploadVerFiles = new ArrayList();
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
                case "TEST":
                    mServerType = Server.Type.TEST;
                    break;
                case "BETA":
                    mServerType = Server.Type.BETA;
                    break;
                case "REAL":
                    mServerType = Server.Type.REAL;
                    break;
            }

            ServerTypeBtn.BackColor = SelectedColor;
            ClearFocus();
        }

        // Type Select Button
        private void type_button_Click(object sender, EventArgs e)
        {
            if (CategoryBtn != null)
            {
                CategoryBtn.BackColor = Color.Transparent;
            }
            CategoryBtn = (Button)sender;

            if (CategoryBtn == button5)
            {
                mCategory = Server.Category.Program;
            }
            else
            {
                mCategory = Server.Category.Image;
            }
            CategoryBtn.BackColor = SelectedColor;
            ClearFocus();
        }



        /* 파일, 버전파일 업로드
         * ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
         */
        // Upload Files Button
        private void upload_file_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog filesDialog = new OpenFileDialog();
            // filesDialog.InitialDirectory = FileBeforePath;      
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
            ClearFocus();
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
            // filesDialog.InitialDirectory = FileBeforePath;      
            filesDialog.Multiselect = true;

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
            ClearFocus();
        }

        private void upload_ver_file_listBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {
                // listBox1.Items.Add(file);
                listBox2.Items.Add(Path.GetFileName(file));
                mUploadFiles.Add(file);
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
            foreach (var item in mUploadFiles)
            {
                Console.WriteLine(item);
            }

            ClearFocus();
            // if all complete
            button1.Enabled = true;
        }

        // Upload Start Button
        private void upload_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Click Current server : {0}", mServerType);
            ClearFocus();
        }

        

        private void ClearFocus()
        {
            listBox1.Focus();
        }
    }
}
