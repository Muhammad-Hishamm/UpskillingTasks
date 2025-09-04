using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Mileage
        {
            get => this.Mileage;
            set
            {
                if (this.Mileage < 0) this.Mileage = 0;
                else this.Mileage = value;
            }
        }
        public int Age { get => DateTime.Now.Year - this.Year; }
        public void drive(int distance)
        {
            if (distance < 0)
                throw new ArgumentOutOfRangeException("the distance should be positive");
            this.Mileage += distance;
        }
    }

}
