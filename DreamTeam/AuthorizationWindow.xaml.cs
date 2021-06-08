using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DreamTeam
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public static int dep;
        BaseEntities db;
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void AuthorizationClick(object sender, RoutedEventArgs e)
        {
            db = new BaseEntities();
            if (login.Text == "" || password.Password == "")
            {
                MessageBox.Show("Ошибка пустые поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (db.Users.Select(item => item.Login + " " + item.Password).Contains(login.Text + " " + password.Password))
            {
                if (login.Text == "admin")
                {
                    dep = 1;
                }
                if (login.Text == "123")
                {
                    dep = 2;
                }
            }
            else
            {
                MessageBox.Show("Ошибка логина/пароля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;

            }
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void Authorization123Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
