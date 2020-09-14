using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProjects_2
{
    public partial class FrmDashboard : Form
    {
        StudentManager studentManager;
        public FrmDashboard()
        {
            InitializeComponent();
            studentManager = StudentManager.GetInstance();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            List();
        }


        void List()
        {
            DtgStudentList.DataSource = null;
            DtgStudentList.DataSource = studentManager.GetList();
            DataGridProps();
        }

        void DataGridProps()
        {
            DtgStudentList.Columns["Id"].Visible = false;
            DtgStudentList.Columns["Name"].HeaderText = "İsim";
            DtgStudentList.Columns["Mail"].HeaderText = "E-Mail";
            DtgStudentList.Columns["Phone"].HeaderText = "Numara";
            DtgStudentList.Columns["Birthday"].HeaderText = "Doğum Tarihi";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student(studentManager.GetMaxId(), TxtName.Text, TxtMail.Text, MskPhone.Text, Convert.ToDateTime(MskBirthday.Text));
            MessageBox.Show(studentManager.AddStudent(student));
            List();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List();
        }

        private void detayqaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DtgStudentList.CurrentRow == null)
            {
                MessageBox.Show("Detaylarını Görmek İstediğiniz Öğrenciyi Seçiniz");
                return;
            }

            int id = (int)DtgStudentList.CurrentRow.Cells["Id"].Value;
            string name = DtgStudentList.CurrentRow.Cells["Name"].Value.ToString();
            string phone = DtgStudentList.CurrentRow.Cells["Phone"].Value.ToString();
            string mail = DtgStudentList.CurrentRow.Cells["Mail"].Value.ToString();
            DateTime birthday = (DateTime)DtgStudentList.CurrentRow.Cells["Birthday"].Value;

            Student student = new Student(id, name, mail, phone, birthday);
            FrmDetail frmDetail = new FrmDetail();
            frmDetail.student = student;
            frmDetail.ShowDialog();
            List();
        }
    }
}
