using System;
using System.Data;
using System.Windows.Forms;

namespace ClubMembershipManagementSystem
{
    public partial class Membership : Form
    {
        private Functions Con;
        int key = 0;

        public Membership()
        {
            InitializeComponent();
            Con = new Functions();
            ListerMemberships();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void ListerMemberships()
        {
            
            
                string Query = "SELECT * FROM Membership";
                Lister.DataSource = Con.GetData(Query);

                MembershipIDtb.Text = "Search Only";
                FullNametb.Clear();
                Adresstb.Clear();
                PhoneNumbertb.Clear();
                Emailtb.Clear();
                DateOfBirthdt.Value = DateTime.Now; 
                DateJoineddt.Value = DateTime.Now; 
                DateLeftdt.Value = DateTime.Now; 
                PackageIDtb.Clear();
                Statustb.Clear();
            

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                string FullName = FullNametb.Text;
                string Address = Adresstb.Text;
                string PhoneNumber = PhoneNumbertb.Text;
                string Email = Emailtb.Text;
                DateTime DateOfBirth = DateOfBirthdt.Value;
                DateTime DateJoined = DateJoineddt.Value;
                DateTime DateLeft = DateLeftdt.Value; 
                string Status = Statustb.Text;
                int PackageID = int.Parse(PackageIDtb.Text);

                string Query = $"INSERT INTO Membership (FullName, Address, PhoneNumber, Email, DateOfBirth, DateJoined, DateLeft, PackageID, Status) " +
                               $"VALUES ('{FullName}', '{Address}', '{PhoneNumber}', '{Email}', '{DateOfBirth}', '{DateJoined}', '{DateLeft}', {PackageID}, '{Status}')";
                Con.SetData(Query);
                string lastIdQuery = "SELECT TOP 1 MembershipId FROM Membership ORDER BY MembershipId DESC";
                DataTable lastIdTable = Con.GetData(lastIdQuery);
                int membershipId = 0;

                if (lastIdTable.Rows.Count > 0)
                {
                    membershipId = Convert.ToInt32(lastIdTable.Rows[0][0]);
                }

                MessageBox.Show("Membership added successfully!");

                ListerMemberships();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (key <= 0)
                {
                    MessageBox.Show("No membership selected for update.");
                    return;
                }

                string FullName = FullNametb.Text;
                string Address = Adresstb.Text;
                string PhoneNumber = PhoneNumbertb.Text;
                string Email = Emailtb.Text;
                DateTime DateOfBirth = DateOfBirthdt.Value;
                DateTime DateJoined = DateJoineddt.Value;
                DateTime DateLeft = DateLeftdt.Value; // Get DateLeft value
                string Status = Statustb.Text;
                int PackageID = int.Parse(PackageIDtb.Text);

                string Query = $"UPDATE Membership SET FullName='{FullName}', Address='{Address}', PhoneNumber='{PhoneNumber}', " +
                               $"Email='{Email}', DateOfBirth='{DateOfBirth}', DateJoined='{DateJoined}', DateLeft='{DateLeft}', PackageID={PackageID}, " +
                               $"Status='{Status}' WHERE MembershipId={key}";
                Con.SetData(Query);
                MessageBox.Show("Membership updated successfully!");
                ListerMemberships();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (key <= 0)
                {
                    MessageBox.Show("No membership selected for deletion.");
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure you want to delete this membership?",
                                                     "Confirm Deletion",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string deletePaymentHistoryQuery = $"DELETE FROM PaymentHistory WHERE MembershipId={key}";
                    Con.SetData(deletePaymentHistoryQuery);
                    string deleteMembershipQuery = $"DELETE FROM Membership WHERE MembershipId={key}";
                    Con.SetData(deleteMembershipQuery);
                    MessageBox.Show("Membership and all associated records deleted successfully!");
                    ListerMemberships();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Lister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Lister.SelectedRows.Count > 0)
            {

                MembershipIDtb.Text = Lister.SelectedRows[0].Cells[0].Value.ToString();
                FullNametb.Text = Lister.SelectedRows[0].Cells[1].Value.ToString();
                Adresstb.Text = Lister.SelectedRows[0].Cells[2].Value.ToString();
                PhoneNumbertb.Text = Lister.SelectedRows[0].Cells[3].Value.ToString();
                Emailtb.Text = Lister.SelectedRows[0].Cells[4].Value.ToString();
                DateOfBirthdt.Value = Convert.ToDateTime(Lister.SelectedRows[0].Cells[5].Value);
                DateJoineddt.Value = Convert.ToDateTime(Lister.SelectedRows[0].Cells[6].Value);
                PackageIDtb.Text = Lister.SelectedRows[0].Cells[7].Value.ToString();
                Statustb.Text = Lister.SelectedRows[0].Cells[8].Value.ToString();


                key = Convert.ToInt32(Lister.SelectedRows[0].Cells[0].Value);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ListerMemberships();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "SELECT * FROM Membership WHERE 1=1";
                bool hasCondition = false;

                if (!string.IsNullOrWhiteSpace(MembershipIDtb.Text))
                {
                    string fullNameQuery = MembershipIDtb.Text;
                    Query += $" AND MembershipId LIKE '%{fullNameQuery}%'";
                    hasCondition = true;
                }

                if (!string.IsNullOrWhiteSpace(FullNametb.Text))
                {
                    string fullNameQuery = FullNametb.Text;
                    Query += $" AND FullName LIKE '%{fullNameQuery}%'";
                    hasCondition = true;
                }


                if (!string.IsNullOrWhiteSpace(Adresstb.Text))
                {
                    string addressQuery = Adresstb.Text;
                    Query += $" AND Address LIKE '%{addressQuery}%'";
                    hasCondition = true;
                }


                if (!string.IsNullOrWhiteSpace(PhoneNumbertb.Text))
                {
                    string phoneNumberQuery = PhoneNumbertb.Text;
                    Query += $" AND PhoneNumber LIKE '%{phoneNumberQuery}%'";
                    hasCondition = true;
                }


                if (!string.IsNullOrWhiteSpace(Emailtb.Text))
                {
                    string emailQuery = Emailtb.Text;
                    Query += $" AND Email LIKE '%{emailQuery}%'";
                    hasCondition = true;
                }



                if (!string.IsNullOrWhiteSpace(Statustb.Text))
                {
                    string statusquery = Statustb.Text;
                    Query += $" AND Status LIKE '%{statusquery}%'";
                    hasCondition = true;
                }



                if (!string.IsNullOrWhiteSpace(PackageIDtb.Text))
                {
                    int packageId;
                    if (int.TryParse(PackageIDtb.Text, out packageId))
                    {
                        Query += $" AND PackageID = {packageId}";
                        hasCondition = true;
                    }
                    else
                    {
                        MessageBox.Show("Package ID must be a number.");
                        return;
                    }
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

        private void DateLeftdt_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
