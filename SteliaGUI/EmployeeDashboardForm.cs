using System;
using System.Windows.Forms;

namespace SteliaGUI
{
    // INTERFACE IMPLEMENTATION — EmployeeDashboardForm implements IDashboard
    public partial class EmployeeDashboardForm : Form, IDashboard
    {
        private DataAccess dataAccess = new DataAccess();
        private User currentUser;

        public EmployeeDashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblWelcome.Text = "Welcome, " + user.Username;
            LoadData(); // INTERFACE METHOD
        }

        // INTERFACE METHOD IMPLEMENTATION
        public void LoadData()
        {
            LoadOrders();
        }

        // INTERFACE METHOD IMPLEMENTATION
        public void HandleLogout()
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void LoadOrders()
        {
            dgvOrders.Rows.Clear();
            dgvOrders.Columns.Clear();
            dgvOrders.Columns.Add("Customer", "Customer");
            dgvOrders.Columns.Add("Product", "Product");
            dgvOrders.Columns.Add("Qty", "Quantity");
            dgvOrders.Columns.Add("Total", "Total (Rs.)");
            dgvOrders.Columns.Add("Address", "Delivery Address");
            dgvOrders.Columns.Add("Status", "Status");

            foreach (var o in dataAccess.GetAllOrders())
                dgvOrders.Rows.Add(
                    o.CustomerName,
                    o.ProductName,
                    o.Quantity,
                    o.TotalPrice,
                    o.Address,
                    o.Status);
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Please select an order!", "Stelia Fashion");
                return;
            }
            int index = dgvOrders.SelectedRows[0].Index;
            dataAccess.UpdateOrderStatus(index, "Processing");
            CustomMessageBox.Show("Order status updated to Processing!", "Stelia Fashion");
            LoadData(); // INTERFACE METHOD CALLED
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HandleLogout(); // INTERFACE METHOD CALLED
        }
    }
}