using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_CommerceWebForm
{
    public static class Cart
    {

        // Metodo per ottenere la lista di prodotti dal carrello
        // Non richiede alcun input
        // Restituisce una lista di prodotti nel carrello di tipo List<Product> 
        public static List<Product> GetCart()
        {
            // Ottieni la lista di prodotti dalla sessione Carrello e assegnala a cartList
            // !!! HttpContext.Current è necessario per accedere alla sessione in un metodo statico 
            List<Product> cartList = HttpContext.Current.Session["Carrello"] as List<Product>;
            return cartList;
        }

        // Metodo per ottenere la quantità di prodotti nel carrello
        // Non richiede alcun input
        // Restituisce un intero che rappresenta la quantità di prodotti nel carrello
        public static int GetCartQuantity()
        {
            List<Product> cartList = HttpContext.Current.Session["Carrello"] as List<Product>;
            if (cartList == null) { return 0; }
            else { return cartList.Count; }
        }

        // Metodo per ottenere la quantità di un prodotto specifico nel carrello
        // Prende in input l'ID del prodotto
        // Restituisce un intero che rappresenta la quantità del prodotto specificato nel carrello
        public static int GetCartQuantitybyID(int itemId)
        {
            List<Product> cartList = HttpContext.Current.Session["Carrello"] as List<Product>;
            if (cartList == null) { return 0; }
            else { return cartList.Count(elem => elem.id_item == itemId); }
        }

        public static decimal GetCartTotal()
        {
            List<Product> cartList = HttpContext.Current.Session["Carrello"] as List<Product>;
            if (cartList == null) { return 0; } // Se la lista di prodotti nel carrello è vuota, restituisci 0
            else
            {
                decimal total = 0; // Inizializza il totale a 0
                foreach (Product item in cartList) { total += item.Price; } // Calcola il totale sommando i prezzi di tutti i prodotti nel carrello
                return total; // Restituisci il totale
            }
        }

        // Metodo per aggiungere un prodotto al carrello
        // Prende in input l'ID del prodotto da aggiungere al carrello
        // Non restituisce nulla
        public static void AddToCart(int itemId)
        {
            // Ottieni la lista di prodotti dalla sessione Catalogo
            List<Product> catalogo = HttpContext.Current.Session["Catalogo"] as List<Product>;

            // Cerca il prodotto corrispondente nella lista Products utilizzando l'ID specificato nella query string 
            Product item = catalogo.FirstOrDefault(elem => elem.id_item == itemId);

            if (item == null) { return; } // Se l'elemento non esiste, esci dal metodo

            // Ottieni la lista di prodotti dalla sessione Carrello e assegnala a cartList
            List<Product> cartList = HttpContext.Current.Session["Carrello"] as List<Product>;

            // Se la lista di prodotti nel carrello è vuota
            if (cartList == null) { cartList = new List<Product>(); } // Crea una nuova lista di prodotti

            // Aggiungi il prodotto alla lista di prodotti nel carrello
            cartList.Add(item);

            // Assegna la lista di prodotti nel carrello alla sessione Carrello
            HttpContext.Current.Session["Carrello"] = cartList;
        }

        // Metodo per rimuovere un prodotto dal carrello
        // Prende in input l'ID del prodotto da rimuovere dal carrello
        // Non restituisce nulla
        public static void RemoveFromCart(int itemId)
        {
            // Ottieni la lista di prodotti dalla sessione Carrello e assegnala a cartList
            List<Product> cartList = HttpContext.Current.Session["Carrello"] as List<Product>;

            // Cerca il prodotto corrispondente nella lista Products utilizzando l'ID specificato nella query string 
            Product item = cartList.FirstOrDefault(elem => elem.id_item == itemId);

            // Rimuovi il prodotto dalla lista di prodotti nel carrello
            cartList.Remove(item);

            // Assegna la lista di prodotti nel carrello alla sessione Carrello
            HttpContext.Current.Session["Carrello"] = cartList;
        }
    }
}