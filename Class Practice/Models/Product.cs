using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Practice.Models
{
    internal class Product
    {
        public string name;
        public int No;
        public double price;
        public int count;

        public Product(string name, int No, double price)
        {
            this.name = name;
            this.No = No;
            this.price = price;
        }
    } 
}

