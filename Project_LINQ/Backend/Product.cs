namespace Backend
{
    public class Product
    {
        private string _name;
        private double _price;

        public Product(string name, double price)
        {

            Name = name;
            Price = price;
        }

        public string Name
        {
           get => _name;
            set => _name = ValidateName(value);

        }
        public double Price  
        {

            get => _price;
            set => _price = ValidatePrice(value);
        }


        private double ValidatePrice(double price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price),"El precio no puede ser negativo.");
            }
            return price;
        }

        private string ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentOutOfRangeException(nameof(name),"El nombre no puede estar vacío.");
            }
            return name;
        }

        public override string ToString() => $"Producto: {Name}\tPrecio: {Price,15:C}";
        
    }
}
