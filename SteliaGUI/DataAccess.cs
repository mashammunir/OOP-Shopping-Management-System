using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace SteliaGUI
{
    public class DataAccess
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SteliaDB"].ConnectionString;
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // =============================================
        // PRODUCT OPERATIONS
        // =============================================

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        Name = reader["name"].ToString(),
                        Brand = reader["brand"].ToString(),
                        Category = reader["category"].ToString(),
                        OriginalPrice = Convert.ToInt32(reader["original_price"]),
                        DiscountedPrice = Convert.ToInt32(reader["discounted_price"]),
                        DiscountPercent = Convert.ToInt32(reader["discount_percent"]),
                        AvailableSizes = reader["available_sizes"].ToString(),
                        Color = reader["color"].ToString(),
                        Description = reader["description"].ToString(),
                        Stock = Convert.ToInt32(reader["stock"])
                    });
                }
            }
            return products;
        }

        public Product GetProduct(int index)
        {
            return GetAllProducts()[index];
        }

        public int GetProductCount()
        {
            return GetAllProducts().Count;
        }

        public void AddProduct(Product product)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO products 
                    (name, brand, category, original_price, discounted_price, discount_percent, available_sizes, color, description, stock)
                    VALUES (@name, @brand, @category, @original_price, @discounted_price, @discount_percent, @available_sizes, @color, @description, @stock)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@brand", product.Brand);
                cmd.Parameters.AddWithValue("@category", product.Category);
                cmd.Parameters.AddWithValue("@original_price", product.OriginalPrice);
                cmd.Parameters.AddWithValue("@discounted_price", product.DiscountedPrice);
                cmd.Parameters.AddWithValue("@discount_percent", product.DiscountPercent);
                cmd.Parameters.AddWithValue("@available_sizes", product.AvailableSizes);
                cmd.Parameters.AddWithValue("@color", product.Color);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveProduct(int index)
        {
            var products = GetAllProducts();
            if (index < 0 || index >= products.Count) return;

            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM products WHERE name = @name LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", products[index].Name);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(int index, Product product)
        {
            var products = GetAllProducts();
            if (index < 0 || index >= products.Count) return;

            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"UPDATE products SET 
                    stock = @stock,
                    discount_percent = @discount_percent,
                    discounted_price = @discounted_price
                    WHERE name = @name";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                cmd.Parameters.AddWithValue("@discount_percent", product.DiscountPercent);
                cmd.Parameters.AddWithValue("@discounted_price", product.DiscountedPrice);
                cmd.Parameters.AddWithValue("@name", products[index].Name);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProductStock(string productName, int newStock)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE products SET stock = @stock WHERE name = @name";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@stock", newStock);
                cmd.Parameters.AddWithValue("@name", productName);
                cmd.ExecuteNonQuery();
            }
        }

        // =============================================
        // USER OPERATIONS
        // =============================================

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM users";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User
                    {
                        Username = reader["username"].ToString(),
                        Password = reader["password"].ToString(),
                        Email = reader["email"].ToString(),
                        Role = reader["role"].ToString()
                    });
                }
            }
            return users;
        }

        public User GetUser(int index)
        {
            return GetAllUsers()[index];
        }

        public bool AddUser(User user)
        {
            if (FindUserByUsername(user.Username) != null)
                return false;

            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO users (username, password, email, role) VALUES (@username, @password, @email, @role)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public User FindUserByUsername(string username)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    User user = new User
                    {
                        Username = reader["username"].ToString(),
                        Password = reader["password"].ToString(),
                        Email = reader["email"].ToString(),
                        Role = reader["role"].ToString()
                    };

                    reader.Close();
                    user.Wishlist = GetWishlist(username);
                    user.Cart = GetCart(username);
                    return user;
                }
                return null;
            }
        }

        public int FindUserIndex(string username)
        {
            var users = GetAllUsers();
            for (int i = 0; i < users.Count; i++)
                if (users[i].Username == username) return i;
            return -1;
        }

        public bool ValidateUserCredentials(string username, string password, string role)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password AND role = @role";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // =============================================
        // ORDER OPERATIONS
        // =============================================

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM orders";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orders.Add(new Order
                    {
                        CustomerName = reader["customer_name"].ToString(),
                        ProductName = reader["product_name"].ToString(),
                        Size = reader["size"].ToString(),
                        Quantity = Convert.ToInt32(reader["quantity"]),
                        TotalPrice = Convert.ToInt32(reader["total_price"]),
                        Status = reader["status"].ToString(),
                        Address = reader["address"].ToString(),
                        Phone = reader["phone"].ToString()
                    });
                }
            }
            return orders;
        }

        public void AddOrder(Order order)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO orders 
                    (customer_name, product_name, size, quantity, total_price, status, address, phone)
                    VALUES 
                    (@customer_name, @product_name, @size, @quantity, @total_price, @status, @address, @phone)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@customer_name", order.CustomerName);
                cmd.Parameters.AddWithValue("@product_name", order.ProductName);
                cmd.Parameters.AddWithValue("@size", order.Size);
                cmd.Parameters.AddWithValue("@quantity", order.Quantity);
                cmd.Parameters.AddWithValue("@total_price", order.TotalPrice);
                cmd.Parameters.AddWithValue("@status", order.Status);
                cmd.Parameters.AddWithValue("@address", order.Address ?? "");
                cmd.Parameters.AddWithValue("@phone", order.Phone ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOrderStatus(int index, string status)
        {
            var orders = GetAllOrders();
            if (index < 0 || index >= orders.Count) return;

            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"UPDATE orders SET status = @status 
                                 WHERE customer_name = @customer_name 
                                 AND product_name = @product_name
                                 LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@customer_name", orders[index].CustomerName);
                cmd.Parameters.AddWithValue("@product_name", orders[index].ProductName);
                cmd.ExecuteNonQuery();
            }
        }

        // =============================================
        // WISHLIST OPERATIONS
        // =============================================

        public List<string> GetWishlist(string username)
        {
            List<string> wishlist = new List<string>();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT product_name FROM wishlist WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    wishlist.Add(reader["product_name"].ToString());
            }
            return wishlist;
        }

        public void AddToWishlist(string username, string productName)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO wishlist (username, product_name) VALUES (@username, @product_name)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@product_name", productName);
                cmd.ExecuteNonQuery();
            }
        }

        // =============================================
        // CART OPERATIONS
        // =============================================

        public List<CartItem> GetCart(string username)
        {
            List<CartItem> cart = new List<CartItem>();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM cart WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cart.Add(new CartItem
                    {
                        ProductName = reader["product_name"].ToString(),
                        Size = reader["size"].ToString(),
                        Quantity = Convert.ToInt32(reader["quantity"]),
                        Price = Convert.ToInt32(reader["price"])
                    });
                }
            }
            return cart;
        }

        public void SaveCartItem(string username, CartItem item)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO cart (username, product_name, size, quantity, price) VALUES (@username, @product_name, @size, @quantity, @price)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@product_name", item.ProductName);
                cmd.Parameters.AddWithValue("@size", item.Size);
                cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@price", item.Price);
                cmd.ExecuteNonQuery();
            }
        }

        public void ClearCart(string username)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM cart WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveCartItem(string username, int index)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string selectQuery = $"SELECT id FROM cart WHERE username = @username LIMIT 1 OFFSET {index}";
                MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn);
                selectCmd.Parameters.AddWithValue("@username", username);
                object result = selectCmd.ExecuteScalar();

                if (result != null)
                {
                    int id = Convert.ToInt32(result);
                    string deleteQuery = "DELETE FROM cart WHERE id = @id";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@id", id);
                    deleteCmd.ExecuteNonQuery();
                }
            }
        }

        public void InitializeSampleData()
        {
            // Data is now stored in MySQL
        }
    }
}