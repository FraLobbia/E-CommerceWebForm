using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_CommerceWebForm
{
    public static class Cart
    {
        public static void getTest()
        {
            HttpContext.Current.Response.Write("Test");
        }


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
            if (cartList == null)
            {
                // Crea una nuova lista di prodotti
                cartList = new List<Product>();
            }

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