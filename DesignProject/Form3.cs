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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (!RdbA.Checked && !RdbB.Checked && !RdbC.Checked && !RdbD.Checked)
            {
                MessageBox.Show("Seçeneklerden Biriniz Seçiniz");
                return;
            }
            
            if (RdbA.Checked)
            {
                //    A Seçeneği İlgili İşlemlerimizi Yapcaz
            }
            else if (RdbB.Checked)
            {
                //    B Seçeneği İlgili İşlemlerimizi Yapcaz
            }
            else if (RdbC.Checked)
            {
                //    C Seçeneği İlgili İşlemlerimizi Yapcaz
            }
            else if (RdbD.Checked)
            {
                //    D Seçeneği İlgili İşlemlerimizi Yapcaz
            }
        }

        private void RdbC_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbC.Checked)
            {
                MessageBox.Show("C Şıkkı Seçildi");
            }          
        }
    }      
}
