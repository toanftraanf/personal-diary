using PersonalDiary.Models;
using PersonalDiary.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalDiary
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        #region Events
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }
        private void btnSignup_Click(object sender, EventArgs e)
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
                if (IsColliedUser(txtUsername.Text))
                {
                    MessageBox.Show(
                        "This username has been used"
                        , "Error"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
                else
                {
                    if (!txtPassword.Text.Equals(txtConfirm.Text))
                    {
                        MessageBox.Show(
                            "Confirm password is incorrect"
                            , "Error"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                    }
                    else
                    {
                        Signup(txtUsername.Text, txtPassword.Text);
                        this.Hide();
                        LoginForm login = new LoginForm();
                        login.ShowDialog();
                    }
                }
            }
        }
        #endregion

        #region Methods
        private bool IsColliedUser(string username)
        {
            using (diarylvl10_dbContext context = new diarylvl10_dbContext())
            {
                var isCollied = context.Users.FirstOrDefault(u => u.Username == username);
                if (isCollied != null)
                {
                    return true;
                }
                return false;
            }
        }

        private void Signup(string username, string password)
        {
            using (diarylvl10_dbContext context = new diarylvl10_dbContext())
            {
                User user = new User()
                {
                    Username = username,
                    Password = password,
                    UserRole = 4
                };
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        #endregion
    }
}
