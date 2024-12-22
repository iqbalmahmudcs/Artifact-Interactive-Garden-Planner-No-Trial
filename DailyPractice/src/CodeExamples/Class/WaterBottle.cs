//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace OOP.Classes
{
    class WaterBottle
    {
        private double capacity;
        private string color;
        private double waterAmount;
        private readonly DateTime _creationTime;
        private const string unit = "Liter";

        public string name { get; set; }    //Autoproperty
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

        public WaterBottle(double capacity, string color, double waterAmount) : this(capacity, color)
        {
            this.waterAmount = waterAmount;
        }

        public WaterBottle(double capacity, string color)
        {
            this.waterAmount = 0;
            this.capacity = capacity;
            this.color = color;
            _creationTime = DateTime.Now;
        }

        ~WaterBottle()
        {
            color = null;
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

        public void SetCreationTime(DateTime creationTime)
        {
        }
        public void ResetWater()
        {

        }
        public void ResetWater(double amount)
        {
            waterAmount = amount;
        }

    }
}
