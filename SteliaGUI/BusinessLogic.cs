using System;
using System.Collections.Generic;
using System.Linq;

namespace SteliaGUI
{
    public class BusinessLogic
    {
        private DataAccess dataAccess;

        public BusinessLogic(DataAccess da)
        {
            dataAccess = da;
        }

        public bool ValidatePassword(string password)
        {
            int numbers = 0, capitals = 0, specials = 0, lower = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c)) numbers++;
                else if (char.IsUpper(c)) capitals++;
                else if (char.IsLower(c)) lower++;
                else if (!char.IsWhiteSpace(c)) specials++;
            }
            return password.Length >= 6 && numbers >= 1 && capitals >= 1 && specials >= 1;
        }

        public bool ValidateEmail(string email)
        {
            int atCount = 0, dotCount = 0;
            foreach (char c in email)
            {
                if (c == '@') atCount++;
                if (c == '.') dotCount++;
            }
            return atCount == 1 && dotCount >= 1 && email.Length >= 5;
        }

        public bool ValidateUsername(string username)
        {
            return !string.IsNullOrWhiteSpace(username) &&
                   username.Length >= 6 &&
                   username.Length <= 15 &&
                   !username.Contains(',');
        }

        public bool IsEmpty(string str) => string.IsNullOrWhiteSpace(str);

        public List<int> SearchProducts(string searchTerm)
        {
            List<int> indices = new List<int>();
            var products = dataAccess.GetAllProducts();

            for (int i = 0; i < products.Count; i++)
            {
                bool nameMatch = !string.IsNullOrEmpty(products[i].Name) &&
                                 products[i].Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                bool brandMatch = !string.IsNullOrEmpty(products[i].Brand) &&
                                  products[i].Brand.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                bool categoryMatch = !string.IsNullOrEmpty(products[i].Category) &&
                                     products[i].Category.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;

                if (nameMatch || brandMatch || categoryMatch)
                    indices.Add(i);
            }
            return indices;
        }

        public bool AddToCart(User user, Product product, int quantity, string selectedSize)
        {
            if (user.Cart.Count >= 50)
                return false;

            if (quantity < 1 || quantity > 10)
                return false;

            if (quantity > product.Stock)
                return false;

            user.Cart.Add(new CartItem
            {
                ProductName = product.Name,
                Size = selectedSize,
                Quantity = quantity,
                Price = product.DiscountedPrice * quantity
            });

            product.Stock -= quantity;
            return true;
        }

        public int CalculateCartTotal(User user)
        {
            int total = 0;
            foreach (var item in user.Cart)
                total += item.Price;
            return total;
        }

        public void ProcessOrder(User user, string address, string phone)
        {
            foreach (CartItem item in user.Cart)
            {
                dataAccess.AddOrder(new Order
                {
                    CustomerName = user.Username,
                    ProductName = item.ProductName,
                    Size = item.Size,
                    Quantity = item.Quantity,
                    TotalPrice = item.Price,
                    Status = "Pending",
                    Address = address,
                    Phone = phone
                });
            }
            user.Cart.Clear();
        }

        public List<int> GetProductsByBrand(string brand)
        {
            List<int> indices = new List<int>();
            var products = dataAccess.GetAllProducts();

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Brand == brand)
                    indices.Add(i);
            }
            return indices;
        }

        public List<int> GetProductsByCategory(string category)
        {
            List<int> indices = new List<int>();
            var products = dataAccess.GetAllProducts();

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Category == category)
                    indices.Add(i);
            }
            return indices;
        }

        public List<int> GetFeaturedDeals(int maxItems)
        {
            List<int> indices = new List<int>();
            var products = dataAccess.GetAllProducts();

            for (int i = 0; i < products.Count && indices.Count < maxItems; i++)
                indices.Add(i);

            return indices;
        }
    }
}