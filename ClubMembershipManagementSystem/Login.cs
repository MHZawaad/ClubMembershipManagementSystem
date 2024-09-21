namespace ClubMembershipManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Admin adminForm = new Admin();
            this.Hide();
            adminForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp login = new SignUp();
            this.Hide();
            login.Show();
        }
    }
}
