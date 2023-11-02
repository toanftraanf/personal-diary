using PersonalDiary.Models;

namespace PersonalDiary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        diarylvl10_dbContext context = new diarylvl10_dbContext();
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isValidUser(txtUsername.Text, txtPassword.Text))
                {
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region Methods
        /// <summary>
        /// Check if account user signed in is valid or not
        /// </summary>
        /// <param name="username">Username of user's account</param>
        /// <param name="password">Password of user's account</param>
        /// <returns>True if exists, otherwise false</returns>
        private Boolean isValidUser(string username, string password)
        {
            var user = context.Users
                .FirstOrDefault(item => item.Username == username && item.Password == password);

            return user != null; // If user is found, return true; otherwise, return false
        }
        #endregion

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupForm signup = new SignupForm();
            signup.ShowDialog();
        }
    }
}