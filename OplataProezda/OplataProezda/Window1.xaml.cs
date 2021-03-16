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

namespace OplataProezda
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mWin = new MainWindow();
            mWin.logins[0] = LoginReg.Text;
            mWin.passwords[0] = PassReg.Password;
            MessageBox.Show("Регистрация прошла успешно!");
            mWin.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mWin = new MainWindow();
            mWin.Show();
            this.Close();
        }
    }
}
