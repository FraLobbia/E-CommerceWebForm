using System;
using System.Collections.Generic;
using System.Web.UI;

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
            }

        }

        protected void handleDelete(object sender, EventArgs e)
        {
            // da finire
        }
    }
}