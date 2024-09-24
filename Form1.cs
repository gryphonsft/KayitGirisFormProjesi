using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registerloginpanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/gryphonsft",
                UseShellExecute = true 
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(kullanıcıadıtxt.Text) || string.IsNullOrEmpty(parolatxt.Text))
            {
                if (string.IsNullOrEmpty(kullanıcıadıtxt.Text) && string.IsNullOrEmpty(parolatxt.Text))
                {
                    MessageBox.Show("Lütfen kullanıcı adı ve şifreyi boş bırakmayınız");
                }
                else if (string.IsNullOrEmpty(kullanıcıadıtxt.Text))
                {
                    MessageBox.Show("Lütfen kullanıcı adını boş bırakmayınız");
                }
                else
                {
                    MessageBox.Show("Lütfen şifreyi boş bırakmayınız");
                }
            }
            else
            {
                string username = kullanıcıadıtxt.Text;
                string password = parolatxt.Text;
                loginpanel lgpanel = new loginpanel(username, password);
                lgpanel.Show();
                this.Hide();
            }


        }
    }
}
