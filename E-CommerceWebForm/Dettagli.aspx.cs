using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace E_CommerceWebForm
{
    public partial class Dettagli : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Controlla se c'è un parametro "id_item" nella query string
            if (Request.QueryString["id_item"] != null)
            {
                // Definisco la variabile itemId come un numero intero (int)
                int itemId;

                // Verifica se l'ID dall'URL è un numero valido (int) e lo assegna alla variabile itemId
                if (int.TryParse(Request.QueryString["id_item"], out itemId))
                {

                    // Ottieni la lista di prodotti dalla sessione (Catalogo è il nome della variabile di sessione) 
                    List<Product> catalogo = Session["Catalogo"] as List<Product>;

                    // Cerca il prodotto corrispondente nella lista Products utilizzando l'ID specificato nella query string 
                    // restituisce il primo elemento che soddisfa la condizione specificata di tipo Product
                    Product item = catalogo.FirstOrDefault(elem => elem.id_item == itemId);

                    if (item != null)
                    {
                        // Visualizza le informazioni del prodotto
                        itemImage.ImageUrl = item.Image;
                        itemImage.AlternateText = item.Name;
                        itemTitle.InnerText = item.Name;
                        itemCategory.InnerText = item.Category;
                        itemDescription.InnerText = item.Description;
                        itemPrice.InnerText = item.Price.ToString() + " €";
                        addToCartButton.CommandArgument = item.id_item.ToString(); // serve per far funzionare l'evento click del bottone e per passare l'id del prodotto
                    }
                    else
                    {
                        handleIdNotFound();
                    }
                }
                else
                {
                    handleIdNotFound();
                }
            }
            else
            {
                handleIdNotFound();
            }

        }

        protected void addToCartButton_Click(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32((sender as Button).CommandArgument);// necessario using System.Web.UI.WebControls per usare sender as Button;
            // Aggiungi il prodotto al carrello
            Cart.AddToCart(itemId);
            Response.Write(itemId + " Aggiunto al carrello<br>");

        }

        // Metodo per gestire problemi con l'ID del prodotto
        protected void handleIdNotFound()
        {
            idNonTrovato.InnerHtml = "<h3>ID non valido o non presente</h3>";
            // Nascondi il contenitore del prodotto
            ContainerPage.Visible = false;
            //Redirect alla pagina principale dopo 2 secondi
            Response.AddHeader("REFRESH", "2;URL=Default.aspx");
        }
    }
}