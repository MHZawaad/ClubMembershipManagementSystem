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
        public PaymentHistory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu login = new Menu();
            this.Hide();
            login.Show();
        }

        
    }
}
