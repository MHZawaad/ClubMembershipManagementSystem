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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Membership_Click(object sender, EventArgs e)
        {

            Membership member = new Membership();
            this.Hide();
            member.Show();

        }

        private void Admin_Click(object sender, EventArgs e)
        {

            Admin ph = new Admin();
            this.Hide();
            ph.Show();

        }

        private void Packages_Click(object sender, EventArgs e)
        {

            Packages packages = new Packages();
            this.Hide();
            packages.Show();

        }

        private void PaymentHistory_Click(object sender, EventArgs e)
        {

            PaymentHistory adminForm = new PaymentHistory();
            this.Hide();
            adminForm.Show();

        }

        

        private void SignOut_Click(object sender, EventArgs e)
        {
            
                Login login = new Login();
                this.Hide();
                login.Show();
            
        }
    }
}
