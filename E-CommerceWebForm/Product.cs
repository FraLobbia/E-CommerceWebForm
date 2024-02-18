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


        public int QuantityInCart
        {
            get { return Cart.GetCartQuantitybyID(this.id_item); }
        }


        // Override del metodo Equals per confrontare gli oggetti di tipo Product
        // Restituisce true se l'oggetto corrente è uguale all'oggetto specificato, altrimenti restituisce false
        // Prende in input un oggetto di tipo object
        // Restituisce un booleano
        // !!! Il metodo Equals è un metodo virtuale ereditato da Object, quindi è possibile sovrascriverlo
        // !!! Il metodo Equals è utilizzato per confrontare gli oggetti di tipo Product
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Product other = (Product)obj;
            return this.id_item == other.id_item;
        }

        // Override del metodo GetHashCode per confrontare gli oggetti di tipo Product 
        // Restituisce il codice hash per l'oggetto corrente
        // Non richiede alcun input
        // Restituisce un intero
        // !!! Il metodo GetHashCode è un metodo virtuale ereditato da Object, quindi è possibile sovrascriverlo
        public override int GetHashCode()
        {
            return id_item.GetHashCode(); // GetHashCode() restituisce il codice hash per l'oggetto corrente
        }

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