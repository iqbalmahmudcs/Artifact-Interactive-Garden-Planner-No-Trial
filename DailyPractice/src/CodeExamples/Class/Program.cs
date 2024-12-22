using Class;
using OOP.Classes;


WaterBottle waterBottle = new WaterBottle(100, "Red", 100);
waterBottle.AddWater(20);

WaterBottle waterBottle2 = new WaterBottle(200, "Bule");
waterBottle2.AddWater(40);

waterBottle.WaterAmount = -10;

Console.WriteLine(waterBottle.WaterAmount);

waterBottle.ResetWater();

Camera camera = new Camera(100, "red");
camera.Price = 20000;

