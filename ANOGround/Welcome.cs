using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANOGround
{
    public partial class Welcome : Form
    {
        Form1 fm = new Form1();
        public Welcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                //每单位时间增加的透明度数 
                this.Opacity += 0.05;
            }
            else
            {
                this.timer1.Stop();
                this.Hide();
                fm.Show();
            } 
        }
    }
}
