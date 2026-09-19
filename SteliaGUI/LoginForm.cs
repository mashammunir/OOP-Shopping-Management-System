using System;
using System.Windows.Forms;

namespace SteliaGUI
{
    public partial class LoginForm : Form
    {
        private DataAccess dataAccess = new DataAccess();
        private BusinessLogic businessLogic;

        public LoginForm()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic(dataAccess);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                CustomMessageBox.Show("Please enter username and password!", "Stelia Fashion");
                return;
            }

            if (dataAccess.ValidateUserCredentials(username, password, role))
            {
                User currentUser = dataAccess.FindUserByUsername(username);
                this.Hide();

                if (role == "Customer")
                {
                    CustomerDashboardForm f = new CustomerDashboardForm(currentUser);
                    f.Show();
                }
                else if (role == "Admin")
                {
                    AdminDashboardForm f = new AdminDashboardForm(currentUser);
                    f.Show();
                }
                else if (role == "Employee")
                {
                    EmployeeDashboardForm f = new EmployeeDashboardForm(currentUser);
                    f.Show();
                }
                else if (role == "Delivery")
                {
                    DeliveryDashboardForm f = new DeliveryDashboardForm(currentUser);
                    f.Show();
                }
            }
            else
            {
                CustomMessageBox.Show("Invalid credentials! Try again.", "Stelia Fashion");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm f = new SignUpForm();
            f.Show();
        }
    }
}