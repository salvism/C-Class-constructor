using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7
{
    internal class Product
    {
        public string Name;
        public double Price;
        public double DiscountPercent;

        public Product(string name, double price, double discountPercent = 0)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
