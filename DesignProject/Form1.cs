using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya  / Hello World !");
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtMessage.Text,"İlk Mesaj",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
        }

        private void ChcFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (ChcFirst.Checked)
            {
                MessageBox.Show("ChcFirst Şu Anda Seçili");
            }
            else
            {
                MessageBox.Show("ChcFirst Şu Anda Seçili Değil");
            }
        }
    }
}
