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
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Membership member = new Membership();
            this.Hide();
            member.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            PurchaseHistory ph = new PurchaseHistory();
            this.Hide();
            ph.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Packages packages = new Packages();
            this.Hide();
            packages.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            PaymentHistory adminForm = new PaymentHistory();
            this.Hide();
            adminForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Perks adminForm = new Perks();
            this.Hide();
            adminForm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                Login login = new Login();
                this.Hide();
                login.Show();
            
        }
    }
}
