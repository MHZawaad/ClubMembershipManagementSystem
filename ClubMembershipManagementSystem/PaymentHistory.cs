using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubMembershipManagementSystem
{
    public partial class PaymentHistory : Form
    {

        private Functions Con;
        int key = 0;

        public PaymentHistory()
        {
            InitializeComponent();
            Con = new Functions();
            ListerPaymentHistory();
        }

        public void ListerPaymentHistory()
        {
            var className = GetType().Name;
            String Query = $"SELECT * FROM {className}";
            Lister.DataSource = Con.GetData(Query);

            PaymentHistoryIDtb.Text = "Search Only";
            MemberShipIdtb.Clear();
            Totaltb.Clear();
            AmountPaidtb.Clear();

        }

        private void Refresh_Click_1(object sender, EventArgs e)
        {
            ListerPaymentHistory();
        }

        private void Search_Click(object sender, EventArgs e)
        {

            try
            {

                string Query = "SELECT * FROM PaymentHistory WHERE 1=1";
                bool hasCondition = false;

                if (!string.IsNullOrWhiteSpace(PaymentHistoryIDtb.Text))
                {
                    string fullNameQuery = PaymentHistoryIDtb.Text;
                    Query += $" AND PaymentHistoryId LIKE '%{fullNameQuery}%'";
                    hasCondition = true;
                }

                if (!string.IsNullOrWhiteSpace(MemberShipIdtb.Text))
                {
                    string fullNameQuery = MemberShipIdtb.Text;
                    Query += $" AND MembershipId LIKE '%{fullNameQuery}%'";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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


                DataTable previousPayment = Con.GetData($"SELECT TOP 1 * FROM PaymentHistory WHERE MembershipId = {membershipId} ORDER BY PaymentDate DESC");
                decimal prevBalance = 0;
                if (previousPayment.Rows.Count > 0)
                {
                    prevBalance = Convert.ToDecimal(previousPayment.Rows[0]["Balance"]);
                }


                decimal total = decimal.Parse(Totaltb.Text);


                DataTable packageData = Con.GetData($"SELECT PackageDiscount FROM Packages WHERE PackageID = (SELECT PackageID FROM Membership WHERE MembershipId = {membershipId})");
                decimal packageDiscount = 0;
                if (packageData.Rows.Count > 0)
                {
                    packageDiscount = Convert.ToDecimal(packageData.Rows[0]["PackageDiscount"]); // Change this line to match the actual column name
                }


                decimal deduction = total * packageDiscount / 100;
                decimal netTotal = total - deduction + prevBalance;
                decimal balance = netTotal - amountPaid;


                string insertQuery = $"INSERT INTO PaymentHistory (MembershipId, Total, Deduction, PrevBalance, NetTotal, AmountPaid, Balance, PaymentDate) " +
                                     $"VALUES ({membershipId}, {total}, {deduction}, {prevBalance}, {netTotal}, {amountPaid}, {balance}, '{paymentDate}')";
                Con.SetData(insertQuery);

                MessageBox.Show("Payment record added successfully.");
                ListerPaymentHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Lister.SelectedRows.Count > 0)
                {
                    int PaymentHistoryID = Convert.ToInt32(Lister.SelectedRows[0].Cells[0].Value);


                    string deleteQuery = $"DELETE FROM PaymentHistory WHERE PaymentHistoryId = {PaymentHistoryID}";
                    Con.SetData(deleteQuery);

                    MessageBox.Show("Payment record deleted successfully.");
                    ListerPaymentHistory();
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PaymentHistoryIDtb_TextChanged(object sender, EventArgs e)
        {

        }
    }

}






