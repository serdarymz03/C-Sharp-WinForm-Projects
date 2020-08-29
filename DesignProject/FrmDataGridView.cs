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
    public partial class FrmDataGridView : Form
    {
        public FrmDataGridView()
        {
            InitializeComponent();
        }

        private void FrmDataGridView_Load(object sender, EventArgs e)
        {
            List<User> users = new List<User>()
            {
                new User(0,"Üyeler"),
                new User(1,"Serdar"),
                new User(2,"Yılmaz"),
                new User(3,"Ayşegül"),
                new User(4,"Hakan")
            };

            DtgList.DataSource = users;

            DtgList.Columns["Id"].Visible = false;
            DtgList.Columns["Name"].HeaderText = "İsim";

        }

        private void ıdyiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DtgList.Columns["Id"].Visible = true;
        }

        private void başlığıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DtgList.Columns["Id"].HeaderText = "Numara";
        }
    }
    class User
    {
        int _id; string _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public User(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
