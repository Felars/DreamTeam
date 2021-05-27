using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DreamTeam
{
    /// <summary>
    /// Логика взаимодействия для Room2Window.xaml
    /// </summary>
    public partial class Room2Window : Window
    {
        BaseEntities db;
        public Room2Window()
        {
            InitializeComponent();
            db = new BaseEntities();
            //Стул
            string stmt = "SELECT COUNT(Number) FROM Room2 WHERE Object = 'Chair'";
            int count = 0;
            //Монитор
            string stmt1 = "SELECT COUNT(Number) FROM Room2 WHERE Object = 'Monitor'";
            int count1 = 0;
            //Стол
            string stmt2 = "SELECT COUNT(Number) FROM Room2 WHERE Object = 'Table'";
            int count2 = 0;
            //Системный блок
            string stmt3 = "SELECT COUNT(Number) FROM Room2 WHERE Object = 'Unit system'";
            int count3 = 0;
            //Принтер
            string stmt4 = "SELECT COUNT(Number) FROM Room2 WHERE Object = 'Printer'";
            int count4 = 0;
            //Диван
            string stmt5 = "SELECT COUNT(Number) FROM Room2 WHERE Object = 'Sofa'";
            int count5 = 0;
            //Клавиатура
            string stmt6 = "SELECT COUNT(Number) FROM Room2 WHERE Object = 'Keyboard'";
            int count6 = 0;
            //Роутер
            string stmt7 = "SELECT COUNT(Number) FROM Room2 WHERE Object = 'Router'";
            int count7 = 0;

            using (SqlConnection thisConnection = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;attachdbfilename=|DataDirectory|\\Base.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                    ChairCount.Text = Convert.ToString(count);
                    thisConnection.Close();
                }

                using (SqlCommand cmdCount = new SqlCommand(stmt1, thisConnection))
                {
                    thisConnection.Open();
                    count1 = (int)cmdCount.ExecuteScalar();
                    MonitorCount.Text = Convert.ToString(count1);
                    thisConnection.Close();
                }

                using (SqlCommand cmdCount = new SqlCommand(stmt2, thisConnection))
                {
                    thisConnection.Open();
                    count2 = (int)cmdCount.ExecuteScalar();
                    TableCount.Text = Convert.ToString(count2);
                    thisConnection.Close();
                }

                using (SqlCommand cmdCount = new SqlCommand(stmt3, thisConnection))
                {
                    thisConnection.Open();
                    count3 = (int)cmdCount.ExecuteScalar();
                    SystemUnitCount.Text = Convert.ToString(count3);
                    thisConnection.Close();
                }

                using (SqlCommand cmdCount = new SqlCommand(stmt4, thisConnection))
                {
                    thisConnection.Open();
                    count4 = (int)cmdCount.ExecuteScalar();
                    APrinterCount.Text = Convert.ToString(count4);
                    thisConnection.Close();
                }

                using (SqlCommand cmdCount = new SqlCommand(stmt5, thisConnection))
                {
                    thisConnection.Open();
                    count5 = (int)cmdCount.ExecuteScalar();
                    SofaCount.Text = Convert.ToString(count5);
                    thisConnection.Close();
                }

                using (SqlCommand cmdCount = new SqlCommand(stmt6, thisConnection))
                {
                    thisConnection.Open();
                    count6 = (int)cmdCount.ExecuteScalar();
                    KeyBoardCount.Text = Convert.ToString(count6);
                    thisConnection.Close();
                }

                using (SqlCommand cmdCount = new SqlCommand(stmt7, thisConnection))
                {
                    thisConnection.Open();
                    count7 = (int)cmdCount.ExecuteScalar();
                    RouterCount.Text = Convert.ToString(count7);
                    thisConnection.Close();
                }

            }
        }
        private void Ch_Click(object sender, RoutedEventArgs e)
        {
            db = new BaseEntities();
            Numbers.ItemsSource = db.Room2.Where(o => o.Object == "Chair").ToList();

        }

        private void Tb_Click(object sender, RoutedEventArgs e)
        {

            db = new BaseEntities();
            Numbers.ItemsSource = db.Room2.Where(o => o.Object == "Table").ToList();
        }

        private void So_Click(object sender, RoutedEventArgs e)
        {
            db = new BaseEntities();
            Numbers.ItemsSource = db.Room2.Where(o => o.Object == "Sofa").ToList();
        }

        private void Pr_Click(object sender, RoutedEventArgs e)
        {
            db = new BaseEntities();
            Numbers.ItemsSource = db.Room2.Where(o => o.Object == "Printer").ToList();
        }

        private void Sy_Click(object sender, RoutedEventArgs e)
        {
            db = new BaseEntities();
            Numbers.ItemsSource = db.Room2.Where(o => o.Object == "Unit system").ToList();
        }

        private void Key_Click(object sender, RoutedEventArgs e)
        {
            db = new BaseEntities();
            Numbers.ItemsSource = db.Room2.Where(o => o.Object == "Keyboard").ToList();
        }

        private void Mo_Click(object sender, RoutedEventArgs e)
        {
            db = new BaseEntities();
            Numbers.ItemsSource = db.Room2.Where(o => o.Object == "Monitor").ToList();
        }

        private void Ro_Click(object sender, RoutedEventArgs e)
        {
            db = new BaseEntities();
            Numbers.ItemsSource = db.Room2.Where(o => o.Object == "Router").ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
