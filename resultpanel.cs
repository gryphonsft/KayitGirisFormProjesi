using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registerloginpanel
{
    public partial class resultpanel : Form

    {
        Timer timer;
        public resultpanel()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 3000; 
            timer1.Tick += Timer_Tick; 
            timer1.Start(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
