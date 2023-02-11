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
        private string mServerType = Server.Type.TEST;
        private string mCategory   = Server.Category.Program;

        private Button ServerTypeBtn = null;    // 서버선택
        private Button CategoryBtn   = null;    // 유형선택

        // UI
        private Color SelectedColor = Color.Tomato;

        public Tool()
        {
            InitializeComponent();
        }
        
        // Upload Start Button
        private void upload_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Click Current server : {0}", mServerType);
        }

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
        }
    }
}
