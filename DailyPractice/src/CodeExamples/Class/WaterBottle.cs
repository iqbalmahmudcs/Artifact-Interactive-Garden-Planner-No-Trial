using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class WaterBottle
    {
        private double capacity;
        private string color;
        private double waterAmount;

        public double WaterAmount
        {
            get 
            {
                return waterAmount;
            }
            set
            {
                if (value >= 0)
                {
                    waterAmount = value;
                }
             }
        }

        public WaterBottle(double capacity, string color)
        {
            this.waterAmount = 0;
            this.capacity = capacity;
            this.color = color;
        }

        public void AddWater(double waterAmount)
        {
            if (waterAmount >= 0)
            {
                waterAmount += waterAmount;
            }
        }
        public void RemoveWater(double waterAmount)
        {
            if (waterAmount >= 0)
            {
                waterAmount -= waterAmount;
            }
        }

        

    }
}
