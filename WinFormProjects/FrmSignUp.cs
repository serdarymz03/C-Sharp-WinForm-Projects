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
    public partial class FrmSignUp : Form
    {
        UserManager userManager;
        public FrmSignUp()
        {
            InitializeComponent();
            userManager = UserManager.GetInstance();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text != TxtPassword2.Text)
            {
                MessageBox.Show("Şifre Bilgileri Birbirleriyle Uyuşmuyorlar");
                return;
            }

            User user = new User(TxtUserName.Text, TxtPassword.Text, TxtQuestion.Text, TxtAnswer.Text);
            MessageBox.Show(userManager.AddUser(user));
            string userName = TxtUserName.Text;
            var frmLogin =(FrmLogin) Application.OpenForms["FrmLogin"];
            frmLogin.TxtUserName.Text = userName;
            Close();
        }
    }
}
