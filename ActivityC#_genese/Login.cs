using Mysqlx.Expect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityC__genese
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //GET USERNAME AND PASSWORD FROM THE TEXTBOXES

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            //CHECK IF USERNAME OR PASSWORD IS EMPTY
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return; //STOP LOGIN PROCESS
            }
            
            //CREATE DATABASE CONNECTION
            DBConnect db = new DBConnect();

            try
            {
                // OPEN DATABASE

                db.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";

                //CREATE MYSQL QUERY
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                // ADD PARAMETERS TO PREVENT SQL INJECTION
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                //EXECUTE QUERY AND GET RESULTS NUMBER
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose(); // RELEASE COMMAND RESOURCES

                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    //OPEN DASHBOARD
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
    }
}
