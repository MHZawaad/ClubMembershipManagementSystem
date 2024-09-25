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
        int key = 0;
        
        public Packages()
        {
            InitializeComponent();
            Con = new Functions();
            ListerPackages();
        }

        public void ListerPackages()
        {

            
                var className = GetType().Name;
                String Query = $"SELECT * FROM {className}";
                PackageList.DataSource = Con.GetData(Query);

                PackageSearchtb.Text = "Search Only";
                PackageNametb.Text = "";
                PackagePricetb.Text = "";
                PackageDiscounttb.Text = "";

                
                key = 0;
            

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

                int result = Con.SetData(Query);

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



        
        private void PackagesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PackageList.SelectedRows.Count > 0)
            {
                PackageSearchtb.Text = PackageList.SelectedRows[0].Cells[1].Value.ToString();
                PackageNametb.Text = PackageList.SelectedRows[0].Cells[1].Value.ToString();
                PackagePricetb.Text = PackageList.SelectedRows[0].Cells[2].Value.ToString();
                PackageDiscounttb.Text = PackageList.SelectedRows[0].Cells[3].Value.ToString();

                
                key = Convert.ToInt32(PackageList.SelectedRows[0].Cells[0].Value);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (key <= 0)
                {
                    MessageBox.Show("No package selected for deletion.");
                    return;
                }

                
                var confirmResult = MessageBox.Show("Are you sure you want to delete this package?",
                                                     "Confirm Deletion",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    
                    string Query = "DELETE FROM Packages WHERE PackageID={0}";
                    Query = String.Format(Query, key);

                    int result = Con.SetData(Query); 

                    if (result > 0)
                    {
                        ListerPackages(); 
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


        private void PackageBack_Click(object sender, EventArgs e)
         {
             Menu adminForm = new Menu();
             this.Hide(); 
             adminForm.Show(); 
         }

         private void SignOut_Click(object sender, EventArgs e)
         {
             Login loginForm = new Login();
             this.Hide(); 
             loginForm.Show(); 
         }



        private void PackageSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM Packages WHERE 1=1"; 
                bool hasCondition = false; 

                if (!string.IsNullOrWhiteSpace(PackageSearchtb.Text))
                {
                    string packageIDQuery = PackageSearchtb.Text;
                    Query += $" AND PackageID LIKE '%{packageIDQuery}%'";
                    hasCondition = true;
                }

                if (!string.IsNullOrWhiteSpace(PackageNametb.Text))
                {
                    string packageNameQuery = PackageNametb.Text;
                    Query += $" AND PackageName LIKE '%{packageNameQuery}%'";
                    hasCondition = true;
                }

                if (!string.IsNullOrWhiteSpace(PackagePricetb.Text))
                {
                    string packagePriceQuery = PackagePricetb.Text;
                    Query += $" AND PackagePrice LIKE '%{packagePriceQuery}%'";
                    hasCondition = true;
                }

                if (!string.IsNullOrWhiteSpace(PackageDiscounttb.Text))
                {
                    string packageDiscountQuery = PackageDiscounttb.Text;
                    Query += $" AND PackageDiscount LIKE '%{packageDiscountQuery}%'";
                    hasCondition = true;
                }

                if (hasCondition)
                {
                    PackageList.DataSource = Con.GetData(Query); 
                }
                else
                {
                    MessageBox.Show("Please enter at least one search term.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void PackageRefresh_Click(object sender, EventArgs e)
        {
            
            ListerPackages();
        }

        
    }
}
