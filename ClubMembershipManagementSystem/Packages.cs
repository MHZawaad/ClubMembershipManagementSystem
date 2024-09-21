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
    public partial class Packages : Form
    {
        private Functions Con;
        public Packages()
        {
            InitializeComponent();
            Con = new Functions();
            ListerPackages();
        }

        private void ListerPackages()
        {
            String Query = "Select * from Packages";
            PackageList.DataSource = Con.GetData(Query);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PackageDiscounttb.Text == "" || PackageNametb.Text == "" || PackagePricetb.Text == "")
                {
                    MessageBox.Show("invalid text!");
                }
                else
                {

                    String Packagename = PackageNametb.Text;
                    String PackagePrice = PackagePricetb.Text;
                    String PackageDiscount = PackageDiscounttb.Text;
                    String Query = "Insert Into Packages VALUES ('{0}','{1}','{2}')";
                    Query = String.Format(Query, Packagename, PackagePrice, PackageDiscount);
                    Con.SetData(Query);
                    ListerPackages();
                    MessageBox.Show(" package name, package price and package discount added.");
                    PackageNametb.Text = "";
                    PackagePricetb.Text = "";
                    PackageDiscounttb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PackageDiscounttb.Text == "" || PackageNametb.Text == "" || PackagePricetb.Text == "")
                {
                    MessageBox.Show("Invalid text! Please fill in all fields.");
                    return;
                }

                // Debugging: Check the key value
                if (key <= 0)
                {
                    MessageBox.Show("No package selected for update. Current key value: " + key);
                    return;
                }

                string Packagename = PackageNametb.Text;
                string PackagePrice = PackagePricetb.Text;
                string PackageDiscount = PackageDiscounttb.Text;

                string Query = "UPDATE Packages SET PackageName='{0}', PackagePrice='{1}', PackageDiscount='{2}' WHERE PackageID={3}";
                Query = String.Format(Query, Packagename, PackagePrice, PackageDiscount, key);

                int result = Con.SetData(Query); // Ensure this method returns the number of affected rows

                if (result > 0)
                {
                    ListerPackages();
                    MessageBox.Show("Package name, package price, and package discount updated!");
                }
                else
                {
                    MessageBox.Show("Update failed. Please check the provided information.");
                }

                PackageNametb.Text = "";
                PackagePricetb.Text = "";
                PackageDiscounttb.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }



        int key = 0;
        private void PackagesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PackageList.SelectedRows.Count > 0)
            {
                // Make sure to get the value correctly from the selected row
                PackageNametb.Text = PackageList.SelectedRows[0].Cells[1].Value.ToString();
                PackagePricetb.Text = PackageList.SelectedRows[0].Cells[2].Value.ToString();
                PackageDiscounttb.Text = PackageList.SelectedRows[0].Cells[3].Value.ToString();

                // Set the key based on the selected row's PackageID (first cell, index 0)
                key = Convert.ToInt32(PackageList.SelectedRows[0].Cells[0].Value);
            }
        }
        
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a package is selected
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
                    // Create the delete query
                    string Query = "DELETE FROM Packages WHERE PackageID={0}";
                    Query = String.Format(Query, key);

                    int result = Con.SetData(Query); // Execute the delete command

                    if (result > 0)
                    {
                        ListerPackages(); // Refresh the package list
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
