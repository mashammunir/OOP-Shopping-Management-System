using System;
using System.Windows.Forms;

namespace SteliaGUI
{
    public partial class DeliveryDashboardForm : Form, IDashboard
    {
        private DataAccess dataAccess = new DataAccess();
        private User currentUser;

        public DeliveryDashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblWelcome.Text = "Welcome, " + user.Username;
            LoadData();
        }

        public void LoadData()
        {
            LoadDeliveries();
        }

        public void HandleLogout()
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void LoadDeliveries()
        {
            dgvDeliveries.Rows.Clear();
            dgvDeliveries.Columns.Clear();
            dgvDeliveries.Columns.Add("Customer", "Customer");
            dgvDeliveries.Columns.Add("Phone", "Phone");
            dgvDeliveries.Columns.Add("Address", "Delivery Address");
            dgvDeliveries.Columns.Add("Product", "Product");
            dgvDeliveries.Columns.Add("Qty", "Quantity");
            dgvDeliveries.Columns.Add("Total", "Total (Rs.)");
            dgvDeliveries.Columns.Add("Status", "Status");

            foreach (var o in dataAccess.GetAllOrders())
                dgvDeliveries.Rows.Add(
                    o.CustomerName,
                    o.Phone,
                    o.Address,
                    o.ProductName,
                    o.Quantity,
                    o.TotalPrice,
                    o.Status);
        }

        private void btnMarkDelivered_Click(object sender, EventArgs e)
        {
            if (dgvDeliveries.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Please select an order!", "Stelia Fashion");
                return;
            }
            int index = dgvDeliveries.SelectedRows[0].Index;
            dataAccess.UpdateOrderStatus(index, "Delivered");
            CustomMessageBox.Show("Marked as Delivered!", "Stelia Fashion");
            LoadData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HandleLogout();
        }
    }
}