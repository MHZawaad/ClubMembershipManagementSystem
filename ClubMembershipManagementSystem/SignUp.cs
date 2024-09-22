using System;
using System.Windows.Forms;

namespace ClubMembershipManagementSystem
{
    public partial class SignUp : Form
    {
        private Functions Con;

        public SignUp()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void Back_Click(object sender, EventArgs e) // Back button
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e) // Sign Up button
        {
            // Capture input values
            string UserName = UseraNametb.Text;
            string FullName = FullNametb.Text; // Ensure this is defined
            string Password = Passwordtb.Text;
            string ConfirmPassword = ConfirmPasswordtb.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(FullName) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (Password != ConfirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Insert into Admin table
            try
            {
                // Use string interpolation for the query
                string Query = $"INSERT INTO Admin (UserName, FullName, Password) VALUES ('{UserName}', '{FullName}', '{Password}')";

                // Execute the insert query
                Con.SetData(Query);

                MessageBox.Show("Sign Up successful! You can now log in.");

                // Redirect to login
                Login login = new Login();
                this.Hide();
                login.Show();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.Message);
            }
        }

        private void UseraNametb_TextChanged(object sender, EventArgs e) { }
        private void Passwordtb_TextChanged(object sender, EventArgs e) { }
        private void ConfirmPasswordtb_TextChanged(object sender, EventArgs e) { }
        private void DateJoineddt_ValueChanged(object sender, EventArgs e) { }
        private void FullNametb_TextChanged(object sender, EventArgs e) { }
    }
}
