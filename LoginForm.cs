using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsInternational
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // SQL Connection String (Update with your actual connection details)
        string connectionString = "Server=DESKTOP-F7V028O\\SQLEXPRESS;Database=Student;Integrated Security=True;TrustServerCertificate=True;";

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

           
                // Get the entered username and password
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                // Validate inputs
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }

                // Create database connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to check if credentials exist
                    string query = "SELECT COUNT(*) FROM Logins WHERE username = @username AND password = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            // Login successful
                            this.Hide(); // Hide the login form

                            // Create and show the Registration form
                            RegistrationForm regForm = new RegistrationForm();
                            regForm.Show();

                        }
                        else
                        {
                            // Login failed - show error message as per requirements
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Clear the password field only
                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus(); // Set focus back to the username field
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
