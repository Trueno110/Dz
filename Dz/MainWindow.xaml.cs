using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDb; Initial Catalog = Dz; Integrated Security = SSPI");
                connection.Open();
                MainGrid.Background = new SolidColorBrush(Colors.White);
            }
            catch
            {
                OutPutText.Text = "Error";
                MainGrid.Background = new SolidColorBrush(Colors.DarkRed);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Close();
                MainGrid.Background = new SolidColorBrush(Colors.Black);
            }
            catch
            {
                OutPutText.Text = "Error: Сервер не подключен";
                MainGrid.Background = new SolidColorBrush(Colors.DarkRed);
            }
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OutPutText.Text = "";
            string MySelect = @" Select Color From DZ";
            SqlCommand command = new SqlCommand(MySelect, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    OutPutText.Text += sqlDataReader[i] + "\t";
                }
                OutPutText.Text += "\n";
            }
            sqlDataReader.Close();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            
            OutPutText.Text = "";
            string MySelect = @" Select * From DZ";
            SqlCommand command = new SqlCommand(MySelect, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    OutPutText.Text += sqlDataReader[i] + "\t";
                }
                OutPutText.Text += "\n";
            }
            sqlDataReader.Close();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            OutPutText.Text = "";
            string MySelect = @" SELECT MAX(CaloieContent) FROM Dz";
                                   
            SqlCommand command = new SqlCommand(MySelect, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    OutPutText.Text += sqlDataReader[i] + "\t";
                }
                OutPutText.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            OutPutText.Text = "";
            string MySelect = @" SELECT MIN(CaloieContent) FROM Dz";
                                    
            SqlCommand command = new SqlCommand(MySelect, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    OutPutText.Text += sqlDataReader[i] + "\t";
                }
                OutPutText.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            OutPutText.Text = "";
            string MySelect = @" SELECT AVG(CaloieContent) FROM Dz";
                                   
            SqlCommand command = new SqlCommand(MySelect, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    OutPutText.Text += sqlDataReader[i] + "\t";
                }
                OutPutText.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            OutPutText.Text = "";
            string MySelect = @" SELECT COUNT(*)  FROM Dz Where Type='1';";

            SqlCommand command = new SqlCommand(MySelect, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    OutPutText.Text += sqlDataReader[i] + "\t";
                }
                OutPutText.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            OutPutText.Text = "";
            string MySelect = @" SELECT COUNT(*)  FROM Dz Where Type='2';";

            SqlCommand command = new SqlCommand(MySelect, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    OutPutText.Text += sqlDataReader[i] + "\t";
                }
                OutPutText.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {

        }
    }

}
