using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Homework7
{
    internal class Notebook
    {
        public Notebook(string brand, string model)
        {
            Brand= brand;
            Model= model;
        }

        public Notebook(string brand, string model, double price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

        public string Brand;
        public string Model;
        public double Price;

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} , Model: {Model} , Price: {Price}");
        }
    }
}
