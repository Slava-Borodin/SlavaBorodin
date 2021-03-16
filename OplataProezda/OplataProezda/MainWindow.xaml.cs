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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OplataProezda
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] logins = new string[2];
        public string[] passwords = new string[2];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < logins.Length; i++)
            {
                for (int j = 0; j < passwords.Length; j++)
                {
                    if(Login.Text == logins[i] && Password.Password == passwords[i]) 
                    {
                        Window2 win2 = new Window2();
                        MessageBox.Show("Вход выполнен!");
                        win2.Show();
                        break;
                    }
                }
            }
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
