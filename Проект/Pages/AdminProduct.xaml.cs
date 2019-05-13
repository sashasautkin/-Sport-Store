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
        string password;
        string login;
        public AdminProduct(string login, string password)
        {
            InitializeComponent();
            // DataContext = new ViewModel.TestViewModel();
            Login.Content = "User: " + login;
            this.password = password;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            InfoProductFromPeople.ItemsSource = null;
            db = new LoginDBEntities();
            InfoProductFromPeople.ItemsSource = db.ProductFromPeoples.ToList();
        }



        private void Add_in_Main_list(object sender, RoutedEventArgs e)
        {
            float price = 0;
            price = Convert.ToUInt64(Price.Text);
            using (var context = new LoginDBEntities())
            {
                var product = new ProductFromStore()
                {

                    UserName = UserName.Text,
                    ProductName = Product.Text,
                    Price = price

                };
                context.ProductFromStores.Add(product);
                context.SaveChanges();
                UserName.Clear();
                Product.Clear();
                Price.Clear();
                MessageBox.Show("You add in main list");
            }
        }

     

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (LoginDBEntities db = new LoginDBEntities())
            {
                float price = Convert.ToUInt64(Price.Text);
                ProductFromPeople p1 = new ProductFromPeople {UserName = UserName.Text, ProductName = Product.Text, Price =price }; 
                p1 = db.ProductFromPeoples.FirstOrDefault();
                if(p1.ProductName != null)
                {
                    db.Entry(p1).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }

        }

        private void InfoProductFromPeople_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
        
        }
    }
}
