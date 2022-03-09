using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasvuruSistemi
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

                      
            
                if (kullaniciadiTxt.Text == "Mert" || kullaniciadiTxt.Text == "mert" || kullaniciadiTxt.Text == "Davut" || kullaniciadiTxt.Text == "davut")
                {
                    if (sifreTxt.Text == "emm5858")
                    {
                        frm.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Hatalı Giriş Yaptınız");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
                
                    



        }
    }
}
