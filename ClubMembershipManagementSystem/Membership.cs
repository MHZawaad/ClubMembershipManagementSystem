using System;
using System.Data;
using System.Windows.Forms;

namespace ClubMembershipManagementSystem
{
    public partial class Membership : Form
    {
        private Functions Con;
        int key = 0; // For tracking selected membership

        public Membership()
        {
            InitializeComponent();
            Con = new Functions();
            ListerMemberships(); // Load existing memberships
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
            Lister.DataSource = Con.GetData(Query); // Update to use Lister
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
                DateTime DateJoined = DateJoineddt.Value; // Get user input
                string Status = Statustb.Text;
                int PackageID = int.Parse(PackageIDtb.Text); // Assuming it's an integer

                string Query = $"INSERT INTO Membership (FullName, Address, PhoneNumber, Email, DateOfBirth, DateJoined, PackageID, Status) " +
                               $"VALUES ('{FullName}', '{Address}', '{PhoneNumber}', '{Email}', '{DateOfBirth}', '{DateJoined}', {PackageID}, '{Status}')";
                Con.SetData(Query);
                MessageBox.Show("Membership added successfully!");
                ListerMemberships(); // Refresh the list

                PaymentHistory ph = new PaymentHistory();
                ph.Show();
                this.Hide();
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
                string Status = Statustb.Text;
                int PackageID = int.Parse(PackageIDtb.Text);

                string Query = $"UPDATE Membership SET FullName='{FullName}', Address='{Address}', PhoneNumber='{PhoneNumber}', " +
                               $"Email='{Email}', DateOfBirth='{DateOfBirth}', DateJoined='{DateJoined}', PackageID={PackageID}, " +
                               $"Status='{Status}' WHERE MembershipId={key}";
                Con.SetData(Query);
                MessageBox.Show("Membership updated successfully!");
                ListerMemberships(); // Refresh the list

                

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
                    string Query = $"DELETE FROM Membership WHERE MembershipId={key}";
                    Con.SetData(Query);
                    MessageBox.Show("Membership deleted successfully!");
                    ListerMemberships(); // Refresh the list
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
                // Get selected row values
                FullNametb.Text = Lister.SelectedRows[0].Cells[1].Value.ToString();
                Adresstb.Text = Lister.SelectedRows[0].Cells[2].Value.ToString();
                PhoneNumbertb.Text = Lister.SelectedRows[0].Cells[3].Value.ToString();
                Emailtb.Text = Lister.SelectedRows[0].Cells[4].Value.ToString();
                DateOfBirthdt.Value = Convert.ToDateTime(Lister.SelectedRows[0].Cells[5].Value);
                DateJoineddt.Value = Convert.ToDateTime(Lister.SelectedRows[0].Cells[6].Value);
                PackageIDtb.Text = Lister.SelectedRows[0].Cells[7].Value.ToString();
                Statustb.Text = Lister.SelectedRows[0].Cells[8].Value.ToString();

                // Store MembershipId (first cell, index 0)
                key = Convert.ToInt32(Lister.SelectedRows[0].Cells[0].Value);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ListerMemberships(); // Reload membership data
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize the base query
                string Query = "SELECT * FROM Membership WHERE 1=1";
                bool hasCondition = false;

                // Check for Full Name input
                if (!string.IsNullOrWhiteSpace(FullNametb.Text))
                {
                    string fullNameQuery = FullNametb.Text;
                    Query += $" AND FullName LIKE '%{fullNameQuery}%'";
                    hasCondition = true;
                }

                // Check for Address input
                if (!string.IsNullOrWhiteSpace(Adresstb.Text))
                {
                    string addressQuery = Adresstb.Text;
                    Query += $" AND Address LIKE '%{addressQuery}%'";
                    hasCondition = true;
                }

                // Check for Phone Number input
                if (!string.IsNullOrWhiteSpace(PhoneNumbertb.Text))
                {
                    string phoneNumberQuery = PhoneNumbertb.Text;
                    Query += $" AND PhoneNumber LIKE '%{phoneNumberQuery}%'";
                    hasCondition = true;
                }

                // Check for Email input
                if (!string.IsNullOrWhiteSpace(Emailtb.Text))
                {
                    string emailQuery = Emailtb.Text;
                    Query += $" AND Email LIKE '%{emailQuery}%'";
                    hasCondition = true;
                }


                // Check for Stutus input
                if (!string.IsNullOrWhiteSpace(Statustb.Text))
                {
                    string statusquery = Statustb.Text;
                    Query += $" AND Status LIKE '%{statusquery}%'";
                    hasCondition = true;
                }


                // Check for Package ID input
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

                // Only execute the query if there are conditions to search for
                if (hasCondition)
                {
                    Lister.DataSource = Con.GetData(Query); // Update to use Lister
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

        
    }
}
