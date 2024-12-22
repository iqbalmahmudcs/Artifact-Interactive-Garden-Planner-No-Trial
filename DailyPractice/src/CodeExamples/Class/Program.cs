using Class;

WaterBottle waterBottle = new WaterBottle(100, "Red");
waterBottle.AddWater(20);

WaterBottle waterBottle2 = new WaterBottle(200, "Bule");
waterBottle2.AddWater(40);

waterBottle.WaterAmount = -10;

Console.WriteLine(waterBottle.WaterAmount);
