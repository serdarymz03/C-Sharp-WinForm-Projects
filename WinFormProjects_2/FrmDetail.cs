using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProjects_2
{
    public partial class FrmDetail : Form
    {
        public Student student;
        StudentManager studentManager;
        bool start = true;
       
        public FrmDetail()
        {
            InitializeComponent();
            studentManager = StudentManager.GetInstance();
        }

        void CmbStudentLoad()
        {
            CmbStudent.DataSource = studentManager.GetList();
            CmbStudent.DisplayMember = "Name";
            CmbStudent.ValueMember = "Id";
            CmbStudent.SelectedValue = 0;
        }



        private void FrmDetail_Load(object sender, EventArgs e)
        {
            StudentInfos();
            CmbStudentLoad();
            start = false;
        }

        void StudentInfos()
        {
            TxtName.Text = student.Name;
            TxtMail.Text = student.Mail;
            MskBirthday.Text = student.Birthday.ToString();
            MskPhone.Text = student.Phone;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(student.Name + " Öğrencisi İçin Güncelleme İşlemi Yapılacaktır. Emin Misiniz", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Student newStudent = new Student(student.Id, TxtName.Text, TxtMail.Text, MskPhone.Text, Convert.ToDateTime(MskBirthday.Text));
                studentManager.UpdateStudent(newStudent);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(student.Name + " Öğrencisi İçin Silme İşlemi Yapılacaktır. Emin Misiniz", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                studentManager.DeleteStudent(student.Id);
                Close();
            }
        }

        private void CmbStudent_SelectedValueChanged(object sender, EventArgs e)
        {
            if (start)
            {
                return;
            }
            if ((int)CmbStudent.SelectedValue < 1)
            {
                return;
            }

            int chosenId = (int)CmbStudent.SelectedValue;
            student = studentManager.GetStudentById(chosenId);
            StudentInfos();
        }
    }
}
