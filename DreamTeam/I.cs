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
    public class I
    {
        public bool Insert(string invent)
        {
            BaseEntities db = new BaseEntities();
            try
            {
                Room1 room1 = new Room1();

                room1.Number = invent;
                db.Room1.Add(room1);
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
                var dRowBP = db.Room1.Where(w => w.Number == num).FirstOrDefault();

                if (dRowBP == null)
                {
                    MessageBox.Show("Ошибка в таблице Кабинет 1!\nТакого инвентарного номера не существует.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else
                {
                    db.Room1.Remove(dRowBP);
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в таблице Кабинет 1!\nВведите корректные значения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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

                var UpbP = db.Room1.Where(u => u.Number == num).FirstOrDefault();
                if (UpbP == null)
                {
                    MessageBox.Show("Ошибка в таблице Кабинет 1!\nВведите значения в поле.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                UpbP.Number = invent;
                db.SaveChanges();

            }
            catch
            {
                MessageBox.Show("Ошибка в таблице Кабинет 1!\nВведите корректные значения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
    }
}
