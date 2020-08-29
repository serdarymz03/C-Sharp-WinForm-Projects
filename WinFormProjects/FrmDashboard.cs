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
    public partial class FrmDashboard : Form
    {
        public string name;
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
        }
    }
}
