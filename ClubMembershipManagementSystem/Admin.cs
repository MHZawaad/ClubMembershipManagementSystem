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
            String Query = $"Select * from {className}";
            Lister.DataSource = Con.GetData(Query);
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            ListerAdmin();
        }

        private void Search_Click_1(object sender, EventArgs e)
        {
            //ill enter the is in PackageSearchtb and that row will appear\
            try
            {
                string searchQuery = UserIDtb.Text;


                if (string.IsNullOrWhiteSpace(searchQuery))
                {
                    MessageBox.Show("Please enter a search term.");
                    return;
                }


                string Query = $"SELECT * FROM Admin WHERE UserID LIKE '%{searchQuery}%'";
                Lister.DataSource = Con.GetData(Query);


                UserIDtb.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Lister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Lister.SelectedRows.Count > 0)
            {

                UserNametb.Text = Lister.SelectedRows[0].Cells[1].Value.ToString();
                FullNametb.Text = Lister.SelectedRows[0].Cells[2].Value.ToString();
                Passwordtb.Text = Lister.SelectedRows[0].Cells[3].Value.ToString();

                // PackageID (first cell, index 0)
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

                //  Check the key value
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

                int result = Con.SetData(Query); // Ensure  number of affected rows

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

                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this package?",
                                                     "Confirm Deletion",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    //  delete query
                    string Query = "DELETE FROM Admin WHERE UserID={0}";
                    Query = String.Format(Query, key);

                    int result = Con.SetData(Query); //  delete command

                    if (result > 0)
                    {
                        ListerAdmin(); // Refresh 
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
