using PersonalDiary.Models;
using PersonalDiary.Utils;

namespace PersonalDiary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnSignin_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            if (validation.ValidateString(
                txtUsername.Text
                , "^[a-z0-9_-]{2,15}$"
                , "Username"
                , "Length: 2-15 characters\n" +
                "Allows containing '_', '-'") &&
                validation.ValidateString(
                txtPassword.Text
                , "^[a-z0-9_-]{2,15}$"
                , "Password"
                , "Length: 2-15 characters\n" +
                "Allows containing '_', '-'"))
            {
                if (Login(txtUsername.Text, txtPassword.Text))
                {
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupForm signup = new SignupForm();
            signup.ShowDialog();
        }

        #region Methods
        /// <summary>
        /// Check if account user signed in is valid or not
        /// </summary>
        /// <param name="username">Username of user's account</param>
        /// <param name="password">Password of user's account</param>
        /// <returns>True if exists, otherwise false</returns>
        private Boolean Login(string username, string password)
        {
            using (diarylvl10_dbContext context = new diarylvl10_dbContext())
            {
                var user = context.Users
                                .FirstOrDefault(item => item.Username == username
                                && item.Password == password);
                return user != null;
            }
        }
        #endregion


    }
}