using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Проект
{
    class AutorizationLoginAndPassword : ILoginAndPassword
    {
        public string Login { get; set; }
        public string Password { get; set; }
        
       public string UName;
       // public AutorizationLoginAndPassword peson = null;
        public AutorizationLoginAndPassword()
        {
           
        }
        public AutorizationLoginAndPassword(string Login, string Password,string UName)
        {
            this.Login = Login;
            this.Password = Password;
            this.UName = UName;
        }
       
        public AutorizationLoginAndPassword(string login , string password)
        {
            Login = login;
           
            Password = password;
            Autorization(Login, Password);

        }
        public void Autorization(string login,string password)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-DP7LGSG;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                String query = "SELECT COUNT(1) FROM tableUser WHERE UserName=@UserName AND Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@UserName", login);
                sqlCmd.Parameters.AddWithValue("@Password",password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {

                   
                    if (login == "Admin" || login == "admin")
                    {
                      
                        MainWindowForAdmin dashboard = new MainWindowForAdmin();
                        dashboard.Show();
                       
                        
                    }
                    else
                    {
                       
                        MainWindow dashboard = new MainWindow();
                        dashboard.Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect");
                    Login = null;
                    Password = null;
                    

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
}
