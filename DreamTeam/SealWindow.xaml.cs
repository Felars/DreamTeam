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
using System.Data.SqlClient;

namespace DreamTeam
{
    /// <summary>
    /// Логика взаимодействия для SealWindow.xaml
    /// </summary>
    public partial class SealWindow : Window
    {
        BaseEntities db;
        public SealWindow()
        {
            InitializeComponent();

            string stmt = "SELECT COUNT(Number) FROM Room1";
            int count = 0;
            using (SqlConnection thisConnection = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;attachdbfilename=|DataDirectory|\\Base.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;"))

            using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
            {
                thisConnection.Open();
                count = (int)cmdCount.ExecuteScalar();
                AllCount.Text = Convert.ToString(count);
                thisConnection.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new BaseEntities();
            Numbers.ItemsSource = db.Room1.ToList();
        }
        private void Print_Click(object sender, RoutedEventArgs e)
        {
            Print.Visibility = Visibility.Hidden;
            Menus.Visibility = Visibility.Hidden;
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(Grid, "Печать");
                Print.Visibility = Visibility.Visible;
                Menus.Visibility = Visibility.Visible;
            }
        }

        private void Menu(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
