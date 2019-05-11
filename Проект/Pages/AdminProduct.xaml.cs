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
using Проект.DataContext;

namespace Проект.Pages
{
    /// <summary>
    /// Логика взаимодействия для Items.xaml
    /// </summary>
    public partial class AdminProduct : Page
    {
        LoginDBEntities db;
        public AdminProduct()
        {
            InitializeComponent();
        }
        public AdminProduct(string login, string password)
        {
            InitializeComponent();
           // DataContext = new ViewModel.TestViewModel();
            Login.Content = "User" + login;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            InfoProductFromPeople.ItemsSource = null;
            db = new LoginDBEntities();
          
            
            InfoProductFromPeople.ItemsSource = db.ProductFromPeoples.ToList(); 
        }
    }
}
