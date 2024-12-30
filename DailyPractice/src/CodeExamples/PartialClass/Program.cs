using PartialClass;

Product product1 = new Product("Camera", 2000);
product1.Price = 200;
Console.WriteLine(product1.CalculateDiscount(10));