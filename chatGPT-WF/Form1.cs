using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatGPT_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            
        }
        private void FormLoad(object sender, EventArgs e)
        {
            // ウィンドウを画面右下に表示させる
            int left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            DesktopBounds = new Rectangle(left, top, this.Width, this.Height);
            this.TopMost = true;
        }

    }
}
