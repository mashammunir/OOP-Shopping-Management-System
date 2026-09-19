using System;
using System.Windows.Forms;

namespace SteliaGUI
{
    public partial class SignUpForm : Form
    {
        private DataAccess dataAccess = new DataAccess();
        private BusinessLogic businessLogic;

        public SignUpForm()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic(dataAccess);

            // ONLY Customer can sign up
            // Remove all other roles from dropdown
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Customer");
            cmbRole.SelectedIndex = 0;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem.ToString();

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password))
            {
                CustomMessageBox.Show("Please fill all fields!", "Stelia Fashion");
                return;
            }

            if (!businessLogic.ValidateUsername(username))
            {
                CustomMessageBox.Show(
                    "Username must be 6-15 characters!", "Stelia Fashion");
                return;
            }

            if (!businessLogic.ValidateEmail(email))
            {
                CustomMessageBox.Show("Invalid email format!", "Stelia Fashion");
                return;
            }

            if (!businessLogic.ValidatePassword(password))
            {
                CustomMessageBox.Show(
                    "Password must have min 6 chars,\n1 capital, 1 number, 1 special character!",
                    "Stelia Fashion");
                return;
            }

            if (dataAccess.FindUserByUsername(username) != null)
            {
                CustomMessageBox.Show("Username already exists!", "Stelia Fashion");
                return;
            }

            User newUser = new User
            {
                Username = username,
                Email = email,
                Password = password,
                Role = role
            };

            if (dataAccess.AddUser(newUser))
            {
                CustomMessageBox.Show(
                    "Account created successfully!\nPlease login.", "Welcome to Stelia");
                this.Close();
            }
            else
            {
                CustomMessageBox.Show("Something went wrong. Try again!", "Stelia Fashion");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}