using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProjects_2
{
    public class Student
    {
        int _id; string _name, _mail, _phone;DateTime _birthday;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public DateTime Birthday { get => _birthday; set => _birthday = value; }

        public Student(int id, string name, string mail, string phone, DateTime birthday)
        {
            _id = id;
            _name = name;
            _mail = mail;
            _phone = phone;
            _birthday = birthday;
        }

        public Student(string name, string mail, string phone, DateTime birthday)
        {
            _id = StudentManager.GetInstance().GetMaxId();
            _name = name;
            _mail = mail;
            _phone = phone;
            _birthday = birthday;
        }
    }
}
