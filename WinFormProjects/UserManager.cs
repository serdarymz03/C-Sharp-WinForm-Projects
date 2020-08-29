using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProjects
{
    class UserManager
    {
        static UserManager userManager;
        List<User> users = new List<User>()
       {
           new User(1,"Serdar","12345","En Sevdiği Marka?","Honda"),
           new User(2,"Mehmet","12345","En Sevdiği Yemek?","Mantı"),
           new User(3,"Ayşegül","12345","En Sevdiği Renk?","Mavi"),
           new User(4,"Yağmur","12345","En Sevdiği Şehir?","New York")
       };

        private UserManager()
        {

        }

        public string AddUser(User user)
        {
            try
            {
                if (!IsUserComplete(user))
                {
                    return "Kullanıcı Eklenemez";
                }
                if (!IsPasswordComplete(user.Password))
                {
                    return "Şifre Yeteri Kadar Güvenli Değil";
                }
                users.Add(user);
                return user.Name + " Olarak Başarıyla Kaydoldunuz";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdatePassword(int userId, string password)
        {
            try
            {
                if (!IsPasswordComplete(password))
                {
                    return "Şifre Yeteri Kadar Güvenli Değil";
                }
                foreach (User item in users)
                {
                    if (item.Id == userId)
                    {
                        item.Password = password;
                        return "Şifreniz Başarıyla Güncellendi";
                    }
                }
                return "Kullanıcı Bulunamadı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool LoginControl(string userName, string password)
        {
            try
            {
                foreach (User item in users)
                {
                    if (item.Name == userName && item.Password == password)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        bool IsUserComplete(User user)
        {
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.Question) || string.IsNullOrEmpty(user.Answer))
            {
                return false;
            }
            return true;
        }

        bool IsPasswordComplete(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            if (password.Length < 8 || password.Contains("123456"))
            {
                return false;
            }
            return true;
        }

        public static UserManager GetInstance()
        {
            if (userManager == null)
            {
                userManager = new UserManager();
            }
            return userManager;
        }

        public int GetUserIdByUserName(string userName)
        {
            foreach (User item in users)
            {
                if (item.Name == userName)
                {
                    return item.Id;
                }
            }
            return -1;
        }

        public string GetUserQuestionByUserId(int userId)
        {
            foreach (User item in users)
            {
                if (item.Id == userId)
                {
                    return item.Question;
                }
            }
            return "";
        }

        public bool ControlAnswer(int userId, string answer)
        {
            answer = answer.Trim();
            foreach (User item in users)
            {
                if (item.Id == userId && item.Answer == answer)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
