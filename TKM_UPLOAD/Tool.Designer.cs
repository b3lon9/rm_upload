using System.Windows.Forms;

namespace TKM_UPLOAD
{
    partial class Tool
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool));
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_type_real = new System.Windows.Forms.Button();
            this.btn_type_beta = new System.Windows.Forms.Button();
            this.btn_type_test = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_category_image = new System.Windows.Forms.Button();
            this.btn_category_program = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_upload_file = new System.Windows.Forms.Button();
            this.btn_ready = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_upload_file_ver = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_urlsetting = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(400, 462);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(120, 50);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.btn_type_real);
            this.groupBox1.Controls.Add(this.btn_type_beta);
            this.groupBox1.Controls.Add(this.btn_type_test);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "서버선택";
            // 
            // btn_type_real
            // 
            this.btn_type_real.Location = new System.Drawing.Point(196, 25);
            this.btn_type_real.Name = "btn_type_real";
            this.btn_type_real.Size = new System.Drawing.Size(84, 34);
            this.btn_type_real.TabIndex = 2;
            this.btn_type_real.Text = "REAL";
            this.btn_type_real.UseVisualStyleBackColor = true;
            this.btn_type_real.Click += new System.EventHandler(this.server_button_Click);
            this.btn_type_real.Click += new System.EventHandler(this.ClearFocus);
            // 
            // btn_type_beta
            // 
            this.btn_type_beta.Location = new System.Drawing.Point(106, 25);
            this.btn_type_beta.Name = "btn_type_beta";
            this.btn_type_beta.Size = new System.Drawing.Size(84, 34);
            this.btn_type_beta.TabIndex = 1;
            this.btn_type_beta.Text = "BETA";
            this.btn_type_beta.UseVisualStyleBackColor = true;
            this.btn_type_beta.Click += new System.EventHandler(this.server_button_Click);
            this.btn_type_beta.Click += new System.EventHandler(this.ClearFocus);
            // 
            // btn_type_test
            // 
            this.btn_type_test.BackColor = System.Drawing.Color.SeaShell;
            this.btn_type_test.Location = new System.Drawing.Point(16, 25);
            this.btn_type_test.Name = "btn_type_test";
            this.btn_type_test.Size = new System.Drawing.Size(84, 34);
            this.btn_type_test.TabIndex = 0;
            this.btn_type_test.Text = "TEST";
            this.btn_type_test.UseVisualStyleBackColor = true;
            this.btn_type_test.Click += new System.EventHandler(this.server_button_Click);
            this.btn_type_test.Click += new System.EventHandler(this.ClearFocus);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.btn_category_image);
            this.groupBox2.Controls.Add(this.btn_category_program);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(315, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "유형선택";
            // 
            // btn_category_image
            // 
            this.btn_category_image.Location = new System.Drawing.Point(106, 25);
            this.btn_category_image.Name = "btn_category_image";
            this.btn_category_image.Size = new System.Drawing.Size(84, 34);
            this.btn_category_image.TabIndex = 4;
            this.btn_category_image.Text = "이미지";
            this.btn_category_image.UseVisualStyleBackColor = true;
            this.btn_category_image.Click += new System.EventHandler(this.type_button_Click);
            this.btn_category_image.Click += new System.EventHandler(this.ClearFocus);
            // 
            // btn_category_program
            // 
            this.btn_category_program.Location = new System.Drawing.Point(16, 25);
            this.btn_category_program.Name = "btn_category_program";
            this.btn_category_program.Size = new System.Drawing.Size(84, 34);
            this.btn_category_program.TabIndex = 3;
            this.btn_category_program.Text = "프로그램";
            this.btn_category_program.UseVisualStyleBackColor = true;
            this.btn_category_program.Click += new System.EventHandler(this.type_button_Click);
            this.btn_category_program.Click += new System.EventHandler(this.ClearFocus);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.btn_upload_file);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(12, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 219);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "업로드 파일";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 180);
            this.listBox1.TabIndex = 2;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.upload_file_listBox_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.upload_file_listBox_DragEnter);
            // 
            // btn_upload_file
            // 
            this.btn_upload_file.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_upload_file.Location = new System.Drawing.Point(211, 0);
            this.btn_upload_file.Name = "btn_upload_file";
            this.btn_upload_file.Size = new System.Drawing.Size(80, 23);
            this.btn_upload_file.TabIndex = 1;
            this.btn_upload_file.Text = "업로드";
            this.btn_upload_file.UseVisualStyleBackColor = true;
            this.btn_upload_file.Click += new System.EventHandler(this.upload_file_button_Click);
            this.btn_upload_file.Click += new System.EventHandler(this.ClearFocus);
            // 
            // btn_ready
            // 
            this.btn_ready.Location = new System.Drawing.Point(400, 405);
            this.btn_ready.Name = "btn_ready";
            this.btn_ready.Size = new System.Drawing.Size(120, 50);
            this.btn_ready.TabIndex = 0;
            this.btn_ready.Text = "준비완료";
            this.btn_ready.UseVisualStyleBackColor = true;
            this.btn_ready.Click += new System.EventHandler(this.ready_button_click);
            this.btn_ready.Click += new System.EventHandler(this.ClearFocus);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox4.Controls.Add(this.btn_upload_file_ver);
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(315, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 219);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "버전 파일";
            // 
            // btn_upload_file_ver
            // 
            this.btn_upload_file_ver.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_upload_file_ver.Location = new System.Drawing.Point(119, 0);
            this.btn_upload_file_ver.Name = "btn_upload_file_ver";
            this.btn_upload_file_ver.Size = new System.Drawing.Size(80, 23);
            this.btn_upload_file_ver.TabIndex = 1;
            this.btn_upload_file_ver.Text = "업로드";
            this.btn_upload_file_ver.UseVisualStyleBackColor = true;
            this.btn_upload_file_ver.Click += new System.EventHandler(this.upload_ver_file_button_Click);
            this.btn_upload_file_ver.Click += new System.EventHandler(this.ClearFocus);
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(6, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(193, 180);
            this.listBox2.TabIndex = 0;
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.upload_ver_file_listBox_DragDrop);
            this.listBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.upload_file_listBox_DragEnter);
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(12, 358);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(508, 10);
            this.progressBar1.Step = 33;
            this.progressBar1.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 374);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(508, 19);
            this.progressBar2.Step = 1;
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btn_urlsetting
            // 
            this.btn_urlsetting.Location = new System.Drawing.Point(478, 2);
            this.btn_urlsetting.Name = "btn_urlsetting";
            this.btn_urlsetting.Size = new System.Drawing.Size(42, 23);
            this.btn_urlsetting.TabIndex = 6;
            this.btn_urlsetting.Text = "URL";
            this.btn_urlsetting.UseVisualStyleBackColor = true;
            this.btn_urlsetting.Click += new System.EventHandler(this.btn_urlsetting_Click);
            this.btn_urlsetting.Click += new System.EventHandler(this.ClearFocus);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.Location = new System.Drawing.Point(12, 405);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(382, 106);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(532, 524);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_urlsetting);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_ready);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.HelpButtonClicked += Tool_HelpButtonClicked;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TKM_UPLOAD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private GroupBox groupBox1;
        private Button btn_type_test;
        private Button btn_type_real;
        private Button btn_type_beta;
        private GroupBox groupBox2;
        private Button btn_category_image;
        private Button btn_category_program;
        private GroupBox groupBox3;
        private Button btn_upload_file;
        private Button btn_ready;
        private GroupBox groupBox4;
        private Button btn_upload_file_ver;
        private ListBox listBox2;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_urlsetting;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ListBox listBox1;
        private RichTextBox richTextBox1;
    }
}

