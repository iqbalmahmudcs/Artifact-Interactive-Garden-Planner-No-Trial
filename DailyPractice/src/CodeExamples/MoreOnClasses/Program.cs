using MoreOnClasses;

Console.WriteLine(Geometry.CalculateCircleArea(200));

Circle c1 = new Circle();
c1.Radius = 200;
double area = c1.CalculateArea();
Console.WriteLine(area);

Circle c2 = new Circle();
Console.WriteLine($"Count = {Circle.Count}");

Discount restictedDiscount = new RestictedDiscount();
restictedDiscount.DiscountAmount =  60;
Console.WriteLine(restictedDiscount.GetAmount(100));