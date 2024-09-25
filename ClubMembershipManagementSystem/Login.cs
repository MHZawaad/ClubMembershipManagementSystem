using System;
using System.Data;
using System.Windows.Forms;

namespace ClubMembershipManagementSystem
{
    public partial class Login : Form
    {
        private Functions Con;

        public Login()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            
            string UserName = UserNametb.Text;
            string Password = Passwordtb.Text;

            
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            
            try
            {
                string Query = $"SELECT * FROM Admin WHERE UserName = '{UserName}' AND Password = '{Password}'";
                DataTable result = Con.GetData(Query);

                if (result.Rows.Count > 0)
                {
                    
                    Menu adminForm = new Menu();
                    this.Hide();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.Message);
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }

        private void UserNametb_TextChanged(object sender, EventArgs e) { }

        private void Passwordtb_TextChanged(object sender, EventArgs e) { }
    }
}
