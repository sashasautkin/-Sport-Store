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
using System.Data.SqlClient;
using System.Data;

namespace Проект
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public string Title1
        {
            get { return (string)GetValue(Title1Property); } //(string)GetValue(Title1Property)
            set { SetValue(Title1Property, value); }
        }
        public static readonly DependencyProperty Title1Property =
        DependencyProperty.Register("Title1", typeof(string), typeof(LoginPage));
        IUIAbstractFactory Person = null;
        public LoginPage()
        {
            InitializeComponent();
            txtUsername.Focus();
            Person = new AutorizationFactory();
            Title1 = Person.getType().Type; 
        }
        static  public string uUName;
        static public string uPassword; 
        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {           
            if (Sign_on.IsChecked == true)
            {
                uUName = txtUsername.Text;
                uPassword = txtPassword.Password;
                SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-DP7LGSG;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
                try
                {
                    if (sqlCon.State == System.Data.ConnectionState.Closed)
                        sqlCon.Open();
                    String query = "SELECT COUNT(1) FROM tableUser WHERE UserName=@UserName AND Password=@Password";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.CommandType = System.Data.CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    if (count == 1)
                    {
                        Person.getLoginAndPassword(txtUsername.Text, txtPassword.Password);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect");                     
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }         
            }
            else
            {
                uUName = txtUsername.Text;
                uPassword = txtPassword.Password;
                SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-DP7LGSG;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
                try
                {
                    if (sqlCon.State == System.Data.ConnectionState.Closed)
                        sqlCon.Open();
                    String query = "SELECT COUNT(1) FROM tableUser WHERE UserName=@UserName ";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.CommandType = System.Data.CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    if (count == 1)
                    {
                        MessageBox.Show("This Account exists");                       
                    }
                    else
                    {
                        Person.getLoginAndPassword(txtUsername.Text, txtPassword.Password);                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }          
            }
        }
        private void Sign_up_Checked(object sender, RoutedEventArgs e)
        {
            Person = new RegistrationFactory();
            Title1 = Person.getType().Type;            
        }
        private void Sign_on_Checked(object sender, RoutedEventArgs e)
        {
            Person = new AutorizationFactory();
            Title1 = Person.getType().Type;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
