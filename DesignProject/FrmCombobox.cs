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
    public partial class FrmCombobox : Form
    {
        public FrmCombobox()
        {
            InitializeComponent();
        }

        private void FrmCombobox_Load(object sender, EventArgs e)
        {
            //string[] array = { "Hülya", "Mehmet", "Hakan" };
            //CmbMenu.Items.AddRange(array);

          

            
            CmbMenu.DisplayMember = "Name";
            CmbMenu.ValueMember = "Id";

            //CmbMenu.SelectedValue = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)CmbMenu.SelectedValue==0)
            {
                return;
            }
            MessageBox.Show("User Id : " + CmbMenu.SelectedValue + " Name: " + CmbMenu.Text);
        }
    }

   
}
