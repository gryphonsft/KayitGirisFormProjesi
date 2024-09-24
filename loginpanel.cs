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
    public partial class loginpanel : Form
    {
        private string gelenUsername;
        private string gelenPassword;
        public loginpanel(string username, string password)
        {
            InitializeComponent();
            gelenUsername = username;
            gelenPassword = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (loginkullanıcıtxt.Text == gelenUsername && loginparolatxt.Text == gelenPassword)

            {
                resultpanel respanel = new resultpanel();
                respanel.Show();
                this.Hide();
            }

            else if (loginkullanıcıtxt.Text == gelenUsername && loginparolatxt.Text != gelenPassword)

            {
                MessageBox.Show("Şifreniz hatalı! Giriş başarısız.");
            }

            else if(loginkullanıcıtxt.Text != gelenUsername && loginparolatxt.Text !=gelenPassword)

            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı!");
            }

            if (string.IsNullOrEmpty(loginkullanıcıtxt.Text) || string.IsNullOrEmpty(loginparolatxt.Text))
            {
                if (string.IsNullOrEmpty(loginkullanıcıtxt.Text) && string.IsNullOrEmpty(loginparolatxt.Text))
                {
                    MessageBox.Show("Lütfen kullanıcı adı ve şifreyi boş bırakmayınız");
                }
                else if (string.IsNullOrEmpty(loginkullanıcıtxt.Text))
                {
                    MessageBox.Show("Lütfen kullanıcı adını boş bırakmayınız");
                }
                else
                {
                    MessageBox.Show("Lütfen şifreyi boş bırakmayınız");
                }



            }

        }
    }
}

