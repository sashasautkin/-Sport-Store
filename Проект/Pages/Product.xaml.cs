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
    public partial class Product : Page
    {
        LoginDBEntities db;
        public Product()
        {
            InitializeComponent();
        }
        string login;
        public Product(string login, string password)
        {
            InitializeComponent();
            Login.Content = "User: " + login;
            this.login = login;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            InfoProductFromStores.ItemsSource = null;
            db = new LoginDBEntities();            
            InfoProductFromStores.ItemsSource = db.ProductFromStores.ToList(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float price = 0;
            price = Convert.ToUInt64(Price.Text);
            using (var context = new LoginDBEntities())
            {
                var product = new tableCustomer()
                {
                    UserName = login,
                    ProductName = Product1.Text,
                    Price = price
                };
                context.tableCustomers.Add(product);
                context.SaveChanges();
               
                Product1.Clear();
                Price.Clear();
                MessageBox.Show("You buy it!!");
            }
        }
    }
}
