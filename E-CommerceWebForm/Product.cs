using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_CommerceWebForm
{
    public class Product
    {
        // Proprietà della classe Product 
        public int id_item { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        // Costruttore per inizializzare i campi della classe Product 
        public Product(int id, string name, decimal price, string image)
        {
            id_item = id;
            Name = name;
            Price = price;
            Image = image;
        }
    }
}