using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperVoters
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            RoleList.SelectedIndex = -1;
            RoleList.Text = "Please select a role";
            RoleList.Items.Add("Voter");
            RoleList.Items.Add("Candidate");
            RoleList.Items.Add("Admin");

            SaveResponse.Visible = false;
        }

        private void SaveRegistration_Click(object sender, EventArgs e)
        {
            SaveResponse.Text = "";
            SaveResponse.Visible = true;
            try
            {
                string retValue = Save(RoleList.SelectedItem.ToString(), FirstName.Text, MiddleInitial.Text, LastName.Text, DateOfBirth.Text, Email.Text, Address.Text);
                SaveResponse.Text = retValue;
            }
            catch (Exception ex)
            {
                SaveResponse.Text = "An error occurred: " + ex.Message;
            }
        }

        static string Save(string role, string firstName, string middleName, string lastName, string dateOfBirth, string email, string address)
        {
            string retValue = "";
            
            try
            {
                var settings = new Properties.Settings();
                var connString = settings.SuperVotersConnectionString;

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "Insert into dbo.Register (Role, FirstName, MiddleName, LastName, DateOfBirth, Email, Address)";
                    query += " VALUES (@Role, @FirstName, @MiddleName, @LastName, @DateOfBirth, @Email, @Address)";

                    //Note the using will close the connection when done.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Role", role);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@MiddleName", middleName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            retValue = "Error inserting data into Database!";
                        else
                            retValue = "Successful";
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(retValue))
                    retValue = "Error occurred while Saving to DB: " + ex.Message;
            }

            return retValue;
        }
    }
}

