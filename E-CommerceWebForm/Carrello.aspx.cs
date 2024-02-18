using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace E_CommerceWebForm
{

    public partial class Carrello : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ottieni la lista di prodotti dalla sessione Carrello e assegnala a cartList
            List<Product> cartList = Session["Carrello"] as List<Product>;

            // Se la lista di prodotti non è vuota
            if (cartList != null)
            {
                // in cartlist voglio solo i prodotti che sono nel carrello senza ripeterli
                List<Product> cartListUnique = cartList.Distinct().ToList(); // Distinct() restituisce una sequenza che contiene solo i primi elementi distinti in base all'ID del prodotto

                // Assegna la lista di prodotti nel carrello al controllo Repeater 
                CarrelloRepeater.DataSource = cartListUnique;
                // Visualizza i prodotti nella pagina 
                CarrelloRepeater.DataBind();

                // Visualizza il totale del carrello
                totaleCarrello.InnerText = Cart.GetCartTotal().ToString();
            }
            else
            {
                // Se la lista di prodotti è vuota
                cartContainer.InnerHtml = "<h3>Il carrello è vuoto</h3>";

                // redirect alla pagina principale dopo 5 secondi
                Response.AddHeader("REFRESH", "5;URL=Default.aspx");
            }
        }

        // Metodo per gestire il click del bottone Rimuovi
        // Riceve l'id del prodotto da rimuovere dal carrello attraverso il CommandArgument del bottone
        // Non restituisce nulla
        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            //Ottieni l'ID del prodotto da rimuovere dal carrello
            int itemId = Convert.ToInt32((sender as Button).CommandArgument);

            //Rimuovi il prodotto dal carrello
            Cart.RemoveFromCart(itemId);

            // refresh la pagina per visualizzare il carrello aggiornato
            Response.Redirect(Request.RawUrl); // Request.RawUrl restituisce l'URL della pagina corrente
        }
    }
}