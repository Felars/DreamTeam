using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DreamTeam
{
    public class III
    {
        public bool Insert(string invent)
        {
            BaseEntities db = new BaseEntities();
            try
            {
                Room3 room3 = new Room3();

                room3.Number = invent;
                db.Room3.Add(room3);
                db.SaveChanges();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public bool Delete(string invent)
        {
            BaseEntities db = new BaseEntities();
            try
            {
                string num = invent;
                var dRowBP = db.Room3.Where(w => w.Number == num).FirstOrDefault();

                if (dRowBP == null)
                {
                    MessageBox.Show("Ошибка в таблице Кабинет 3!\nТакого инвентарного номера не существует.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else
                {
                    db.Room3.Remove(dRowBP);
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в таблице Кабинет 3!\nВведите корректные значения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;

        }
        public bool Update(string invent)
        {
            BaseEntities db = new BaseEntities();
            try
            {

                string num = invent;

                var UpbP = db.Room3.Where(u => u.Number == num).FirstOrDefault();
                if (UpbP == null)
                {
                    MessageBox.Show("Ошибка в таблице Кабинет 3!\nВведите значения в поле.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                UpbP.Number = invent;
                db.SaveChanges();

            }
            catch
            {
                MessageBox.Show("Ошибка в таблице Кабинет 3!\nВведите корректные значения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
    }
}