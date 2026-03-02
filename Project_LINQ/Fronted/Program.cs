using Backend;

List<string> names = new List<string>
{
    "JULIAN", "Ana", "Andrés", "María", "Alberto", "Sofía", "juaquin","FabiaN","Esteban"
};
List<string> filteredNames = names
    .Where(L => L.EndsWith("n", StringComparison.InvariantCultureIgnoreCase))
    .OrderBy(L => L)
    .ToList();
foreach (string name in filteredNames)
{
    Console.WriteLine(name);
}

List<Product> productos = new List<Product>
{
    new Product (name : "Zapatos",  price : 50.0 ),
    new Product (name : "Camisa",   price : 30.0),
    new Product (name : "Pantalón", price : 40.0)
};

List<Product> filteredProducts = productos
    .Where(p => p.Price > 35.0)
    .Select(p => new Product(p.Name, p.Price * 1.20)) 
    .ToList();

foreach (Product producto in filteredProducts)
{
    Console.WriteLine(producto);  
}

