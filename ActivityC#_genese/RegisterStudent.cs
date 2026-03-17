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
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            // DECLARATION INPUTS
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string course = cmbCourse.SelectedItem.ToString();
            string section = cmbSection.SelectedItem.ToString();
            int age;

            // VALIDATE INPUTS IF EMPTY
            if (string.IsNullOrEmpty(firstname) ||
                string.IsNullOrEmpty(lastname) ||
                string.IsNullOrEmpty(course) ||
                string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please fill all fields");
                return; // STOP PROCESS
            }

            // VALIDATE INPUT FOR AGE)
            if (!int.TryParse(txtAge.Text.Trim(), out age))
            {
                MessageBox.Show("Please enter valid age");
                return; // STOP PROCESS
            }

            // CALL DATABASE CONNECTION
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "INSERT INTO students (firstname, lastname, course, section, age) VALUES (@firstname, @lastname, @course, @section, @age)";

                // CREATE SQL COMMAND

                //CREATE MYSQL QUERY
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                // ADD PARAMETERS
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@section", section);
                cmd.Parameters.AddWithValue("@age", age);

                // EXECUTE CMD
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added successfully");

                txtFirstName.Clear();
                txtLastName.Clear();
                txtAge.Clear();
                cmbCourse.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
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
