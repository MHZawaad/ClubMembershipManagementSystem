using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubMembershipManagementSystem
{
    public partial class Admin : Form
    {
        private Functions Con;
        int key = 0;

        public Admin()
        {
            InitializeComponent();
            Con = new Functions();
            ListerAdmin();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu login = new Menu();
            this.Hide();
            login.Show();
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            Login menu = new Login();
            this.Hide();
            menu.Show();
        }

        public void ListerAdmin()
        {
            var className = GetType().Name;
            String Query = $"SELECT * FROM {className}";
            Lister.DataSource = Con.GetData(Query);
            UserIDtb.Text = "";
            UserNametb.Text = "";
            FullNametb.Text = "";
            Passwordtb.Text = "";
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ListerAdmin();
        }

        private void Search_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM Admin WHERE 1=1";
                bool hasCondition = false;

                if (!string.IsNullOrWhiteSpace(UserIDtb.Text))
                {
                    string userIdQuery = UserIDtb.Text;
                    Query += $" AND UserID LIKE '%{userIdQuery}%'";
                    hasCondition = true;
                }

                if (!string.IsNullOrWhiteSpace(UserNametb.Text))
                {
                    string userNameQuery = UserNametb.Text;
                    Query += $" AND UserName LIKE '%{userNameQuery}%'";
                    hasCondition = true;
                }

                if (!string.IsNullOrWhiteSpace(FullNametb.Text))
                {
                    string fullNameQuery = FullNametb.Text;
                    Query += $" AND FullName LIKE '%{fullNameQuery}%'";
                    hasCondition = true;
                }

                if (!string.IsNullOrWhiteSpace(Passwordtb.Text))
                {
                    string passwordQuery = Passwordtb.Text;
                    Query += $" AND Password LIKE '%{passwordQuery}%'";
                    hasCondition = true;
                }

                if (hasCondition)
                {
                    Lister.DataSource = Con.GetData(Query);
                }
                else
                {
                    MessageBox.Show("Please enter at least one search term.");
                }

                UserIDtb.Text = "";
                UserNametb.Text = "";
                FullNametb.Text = "";
                Passwordtb.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.Message);
            }
        }

        private void Lister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Lister.SelectedRows.Count > 0)
            {
                UserIDtb.Text = Lister.SelectedRows[0].Cells[0].Value.ToString();
                UserNametb.Text = Lister.SelectedRows[0].Cells[1].Value.ToString();
                FullNametb.Text = Lister.SelectedRows[0].Cells[2].Value.ToString();
                Passwordtb.Text = Lister.SelectedRows[0].Cells[3].Value.ToString();
                key = Convert.ToInt32(Lister.SelectedRows[0].Cells[0].Value);
            }
        }

        private void Update_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (UserNametb.Text == "" || FullNametb.Text == "" || Passwordtb.Text == "")
                {
                    MessageBox.Show("Invalid text! Please fill in all fields.");
                    return;
                }

                if (key <= 0)
                {
                    MessageBox.Show("No package selected for update. Current key value: " + key);
                    return;
                }

                string Packagename = UserNametb.Text;
                string PackagePrice = FullNametb.Text;
                string PackageDiscount = Passwordtb.Text;

                string Query = "UPDATE Admin SET UserName='{0}', FullName='{1}', Password='{2}' WHERE UserID={3}";
                Query = String.Format(Query, Packagename, PackagePrice, PackageDiscount, key);

                int result = Con.SetData(Query);

                if (result > 0)
                {
                    ListerAdmin();
                    MessageBox.Show("Package name, package price, and package discount updated!");
                }
                else
                {
                    MessageBox.Show("Update failed. Please check the provided information.");
                }

                UserIDtb.Text = "";
                FullNametb.Text = "";
                Passwordtb.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (key <= 0)
                {
                    MessageBox.Show("No package selected for deletion.");
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure you want to delete this package?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string Query = "DELETE FROM Admin WHERE UserID={0}";
                    Query = String.Format(Query, key);

                    int result = Con.SetData(Query);

                    if (result > 0)
                    {
                        ListerAdmin();
                        MessageBox.Show("Package deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed. Please try again.");
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
