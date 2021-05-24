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
    /// Логика взаимодействия для DataBaseWindow.xaml
    /// </summary>
    public partial class DataBaseWindow : Window
    {
        BaseEntities db;
        public DataBaseWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new BaseEntities();
            dgogrenci.ItemsSource = db.Room1.ToList();
            dgogrenci1.ItemsSource = db.Room2.ToList();
            dgogrenci2.ItemsSource = db.Room3.ToList();
            dgogrenci3.ItemsSource = db.Users.ToList();
        }

        private void ADD1(object sender, RoutedEventArgs e)
        {
            I Insert = new I();
            dgogrenci.ItemsSource = db.Room1.ToList();
        }

        private void ADD2(object sender, RoutedEventArgs e)
        {
            II Insert = new II();
            dgogrenci1.ItemsSource = db.Room2.ToList();
        }

        private void ADD3(object sender, RoutedEventArgs e)
        {
            III Insert = new III();
            dgogrenci2.ItemsSource = db.Room3.ToList();
        }

        private void ADD4(object sender, RoutedEventArgs e)
        {
            IIII Insert = new IIII();
            dgogrenci3.ItemsSource = db.Users.ToList();
        }

        private void DEL1(object sender, RoutedEventArgs e)
        {
            I Delete = new I();
            dgogrenci.ItemsSource = db.Room1.ToList();
        }

        private void DEL2(object sender, RoutedEventArgs e)
        {
            II Delete = new II();
            dgogrenci1.ItemsSource = db.Room2.ToList();
        }

        private void DEL3(object sender, RoutedEventArgs e)
        {
            III Delete = new III();
            dgogrenci2.ItemsSource = db.Room3.ToList();
        }

        private void DEL4(object sender, RoutedEventArgs e)
        {
            IIII Delete = new IIII();
            dgogrenci3.ItemsSource = db.Users.ToList();
        }

        private void UPD1(object sender, RoutedEventArgs e)
        {
            I Update = new I();
            dgogrenci.ItemsSource = db.Room1.ToList();
        }

        private void UPD2(object sender, RoutedEventArgs e)
        {
            II Update = new II();
            dgogrenci1.ItemsSource = db.Room2.ToList();
        }

        private void UPD3(object sender, RoutedEventArgs e)
        {
            III Update = new III();
            dgogrenci2.ItemsSource = db.Room3.ToList();
        }

        private void UPD4(object sender, RoutedEventArgs e)
        {
            IIII Update = new IIII();
            dgogrenci3.ItemsSource = db.Users.ToList();
        }

        private void CHANGE(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
