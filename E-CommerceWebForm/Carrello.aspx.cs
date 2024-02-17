using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace E_CommerceWebForm
{
    // Classe parziale Carrello 
    public partial class Carrello : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ottieni la lista di prodotti dalla sessione Carrello e assegnala a cartList
            List<Product> cartList = Session["Carrello"] as List<Product>;

            // Se la lista di prodotti non è vuota
            if (cartList != null)
            {
                // Assegna la lista di prodotti nel carrello al controllo Repeater 
                CarrelloRepeater.DataSource = cartList;
                // Visualizza i prodotti nella pagina 
                CarrelloRepeater.DataBind();

                // Calcola il totale del carrello
                decimal total = 0;
                foreach (Product item in cartList)
                {
                    total += item.Price;
                }
                // Visualizza il totale del carrello
                totaleCarrello.InnerText = Convert.ToString(total);
            }
            else
            {
                // Se la lista di prodotti è vuota
                CartListRow.InnerHtml = "<h3>Il carrello è vuoto</h3>";

                // redirect alla pagina principale dopo 5 secondi
                //Response.AddHeader("REFRESH", "5;URL=Default.aspx");
                Response.Redirect("Default.aspx"); // todo: impostare riga sopra e cancellare questa dopo debugging
            }

        }

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