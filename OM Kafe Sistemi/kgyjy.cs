namespace OM_Kafe_Sistemi
{
    public partial class kgyjy : Form
    {
        public kgyjy()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "OM" && password == "2005")
            {
                TableForm tableForm = new TableForm();
                tableForm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Username or password is wrong");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
