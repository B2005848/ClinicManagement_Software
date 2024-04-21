using project_gr.Layout.AdminPage;

namespace project_gr
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = text_username.Text;
            string password = text_passwd.Text;

            if (DatabaseManager.CheckAdminLogin(username, password))
            {
                MessageBox.Show("Admin login successful!");
                AdminPage adminPage = new ();
                adminPage.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

    }
}
