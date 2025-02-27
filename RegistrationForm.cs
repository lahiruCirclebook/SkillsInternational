using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsInternational
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            // Refresh Registration Number combo box to include the new entry
            LoadRegNumbers();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void mtxtMobilePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void mtxtHomePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                errorProviderEmail.SetError(txtEmail, "Invalid email format!");
            }
            else
            {
                errorProviderEmail.Clear();
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Basic email regex
            return Regex.IsMatch(email, pattern);
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void mtxtNIC_MaskChanged(object sender, EventArgs e)
        {
            if (!IsValidNIC(mtxtNIC.Text))
            {
                errorProviderNIC.SetError(mtxtNIC, "Invalid NIC format! Use 9 digits + 'V' or 12 digits.");
            }
            else
            {
                errorProviderNIC.Clear();
            }
        }

        private bool IsValidNIC(string nic)
        {
            string pattern = @"^\d{9}[Vv]$|^\d{12}$"; // Accepts both old and new NIC formats
            return Regex.IsMatch(nic, pattern);
        }

        private void mtxtNIC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void mtxtNIC_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidNIC(mtxtNIC.Text))
            {
                errorProviderNIC.SetError(mtxtNIC, "Invalid NIC format! Use 9 digits + 'V' or 12 digits.");
            }
            else
            {
                errorProviderNIC.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text from all TextBox controls
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            mtxtMobilePhone.Clear();
            mtxtHomePhone.Clear();
            txtParentName.Clear();
            mtxtNIC.Clear();
            mtxtContactNumber.Clear();

            // Reset DateTimePicker to current date
            dtpDOB.Value = DateTime.Now;

            // Reset radio buttons (assuming Male is the default selection)
            rbMale.Checked = false;
            rbFemale.Checked = false;

            // Reset ComboBox
            cmbRegNo.SelectedIndex = -1;

            // Set focus to the first field (assuming Reg No or First Name is the first field)
            txtFirstName.Focus();
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            mtxtMobilePhone.Clear();
            mtxtHomePhone.Clear();
            txtParentName.Clear();
            mtxtNIC.Clear();
            mtxtContactNumber.Clear();
            dtpDOB.Value = DateTime.Now;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cmbRegNo.SelectedIndex = -1;
            txtFirstName.Focus();

            errorProviderEmail.Clear();
            errorProviderNIC.Clear();
        }

        // Helper method to load registration numbers into combo box
        private void LoadRegNumbers()
        {
            try
            {
               
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-F7V028O\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    con.Open();
                    string query = "SELECT regNo, firstName FROM Registration ORDER BY regNo";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Create a new column to store the concatenated values
                            dt.Columns.Add("DisplayText", typeof(string), "regNo + ' - ' + firstName");

                            // Create a new row for the null option and add it to the beginning of the DataTable
                            DataRow nullRow = dt.NewRow();
                            nullRow["regNo"] = DBNull.Value;  // Set the regNo to DBNull.Value (or null)
                            nullRow["DisplayText"] = "Select a registration";  // The display text for the null option
                            dt.Rows.InsertAt(nullRow, 0);  // Insert the new row at the beginning

                            // Bind the DataTable to the ComboBox
                            cmbRegNo.DataSource = dt;
                            cmbRegNo.DisplayMember = "DisplayText";  // Show the concatenated regNo and firstName
                            cmbRegNo.ValueMember = "regNo";  // Store regNo as the value

                            // Set the default selected index to 0 (this will select the null option)
                            cmbRegNo.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading registration numbers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate all required fields
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFirstName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLastName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddress.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(mtxtMobilePhone.Text))
                {
                    MessageBox.Show("Mobile Phone is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtMobilePhone.Focus();
                    return;
                }

                

                if (string.IsNullOrWhiteSpace(txtParentName.Text))
                {
                    MessageBox.Show("Parent Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtParentName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(mtxtNIC.Text))
                {
                    MessageBox.Show("NIC is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtNIC.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(mtxtContactNumber.Text))
                {
                    MessageBox.Show("Contact Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtContactNumber.Focus();
                    return;
                }

                // Validate gender selection
                if (!rbMale.Checked && !rbFemale.Checked)
                {
                    MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get gender value
                string gender = rbMale.Checked ? "Male" : "Female";


                if (!IsValidEmail(txtEmail.Text))
                {
     
                    MessageBox.Show("Invalid email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }


                if (!IsValidNIC(mtxtNIC.Text))
                {
                    
                    MessageBox.Show("Invalid NIC format! Use 9 digits + 'V' or 12 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtNIC.Focus();
                    return;
                }



                // Establish database connection
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-F7V028O\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True"))
                {
                    con.Open();

                    // Prepare SQL insert statement
                    string query = "INSERT INTO Registration (firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                                   "VALUES (@firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dateOfBirth", dtpDOB.Value);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                        // Convert string values to integers for numeric fields
                        cmd.Parameters.AddWithValue("@mobilePhone", mtxtMobilePhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@homePhone", mtxtHomePhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@parentName", txtParentName.Text.Trim());
                        cmd.Parameters.AddWithValue("@nic", mtxtNIC.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactNo", mtxtContactNumber.Text.Trim());

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        // Show success message
                        MessageBox.Show("Student registered successfully!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear form fields for next entry
                        ClearForm();

                        // Refresh Registration Number combo box to include the new entry
                        LoadRegNumbers();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for phone numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if an item is selected in the ComboBox
                if (cmbRegNo.SelectedIndex != -1 && cmbRegNo.SelectedItem != null)
                {
                    // Get the selected item (which is a DataRowView when using a DataTable as the data source)
                    DataRowView selectedRow = cmbRegNo.SelectedItem as DataRowView;

                    // If the selectedRow is null, clear the form and return
                    if (selectedRow == null || selectedRow["regNo"] == DBNull.Value)
                    {
                        btnRegister.Enabled = true; // Disable Register button
                        btnUpdate.Enabled = false; // Disable Register button
                        ClearForm();
                        return;
                    }
                    else
                    {
                        btnRegister.Enabled = false; // Enable Register button
                        btnUpdate.Enabled = true; // Disable Register button
                    }

                    // Get the regNo value from the selected item
                    string selectedRegNo = selectedRow["regNo"].ToString(); // Access regNo from the DataRowView

                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-F7V028O\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True;"))
                    {
                        con.Open();

                        // Query to get related data from the Registration table based on regNo
                        string query = "SELECT * FROM Registration WHERE regNo = @regNo";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Add the parameter for regNo
                            cmd.Parameters.AddWithValue("@regNo", selectedRegNo);

                            // Execute the query and get the data
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read()) // If data is found for the selected regNo
                                {
                                    // Populate the input fields with the related data
                                    txtFirstName.Text = reader["firstName"].ToString();
                                    txtLastName.Text = reader["lastName"].ToString();
                                    dtpDOB.Value = Convert.ToDateTime(reader["dateOfBirth"]);
                                    // Set gender radio button
                                    string gender = reader["gender"].ToString().ToLower();
                                    if (gender == "male")
                                    {
                                        rbMale.Checked = true;
                                        rbFemale.Checked = false;
                                    }
                                    else if (gender == "female")
                                    {
                                        rbMale.Checked = false;
                                        rbFemale.Checked = true;
                                    }
                                    else
                                    {
                                        rbMale.Checked = false;
                                        rbFemale.Checked = false; // In case gender data is invalid
                                    }

                                    txtAddress.Text = reader["address"].ToString();
                                    txtEmail.Text = reader["email"].ToString();
                                    mtxtMobilePhone.Text = reader["mobilePhone"].ToString();
                                    mtxtHomePhone.Text = reader["homePhone"].ToString();

                                    txtParentName.Text = reader["parentName"].ToString();
                                    mtxtNIC.Text = reader["nic"].ToString();
                                    mtxtContactNumber.Text = reader["contactNo"].ToString();
                                }
                                else
                                {
                                    // If no data is found, clear the form
                                    ClearForm();
                                }
                            }
                        }
                    }
                }
                else
                {
                    // If no valid item is selected, clear the form
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data for the selected regNo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show the confirmation MessageBox when the Exit LinkLabel is clicked
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?", // Message to display
                "Exit Confirmation", // Title of the MessageBox
                MessageBoxButtons.YesNo, // Buttons to display
                MessageBoxIcon.Question // Icon type
            );

            // If the user clicks 'Yes', close the application
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Close the RegistrationForm
            this.Hide(); // Hides the Registration Form (current form)

            // Create a new instance of the LoginForm
            LoginForm loginForm = new LoginForm();

            // Show the LoginForm
            loginForm.Show();
        }

        private void cmbRegNo_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                // Check if an item is selected in the ComboBox
                if (cmbRegNo.SelectedIndex == -1 || cmbRegNo.SelectedItem == null)
                {
                    MessageBox.Show("Please select a registration number to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected regNo
                DataRowView selectedRow = cmbRegNo.SelectedItem as DataRowView;
                if (selectedRow == null || selectedRow["regNo"] == DBNull.Value)
                {
                    MessageBox.Show("Invalid registration number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedRegNo = selectedRow["regNo"].ToString();




                // Validate all required fields
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFirstName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLastName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddress.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(mtxtMobilePhone.Text))
                {
                    MessageBox.Show("Mobile Phone is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtMobilePhone.Focus();
                    return;
                }



                if (string.IsNullOrWhiteSpace(txtParentName.Text))
                {
                    MessageBox.Show("Parent Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtParentName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(mtxtNIC.Text))
                {
                    MessageBox.Show("NIC is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtNIC.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(mtxtContactNumber.Text))
                {
                    MessageBox.Show("Contact Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtContactNumber.Focus();
                    return;
                }

                // Validate gender selection
                if (!rbMale.Checked && !rbFemale.Checked)
                {
                    MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get gender value
                string gender = rbMale.Checked ? "Male" : "Female";


                if (!IsValidEmail(txtEmail.Text))
                {

                    MessageBox.Show("Invalid email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }


                if (!IsValidNIC(mtxtNIC.Text))
                {

                    MessageBox.Show("Invalid NIC format! Use 9 digits + 'V' or 12 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtNIC.Focus();
                    return;
                }



                // Open the SQL connection
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-F7V028O\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    con.Open();

                    // SQL Update Query (updating all fields)
                    string query = @"UPDATE Registration 
                             SET firstName = @firstName, 
                                 lastName = @lastName, 
                                 dateOfBirth = @dateOfBirth, 
                                 gender = @gender, 
                                 address = @address,
                                 email = @email, 
                                 mobilePhone = @mobilePhone, 
                                 homePhone = @homePhone, 
                                 parentName = @parentName, 
                                 nic = @nic, 
                                 contactNo = @contactNo
                             WHERE regNo = @regNo";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dateOfBirth", dtpDOB.Value);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                        // Convert string values to integers for numeric fields
                        cmd.Parameters.AddWithValue("@mobilePhone", mtxtMobilePhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@homePhone", mtxtHomePhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@parentName", txtParentName.Text.Trim());
                        cmd.Parameters.AddWithValue("@nic", mtxtNIC.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactNo", mtxtContactNumber.Text.Trim());

                        // Add regNo for WHERE clause
                        cmd.Parameters.AddWithValue("@regNo", selectedRegNo);

                        // Execute the update query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("No record was updated. Please check the selected registration number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a valid RegNo is selected
                if (cmbRegNo.SelectedIndex != -1 && cmbRegNo.SelectedItem != null)
                {
                    // Confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                                          "Confirm Deletion",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Get the selected RegNo
                        string selectedRegNo = cmbRegNo.SelectedValue.ToString();

                        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-F7V028O\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True;"))
                        {
                            con.Open();

                            // Delete query
                            string query = "DELETE FROM Registration WHERE regNo = @regNo";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                // Add parameter
                                cmd.Parameters.AddWithValue("@regNo", selectedRegNo);

                                // Execute query
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearForm();  // Clear input fields
                                    LoadRegNumbers();  // Refresh combo box
                                }
                                else
                                {
                                    MessageBox.Show("Failed to delete record. Record may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid registration number to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
