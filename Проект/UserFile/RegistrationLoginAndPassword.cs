using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Проект
{
    class RegistrationLoginAndPassword : ILoginAndPassword
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string UName;
        
        


        public  RegistrationLoginAndPassword(string login,string password)
        {
            Login = login;
            Password = password;
            Registration(Login, Password);
        }
        public void Registration(string login,string password)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-DP7LGSG;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                String query = "SELECT COUNT(1) FROM tableUser WHERE UserName=@UserName ";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@UserName", login);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MessageBox.Show("This Account exists");
                    
                    Login = null;
                    Password = null;
                    UName = null;
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DP7LGSG;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"))
                    {
                        connection.Open();
                        SqlDataAdapter dt = new SqlDataAdapter("select count (*) From tableUser where UserName = ' " + login + "'AND Password = '" + password + "'", connection);

                        DataTable table = new DataTable();
                        dt.Fill(table);



                        if (table.Rows[0][0].ToString() == "0")
                        {
                            if ((login != "") || (password != ""))
                            {
                               

                                UName = login;
                                SqlCommand comand = new SqlCommand("INSERT Into tableUser (UserName,Password) Values(@UserName,@Password)", connection);
                                comand.Parameters.AddWithValue("UserName", login);
                                comand.Parameters.AddWithValue("Password", password);
                                comand.ExecuteNonQuery();
                                MessageBox.Show("Ви успішно зареєструвалися");
                                MainWindow dashboard = new MainWindow();
                                dashboard.Show();


                            }
                           


                        }
                        
                    }
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


