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
using Проект.ViewModel;
// static Проект.LoginPage;
namespace Проект
{
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindowForAdmin : Window
    {
        AutorizationLoginAndPassword person =  null; 

        public MainWindowForAdmin()
        {
            InitializeComponent();
           
            DataContext = new MainViewModel(LoginPage.uUName, LoginPage.uPassword);
            person = new AutorizationLoginAndPassword(LoginPage.uUName,LoginPage.uPassword,LoginPage.uUName);
            UserName.Text = person.Login;
        }
     
       
        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
           LoginPage dashboard = new LoginPage();
            dashboard.Show();
            this.Close();
        }

        private void ButtonOpenMenu_Click(object sender,RoutedEventArgs e)
        {
           ButtonOpenMenu.Visibility = Visibility.Collapsed;
           ButtonCloseMenu.Visibility = Visibility.Visible;
          
        }
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

       
    }
}
