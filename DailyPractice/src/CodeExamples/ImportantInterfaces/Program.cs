using ImportantInterfaces;

ShoppingCart cart = new ShoppingCart();

cart.AddProduct(new CartItem { Product = new Product { Name = "Camera", Price = 20000 }, Quantity = 5 });
cart.AddProduct(new CartItem { Product = new Product { Name = "TV", Price = 25000 }, Quantity = 2 });
cart.AddProduct(new CartItem { Product = new Product { Name = "Laptop", Price = 30000 }, Quantity = 3 });

foreach(var item in cart)
{
    Console.WriteLine($"{item.Product.Name}, {item.Quantity}");
}