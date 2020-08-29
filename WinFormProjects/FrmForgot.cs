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
    public partial class FrmForgot : Form
    {
        public int userId;
        UserManager userManager;
        public FrmForgot()
        {
            InitializeComponent();
            userManager = UserManager.GetInstance();            
        }

        private void FrmForgot_Load(object sender, EventArgs e)
        {
            TxtQuestion.Text = userManager.GetUserQuestionByUserId(userId);
        }

        private void BtnControl_Click(object sender, EventArgs e)
        {
            if (TxtAnswer.Text.Trim() == "")
            {
                MessageBox.Show("Gizli Cevabı Yazınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool control = userManager.ControlAnswer(userId, TxtAnswer.Text);
            if (control)
            {
                groupBox1.Enabled = true;
            }

        }

        private void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text.Trim() == "" || TxtPassword2.Text.Trim() == "")
            {
                MessageBox.Show("Şifre Bilgilerini Eksiksiz Giriniz");
            }

            if (TxtPassword.Text.Trim() != TxtPassword2.Text.Trim())
            {
                MessageBox.Show("Şifre Bilgileri Birbirleriyle Uyuşmuyorlar");
                return;
            }

            MessageBox.Show(userManager.UpdatePassword(userId, TxtPassword.Text.Trim()));
            Close();
        }
    }
}
