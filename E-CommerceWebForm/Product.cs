namespace E_CommerceWebForm
{
    public class Product
    {
        // Proprietà della classe Product 
        public int id_item { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        // Costruttore per inizializzare i campi della classe Product 
        public Product(int id, string name, decimal price, string image, string description, string category)
        {
            id_item = id;
            Name = name;
            Price = price;
            Image = image;
            Description = description;
            Category = category;

        }
    }
}