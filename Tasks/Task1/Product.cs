using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price
        {
            get => this.Price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("The price can't be negative.");

                this.Price = value;
            }
        }

        public int StockQuantity{ 
            get=>this.StockQuantity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("the quantity can't be negative");
                }
                this.StockQuantity = value;
            }
        }

        public bool IsAvailable
        {
            get=>  this.StockQuantity > 0;
        }

        public void UpdateStock(int amount)
        {
            int newQuantity = StockQuantity + amount;

            if (newQuantity < 0)
                throw new ArgumentException("Cannot reduce stock below zero.");

            StockQuantity = newQuantity;
        }

    }
}
