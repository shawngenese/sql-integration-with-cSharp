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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.AddRange(new string[] { "ACT", "BSOA", "HM" });
            cmbSection.Items.AddRange(new string[] { "1A", "1B", "1C", "1D", "1E" });
            LoadStudents();
        }
        private void LoadStudents()
        {
            string search = txtSearch.Text.Trim();

            // CREATE DATABASE CONNECTION
            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = "SELECT * FROM students WHERE " +
                    "firstname LIKE @search " +
                    "OR lastname LIKE @search " +
                    "OR course LIKE @search " +
                    "OR section LIKE @search";

                // CREATE MYSQL COMMAND
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                // DECLARE DATAADAPTER FOR DATA TABLE WITH THE QUERY RESULTS
                MySql.Data.MySqlClient.MySqlDataAdapter adapter =
                    new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                // CREATE A DATA TABLE
                System.Data.DataTable table = new System.Data.DataTable();

                // FILL TABLE
                adapter.Fill(table);
                dgvStudents.DataSource = table;

                // CHANGE COLUMN HEADERS
                dgvStudents.Columns["id"].HeaderText = "Student ID";
                dgvStudents.Columns["firstname"].HeaderText = "First Name";
                dgvStudents.Columns["lastname"].HeaderText = "Last Name";
                dgvStudents.Columns["course"].HeaderText = "Course";
                dgvStudents.Columns["section"].HeaderText = "Section";
                dgvStudents.Columns["age"].HeaderText = "Age";
                adapter.Dispose(); // reset value after used
                cmd.Dispose(); // reset value after used
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                // TRANSFER DATA FROM TABLE TO TEXTBOXES
                txtID.Text = row.Cells["id"].Value.ToString();
                txtFirstName.Text = row.Cells["firstname"].Value.ToString();
                txtLastName.Text = row.Cells["lastname"].Value.ToString();
                cmbCourse.Text = row.Cells["course"].Value.ToString();
                cmbSection.Text = row.Cells["section"].Value.ToString();
                txtAge.Text = row.Cells["age"].Value.ToString();
            }
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            // DECLARATION INPUTS
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string course = cmbCourse.SelectedItem.ToString();
            string section = cmbSection.SelectedItem.ToString();
            int age;
            int ID;

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
            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please Select Record");
                return; // STOP PROCESS
            }

            // CALL DATABASE CONNECTION
            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = @"UPDATE students
                SET firstname=@firstname,
                    lastname=@lastname,
                    course=@course,
                    section=@section,
                    age=@age
                WHERE id=@id";

                // CREATE COMMAND

                //CREATE MYSQL QUERY
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                // ADD PARAMETERS
                cmd.Parameters.AddWithValue("@id",txtID.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@course", cmbCourse.Text);
                cmd.Parameters.AddWithValue("@section", cmbSection.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);

                // EXECUTE COMMAND
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully");
                txtID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                cmbCourse.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                txtAge.Clear();

                // UPDATE THE TABLE IN DATA GRID VIEW
                LoadStudents();
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

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            // DELETE
            int ID;
            // VALIDATE ID
            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please Select Record to Delete");
                return; // STOP PROCESS
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return; // STOP PROCESS
            }

            // CALL DATABASE CONNECTION
            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = "DELETE FROM students WHERE id=@id";

                //CREATE MYSQL QUERY
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Record Deleted Successfully");

                txtID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                cmbCourse.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                txtAge.Clear();

                LoadStudents();


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
