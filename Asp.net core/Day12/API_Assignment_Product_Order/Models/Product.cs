﻿namespace API_Assignment_Product_Order.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public float Stock { get; set; }
    }
}
