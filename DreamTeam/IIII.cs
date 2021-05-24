using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DreamTeam
{
    public class IIII
    {
        public bool Insert(string login, string password, string role)
        {
            BaseEntities db = new BaseEntities();
            try
            {
                User users = new User();

                users.Login = login;
                users.Password = password;
                users.Role = role;
                db.Users.Add(users);
                db.SaveChanges();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public bool Delete(string login)
        {
            BaseEntities db = new BaseEntities();
            try
            {
                string num = login;
                var dRowBP = db.Users.Where(w => w.Login == num).FirstOrDefault();

                if (dRowBP == null)
                {
                    MessageBox.Show("Ошибка в таблице Пользователи!\nТакого пользователя не существует.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else
                {
                    db.Users.Remove(dRowBP);
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в таблице Пользователи!\nВведите корректные значения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;

        }
        public bool Update(string login, string password, string role)
        {
            BaseEntities db = new BaseEntities();
            try
            {

                string num = login;



                var UpbP = db.Users.Where(u => u.Login == num).FirstOrDefault();
                if (UpbP == null)
                {
                    MessageBox.Show("Ошибка в таблице Пользователи!\nВведите значения в поле.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                UpbP.Login = login;
                UpbP.Password = password;
                UpbP.Role = role;
                db.SaveChanges();

            }
            catch
            {
                MessageBox.Show("Ошибка в таблице Пользователи!\nВведите корректные значения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
    }
}
