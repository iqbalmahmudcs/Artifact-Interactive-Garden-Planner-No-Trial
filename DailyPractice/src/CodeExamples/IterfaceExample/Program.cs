using IterfaceExample;

IShape rectangle = new Rectangle();
rectangle.CalculateArea();

Console.WriteLine(rectangle.CalculateVolume());

IMoveable moveableItem = GetRectangle();

Rectangle GetRectangle()
{
    return new Rectangle();
}