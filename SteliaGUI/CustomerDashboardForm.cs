using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SteliaGUI
{
    // INTERFACE IMPLEMENTATION — CustomerDashboardForm implements IDashboard
    public partial class CustomerDashboardForm : Form, IDashboard
    {
        private DataAccess dataAccess = new DataAccess();
        private BusinessLogic businessLogic;
        private User currentUser;
        private List<Product> allProducts;

        public CustomerDashboardForm(User user)
        {
            InitializeComponent();
            businessLogic = new BusinessLogic(dataAccess);
            currentUser = user;
            lblWelcome.Text = "Welcome, " + user.Username + "!";
            LoadData(); // INTERFACE METHOD — loads all data
        }

        // INTERFACE METHOD IMPLEMENTATION
        public void LoadData()
        {
            LoadProducts();
            LoadCart();
            LoadOrders();
            LoadWishlist();
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
            allProducts = dataAccess.GetAllProducts();
            dgvProducts.Rows.Clear();
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add("Name", "Product Name");
            dgvProducts.Columns.Add("Brand", "Brand");
            dgvProducts.Columns.Add("Category", "Category");
            dgvProducts.Columns.Add("Price", "Price (Rs.)");
            dgvProducts.Columns.Add("Discount", "Discount");
            dgvProducts.Columns.Add("Stock", "Stock");

            foreach (var p in allProducts)
            {
                dgvProducts.Rows.Add(
                    p.Name, p.Brand, p.Category,
                    p.DiscountedPrice,
                    p.DiscountPercent + "% OFF",
                    p.Stock
                );
            }
        }

        private void LoadCart()
        {
            dgvCart.Rows.Clear();
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add("Product", "Product");
            dgvCart.Columns.Add("Size", "Size");
            dgvCart.Columns.Add("Qty", "Quantity");
            dgvCart.Columns.Add("Price", "Price (Rs.)");

            int total = 0;
            foreach (var item in currentUser.Cart)
            {
                dgvCart.Rows.Add(item.ProductName, item.Size, item.Quantity, item.Price);
                total += item.Price;
            }
            lblCartTotal.Text = "Total: Rs." + total;
        }

        private void LoadOrders()
        {
            dgvOrders.Rows.Clear();
            dgvOrders.Columns.Clear();

            dgvOrders.Columns.Add("Product", "Product");
            dgvOrders.Columns.Add("Size", "Size");
            dgvOrders.Columns.Add("Qty", "Quantity");
            dgvOrders.Columns.Add("Total", "Total (Rs.)");
            dgvOrders.Columns.Add("Status", "Status");

            var orders = dataAccess.GetAllOrders();
            foreach (var o in orders)
            {
                if (o.CustomerName == currentUser.Username)
                    dgvOrders.Rows.Add(
                        o.ProductName, o.Size,
                        o.Quantity, o.TotalPrice, o.Status);
            }
        }

        private void LoadWishlist()
        {
            lstWishlist.Items.Clear();
            foreach (var item in currentUser.Wishlist)
                lstWishlist.Items.Add(item);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadProducts();
                return;
            }

            var indices = businessLogic.SearchProducts(searchTerm);
            dgvProducts.Rows.Clear();

            foreach (var i in indices)
            {
                var p = allProducts[i];
                dgvProducts.Rows.Add(
                    p.Name, p.Brand, p.Category,
                    p.DiscountedPrice,
                    p.DiscountPercent + "% OFF",
                    p.Stock
                );
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Please select a product first!", "Stelia Fashion");
                return;
            }

            string productName = dgvProducts.SelectedRows[0].Cells["Name"].Value.ToString();
            Product selected = allProducts.Find(p => p.Name == productName);

            string size = "NA";
            if (selected.Category == "Clothing" || selected.Category == "Shoes")
            {
                size = CustomInputBox.Show(
                    "Available sizes: " + selected.AvailableSizes + "\nEnter your size:",
                    "Select Size");
                if (string.IsNullOrEmpty(size)) return;
            }

            string qtyStr = CustomInputBox.Show(
                "Enter quantity (1-10):", "Quantity");

            if (string.IsNullOrEmpty(qtyStr)) return;

            if (int.TryParse(qtyStr, out int qty))
            {
                if (businessLogic.AddToCart(currentUser, selected, qty, size))
                {
                    dataAccess.SaveCartItem(currentUser.Username,
                        currentUser.Cart[currentUser.Cart.Count - 1]);
                    dataAccess.UpdateProductStock(selected.Name, selected.Stock);
                    CustomMessageBox.Show("Added to cart successfully!", "Stelia Fashion");
                    LoadCart();
                    LoadProducts();
                }
                else
                    CustomMessageBox.Show(
                        "Failed! Check quantity and stock.", "Stelia Fashion");
            }
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Please select a product first!", "Stelia Fashion");
                return;
            }

            string productName = dgvProducts.SelectedRows[0].Cells["Name"].Value.ToString();

            if (!currentUser.Wishlist.Contains(productName))
            {
                currentUser.Wishlist.Add(productName);
                dataAccess.AddToWishlist(currentUser.Username, productName);
                CustomMessageBox.Show("Added to wishlist!", "Stelia Fashion");
                LoadWishlist();
            }
            else
                CustomMessageBox.Show("Already in wishlist!", "Stelia Fashion");
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Please select an item to remove!", "Stelia Fashion");
                return;
            }

            int index = dgvCart.SelectedRows[0].Index;
            dataAccess.RemoveCartItem(currentUser.Username, index);
            currentUser.Cart.RemoveAt(index);
            CustomMessageBox.Show("Item removed from cart!", "Stelia Fashion");
            LoadCart();
        }

        private void btnRemoveFromWishlist_Click(object sender, EventArgs e)
        {
            if (lstWishlist.SelectedIndex == -1)
            {
                CustomMessageBox.Show("Please select an item to remove!", "Stelia Fashion");
                return;
            }

            string productName = lstWishlist.SelectedItem.ToString();
            currentUser.Wishlist.Remove(productName);
            CustomMessageBox.Show("Removed from wishlist!", "Stelia Fashion");
            LoadWishlist();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (currentUser.Cart.Count == 0)
            {
                CustomMessageBox.Show("Your cart is empty!", "Stelia Fashion");
                return;
            }

            string address = CustomInputBox.Show(
                "Enter delivery address:", "Checkout");
            if (string.IsNullOrEmpty(address)) return;

            string phone = CustomInputBox.Show(
                "Enter phone number:", "Checkout");
            if (string.IsNullOrEmpty(phone)) return;

            businessLogic.ProcessOrder(currentUser, address, phone);
            dataAccess.ClearCart(currentUser.Username);
            CustomMessageBox.Show(
                "Order placed successfully!\nDelivery to: " + address, "Order Confirmed");
            LoadCart();
            LoadOrders();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HandleLogout(); // INTERFACE METHOD CALLED
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}