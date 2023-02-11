using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKM_UPLOAD.Data;

namespace TKM_UPLOAD
{
    public partial class Tool : Form
    {
        // Data
        private string mServer = "TEST/";
        
        // UI
        private Button beforeServerBtn = null;      // 버튼 토글 용도

        public Tool()
        {
            InitializeComponent();
        }
        
        private void Tool_Load(object sender, EventArgs e)
        {
            
        }

        // Upload Start Button
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Click Current server : {0}", mServer);
        }

        // Server Select Button
        private void button_Click(object sender, EventArgs e)
        {
            if (beforeServerBtn == null)
            {
                beforeServerBtn = (Button)sender;
            } 
            else
            {
                beforeServerBtn.BackColor = Color.Transparent;
                beforeServerBtn = (Button)sender;
            }

            switch (beforeServerBtn.Text)
            {
                case "TEST":
                    mServer = Server.Name.TEST;
                    break;
                case "BETA":
                    mServer = Server.Name.BETA;
                    break;
                case "REAL":
                    mServer = Server.Name.REAL;
                    break;
            }
            
            beforeServerBtn.BackColor = Color.Peru;
        }
    }
}
