using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;

namespace Проект.Pages
{
    /// <summary>
    /// Логика взаимодействия для Create.xaml
    /// </summary>
    public partial class Create : Page
    {
        public Create()
        {
            InitializeComponent();
        }
        AutorizationLoginAndPassword Person = new AutorizationLoginAndPassword(); 
        public Create(string login, string password)
        {
            InitializeComponent();
            DataContext = new ViewModel.TestViewModel();
            Login.Content = "User" + login;
            Person.Login = login;
            Person.Password = password;

        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
           /* float price = 0;
            price = Convert.ToUInt64(PriceBox.Text);
            using (var context = new Product.MyDbContext())
            {
                var product = new Product.ProductFromPeople()
                {
                    
                    UserName = Person.Login,
                    ProductName = ItemBox.Text,
                    Price = price 

                };
                context.ProductFromPeoples.Add(product);
                context.SaveChanges();


            }*/

        
    }
    }
}
