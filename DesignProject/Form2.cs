using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "serdar" && TxtPassword.Text == "12345")
            {
                Form1 form1 = new Form1();
                form1.Show();
                MessageBox.Show("Şu Tarihte Giriş Yapıldı : " + DatePicker.Value);
            }
            else
            {
                //MessageBox.Show("Hatalı Kullanıcı Adı ve Şifre", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
        }

        private void newInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Interface Menu Item Clicked");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin2_Click(object sender, EventArgs e)
        {
            if (MskTc.Text.Length < 11)
            {
                //MessageBox.Show("TC'yi Hatalı Girdiniz");
                //return;
            }

            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.ShowDialog();
            MessageBox.Show(folderBrowserDialog1.SelectedPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
