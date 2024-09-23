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
    public partial class PaymentHistory : Form
    {

        private Functions Con;
        int key = 0;
        int DailyRate = 1000;
        public PaymentHistory()
        {
            InitializeComponent();
            Con = new Functions();
            ListerPaymentHistory();
        }

        public void ListerPaymentHistory()
        {

            var className = GetType().Name;
            String Query = $"Select * from {className}";
            Lister.DataSource = Con.GetData(Query);
        }
        private void Refresh_Click_1(object sender, EventArgs e)
        {
            ListerPaymentHistory();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            //ill enter the is in PackageSearchtb and that row will appear\
            try
            {
                string searchQuery = MemberShipIdtb.Text;


                if (string.IsNullOrWhiteSpace(searchQuery))
                {
                    MessageBox.Show("Please enter a search term.");
                    return;
                }


                string Query = $"SELECT * FROM PaymentHistory WHERE MemberShipId LIKE '%{searchQuery}%'";
                Lister.DataSource = Con.GetData(Query);


                MemberShipIdtb.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
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

        private void Lister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (Lister.SelectedRows.Count > 0)
            {

                MemberShipIdtb.Text = Lister.SelectedRows[0].Cells[1].Value.ToString();
                Totaltb.Text = Lister.SelectedRows[0].Cells[2].Value.ToString();
                AmountPaidtb.Text = Lister.SelectedRows[0].Cells[3].Value.ToString();

                // PackageID (first cell, index 0)
                key = Convert.ToInt32(Lister.SelectedRows[0].Cells[0].Value);
            }


        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                int membershipId = int.Parse(MemberShipIdtb.Text);
                decimal amountPaid = decimal.Parse(AmountPaidtb.Text);
                DateTime paymentDate = DateTime.Now;

                // Retrieve previous payment details
                DataTable previousPayment = Con.GetData($"SELECT TOP 1 * FROM PaymentHistory WHERE MembershipId = {membershipId} ORDER BY PaymentDate DESC");
                decimal prevBalance = 0;
                if (previousPayment.Rows.Count > 0)
                {
                    prevBalance = Convert.ToDecimal(previousPayment.Rows[0]["Balance"]);
                }

                // Calculate the days since the last payment
                DateTime lastPaymentDate = DateTime.MinValue;
                if (previousPayment.Rows.Count > 0)
                {
                    lastPaymentDate = Convert.ToDateTime(previousPayment.Rows[0]["PaymentDate"]);
                }
                decimal totalDays = (paymentDate - lastPaymentDate).Days;
                decimal total = DailyRate * (totalDays / 30); // Monthly rate

                // Retrieve package discount
                DataTable packageData = Con.GetData($"SELECT PackageDiscount FROM Packages WHERE PackageID = (SELECT PackageID FROM Membership WHERE MembershipId = {membershipId})");
                decimal packageDiscount = 0;
                if (packageData.Rows.Count > 0)
                {
                    packageDiscount = Convert.ToDecimal(packageData.Rows[0]["PackageDiscount"]); // Change this line to match the actual column name
                }

                // Perform calculations
                decimal deduction = total * packageDiscount;
                decimal netTotal = total - deduction + prevBalance;
                decimal balance = netTotal - amountPaid;

                // Insert into PaymentHistory
                string insertQuery = $"INSERT INTO PaymentHistory (MembershipId, Total, Deduction, PrevBalance, NetTotal, AmountPaid, Balance, PaymentDate) " +
                                     $"VALUES ({membershipId}, {total}, {deduction}, {prevBalance}, {netTotal}, {amountPaid}, {balance}, '{paymentDate}')";
                Con.SetData(insertQuery);

                MessageBox.Show("Payment record added successfully.");
                ListerPaymentHistory(); // Refresh the data grid
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}






