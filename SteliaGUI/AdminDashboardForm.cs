using System;
using System.Windows.Forms;

namespace SteliaGUI
{
    // INTERFACE IMPLEMENTATION 
   public partial class AdminDashboardForm : Form, IDashboard
    {
       private DataAccess dataAccess = new DataAccess();
        private User currentUser;

        public AdminDashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblWelcome.Text = "Welcome, " + user.Username;
            LoadData(); // INTERFACE METHOD
        }

        // INTERFACE METHOD IMPLEMENTATION
        public void LoadData()
        {
            LoadProducts();
            LoadUsers();
            LoadOrders();
            LoadStock();
            LoadSalesReport();
        }

        // INTERFACE METHOD IMPLEMENTATION
        public void HandleLogout()
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void LoadProducts()
        {
            dgvProducts.Rows.Clear();
            dgvProducts.Columns.Clear();
            dgvProducts.Columns.Add("Name", "Product Name");
            dgvProducts.Columns.Add("Brand", "Brand");
            dgvProducts.Columns.Add("Category", "Category");
            dgvProducts.Columns.Add("Price", "Price (Rs.)");
            dgvProducts.Columns.Add("Discount", "Discount");
            dgvProducts.Columns.Add("Stock", "Stock");

            foreach (var p in dataAccess.GetAllProducts())
                dgvProducts.Rows.Add(p.Name, p.Brand, p.Category,
                    p.DiscountedPrice, p.DiscountPercent + "% OFF", p.Stock);
        }

        private void LoadUsers()
        {
            dgvUsers.Rows.Clear();
            dgvUsers.Columns.Clear();
            dgvUsers.Columns.Add("Username", "Username");
            dgvUsers.Columns.Add("Email", "Email");
            dgvUsers.Columns.Add("Role", "Role");

            foreach (var u in dataAccess.GetAllUsers())
                dgvUsers.Rows.Add(u.Username, u.Email, u.Role);
        }

        private void LoadOrders()
        {
            dgvOrders.Rows.Clear();
            dgvOrders.Columns.Clear();
            dgvOrders.Columns.Add("Customer", "Customer");
            dgvOrders.Columns.Add("Product", "Product");
            dgvOrders.Columns.Add("Qty", "Quantity");
            dgvOrders.Columns.Add("Total", "Total (Rs.)");
            dgvOrders.Columns.Add("Status", "Status");

            foreach (var o in dataAccess.GetAllOrders())
                dgvOrders.Rows.Add(o.CustomerName, o.ProductName,
                    o.Quantity, o.TotalPrice, o.Status);
        }

        private void LoadStock()
        {
            dgvStock.Rows.Clear();
            dgvStock.Columns.Clear();
            dgvStock.Columns.Add("Name", "Product Name");
            dgvStock.Columns.Add("Brand", "Brand");
            dgvStock.Columns.Add("Category", "Category");
            dgvStock.Columns.Add("Stock", "Stock");
            dgvStock.Columns.Add("Price", "Price (Rs.)");

            foreach (var p in dataAccess.GetAllProducts())
                dgvStock.Rows.Add(p.Name, p.Brand, p.Category,
                    p.Stock, p.DiscountedPrice);
        }

        private void LoadSalesReport()
        {
            var orders = dataAccess.GetAllOrders();
           int totalSales = 0;
            foreach (var o in orders) totalSales += o.TotalPrice;
            lblTotalOrders.Text = orders.Count.ToString();
            lblTotalSales.Text = "Rs." + totalSales.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
          string name = CustomInputBox.Show("Product Name:", "Add Product");
           if (string.IsNullOrEmpty(name)) return;

            string brand = CustomInputBox.Show("Brand:", "Add Product");
            string category = CustomInputBox.Show("Category:", "Add Product");
            string priceStr = CustomInputBox.Show("Original Price:", "Add Product");
            string discStr = CustomInputBox.Show("Discount %:", "Add Product");
            string sizes = CustomInputBox.Show("Available Sizes (comma separated):", "Add Product");
            string color = CustomInputBox.Show("Color:", "Add Product");
            string stock = CustomInputBox.Show("Stock Quantity:", "Add Product");
            string desc = CustomInputBox.Show("Description:", "Add Product");

            int.TryParse(priceStr, out int price);
            int.TryParse(discStr, out int disc);
            int.TryParse(stock, out int stockQty);

    Product p = new Product
            {
                Name = name,
                Brand = brand,
                Category = category,
                OriginalPrice = price,
                DiscountPercent = disc,
                DiscountedPrice = price * (100 - disc) / 100,
                AvailableSizes = sizes,
                Color = color,
                Stock = stockQty,
                Description = desc
            };

            dataAccess.AddProduct(p);
            CustomMessageBox.Show("Product added successfully!", "Stelia Fashion");
            LoadProducts();
            LoadStock();
            LoadSalesReport();
        }

  private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
         CustomMessageBox.Show("Please select a product!", "Stelia Fashion");
                return;
            }
          int index = dgvProducts.SelectedRows[0].Index;
         dataAccess.RemoveProduct(index);
         CustomMessageBox.Show("Product removed successfully!", "Stelia Fashion");
           LoadProducts();
            LoadStock();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Please select a product!", "Stelia Fashion");
                return;
            }

            int index = dgvProducts.SelectedRows[0].Index;
            var products = dataAccess.GetAllProducts();
            Product p = products[index];

            string stockStr = CustomInputBox.Show(
                "New Stock (current: " + p.Stock + "):", "Update Product");
            if (string.IsNullOrEmpty(stockStr)) return;

            string discStr = CustomInputBox.Show(
                "New Discount % (current: " + p.DiscountPercent + "):", "Update Product");
            if (string.IsNullOrEmpty(discStr)) return;

            if (int.TryParse(stockStr, out int newStock)) p.Stock = newStock;
            if (int.TryParse(discStr, out int newDisc))
            {
                p.DiscountPercent = newDisc;
                p.DiscountedPrice = p.OriginalPrice * (100 - newDisc) / 100;
            }

            dataAccess.UpdateProduct(index, p);
            CustomMessageBox.Show("Product updated successfully!", "Stelia Fashion");
            LoadProducts();
            LoadStock();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HandleLogout(); // INTERFACE METHOD CALLED
        }
    }
}