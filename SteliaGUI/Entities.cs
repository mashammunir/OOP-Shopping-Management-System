using System;
using System.Collections.Generic;

namespace SteliaGUI
{
    // Entity Layer  Contains data models/structures

    public class CartItem
    {
        public string ProductName;
        public string Size;
        public int Quantity;
        public int Price;
    }

    public class Order
    {
        public string CustomerName;
        public string ProductName;
        public string Size;
        public int Quantity;
        public int TotalPrice;
        public string Status;
        public string Address;
        public string Phone;
    }

    public class Product
    {
        public string Name;
        public string Brand;
        public string Category;
        public int OriginalPrice;
        public int DiscountedPrice;
        public int DiscountPercent;
        public string AvailableSizes;
        public string Color;
        public string Description;
        public int Stock;
    }

    public class User
    {
        public string Username = "";
        public string Password = "";
        public string Email = "";
        public string Role = "";
        public List<string> Wishlist = new List<string>();
        public List<CartItem> Cart = new List<CartItem>();
    }
}