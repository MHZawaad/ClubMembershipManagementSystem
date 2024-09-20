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
            PackagesList.DataSource = Con.GetData(Query);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                String Packagename = PackageNametb.Text;
                String PackagePrice = PackagePricetb.Text;
                String PackageDiscount = PackageDiscounttb.Text;
                String Query = "Insert Into Packages VALUES ('{0}','{1}','{2}')";
                Query = String.Format(Query, Packagename,PackagePrice,PackageDiscount);
                Con.SetData(Query);
                ListerPackages();
                MessageBox.Show(" package name, package price and package discount added.");
                PackageNametb.Text = "";
                PackagePricetb.Text = "";
                PackageDiscounttb.Text = "";

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);            
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void PackageDiscounttb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PackagePricetb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
