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
using System.Data.SqlClient;
using System.Data;

namespace Проект.Pages
{
    /// <summary>
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Page
    {
        public Account()
        {
            InitializeComponent();
            DataContext = new ViewModel.TestViewModel();
            
        }
        public Account(string login ,string password)
        {
            InitializeComponent();
            DataContext = new ViewModel.TestViewModel();
            Login.Content = "User:" + login;
            passwordLable.Content = "Password:" + password; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
