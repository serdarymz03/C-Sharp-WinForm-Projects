using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProjects_2
{
    class StudentManager
    {
        static StudentManager studentManager;

        List<Student> students = new List<Student>()
        {
            new Student(1,"Serdar Yılmaz","serdar@gmail.com","(555) 555-5555",new DateTime(1980,11,11)),
            new Student(2,"Ayşegül Çağlar","aysegul@gmail.com","(222) 222-33333",new DateTime(1980,11,11)),
            new Student(3,"Mehmet Kansu","mehmet@gmail.com","(444) 213-3546",new DateTime(1980,11,11)),
            new Student(4,"Pınar Kalaça","pinar@gmail.com","(111) 543-2357",new DateTime(1980,11,11)),
            new Student(5,"Damla Çelik","damla@gmail.com","(532) 555-8755",new DateTime(1980,11,11))
        };

        public List<Student> GetList()
        {
            try
            {
                return students;
            }
            catch (Exception)
            {
                return new List<Student>() {
                      new Student(1,"Serdar Yılmaz","serdar@gmail.com","(555) 555-5555",new DateTime(1980,11,11)),
                      new Student(2,"Ayşegül Çağlar","aysegul@gmail.com","(222) 222-33333",new DateTime(1980,11,11)),
                      new Student(3,"Mehmet Kansu","mehmet@gmail.com","(444) 213-3546",new DateTime(1980,11,11)),
                      new Student(4,"Pınar Kalaça","pinar@gmail.com","(111) 543-2357",new DateTime(1980,11,11)),
                      new Student(5,"Damla Çelik","damla@gmail.com","(532) 555-8755",new DateTime(1980,11,11))
                 };
            }
        }

        public Student GetStudentById(int studentId)
        {
            try
            {
                foreach (Student item in students)
                {
                    if (item.Id==studentId)
                    {
                        return item;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public string AddStudent(Student student)
        {
            try
            {
                if (!IsStudentComplete(student))
                {
                    return "Öğrenci Verileri Hatalı";
                }
                students.Add(student);
                return student.Name + " Öğrencisi Başarıyla Eklendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateStudent(Student student)
        {
            try
            {
                if (!IsStudentComplete(student))
                {
                    return "Öğrenci Verileri Hatalı";
                }
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Id == student.Id)
                    {
                        students[i] = student;
                        return student.Name + " Öğrencisi Başarıyla Güncellendi";
                    }
                }
                return "Öğrenci Bulunamadı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteStudent(int studentId)
        {
            try
            {
                foreach (Student item in students)
                {
                    if (item.Id == studentId)
                    {
                        students.Remove(item);
                        return item.Name + " Öğrencisi Başarıyla Silindi";
                    }
                }
                return "Öğrenci Bulunamadı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static StudentManager GetInstance()
        {
            if (studentManager == null)
            {
                studentManager = new StudentManager();
            }
            return studentManager;
        }
        bool IsStudentComplete(Student student)
        {
            try
            {
                if (string.IsNullOrEmpty(student.Name) || string.IsNullOrEmpty(student.Phone) || string.IsNullOrEmpty(student.Mail) || string.IsNullOrEmpty(student.Phone))
                {
                    return false;
                }
                if (!student.Mail.Contains("@"))
                {
                    return false;
                }
                if (student.Mail.Substring(student.Mail.Length - 4, 1) != "." && student.Mail.Substring(student.Mail.Length - 3, 1) != ".")
                {
                    return false;
                }
                MailAddress mailAddress = new MailAddress(student.Mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int GetMaxId()
        {
            int maxId = students[students.Count - 1].Id;
            return maxId + 1;
        }
    }
}
