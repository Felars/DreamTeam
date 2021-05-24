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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (AuthorizationWindow.dep == 2)
            {
                BD.Visibility = Visibility.Collapsed;
            }
        }

        private void KB1(object sender, RoutedEventArgs e)
        {
            Room1Window room1window = new Room1Window();
            room1window.Show();
            this.Close();
        }

        private void KB2(object sender, RoutedEventArgs e)
        {
            Room2Window room2window = new Room2Window();
            room2window.Show();
            this.Close();
        }

        private void KB3(object sender, RoutedEventArgs e)
        {
            Room3Window room3window = new Room3Window();
            room3window.Show();
            this.Close();
        }

        private void BD1(object sender, RoutedEventArgs e)
        {
            DataBaseWindow database = new DataBaseWindow();
            database.Show();
            this.Close();
        }

        private void CHANGE(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }
    }
}
