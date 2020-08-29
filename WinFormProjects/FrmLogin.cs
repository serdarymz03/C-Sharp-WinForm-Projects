using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProjects
{
    public partial class FrmLogin : Form
    {
        UserManager userManager;
        public FrmLogin()
        {
            InitializeComponent();
            userManager = UserManager.GetInstance();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (userManager.LoginControl(TxtUserName.Text, TxtPassword.Text))
            {
                MessageBox.Show("Tebrikler. Başarıyla Giriş Yaptınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.name = TxtUserName.Text;
                frmDashboard.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız veya Şifre Hatalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp frmSignUp = new FrmSignUp();
            frmSignUp.ShowDialog();
        }

        private void LnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (TxtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Kullanıcı Adını Giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int userId = userManager.GetUserIdByUserName(TxtUserName.Text.Trim());
            if (userId<1)
            {
                MessageBox.Show("Kullanıcı Adınızı Hatalı Yazdınız","Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            FrmForgot frmForgot = new FrmForgot();
            frmForgot.userId = userId;
            frmForgot.ShowDialog();
        }
    }
}
