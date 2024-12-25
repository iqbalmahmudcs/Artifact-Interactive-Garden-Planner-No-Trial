using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Electronics
    {
        private double EnergyConsumption {  get; set; }
        protected string Color {  get; set; }
        protected internal double Price { get; set; }

        public Electronics(double energyConsumption, string color, double price)
        {
            EnergyConsumption = energyConsumption;
            Color = null;
            price = 0;
        }

        public Electronics(double energyConsumption, double price)
        {
            EnergyConsumption = energyConsumption;
            Price = price;
        }
    }
}
