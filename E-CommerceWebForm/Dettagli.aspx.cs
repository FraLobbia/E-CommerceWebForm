using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static E_CommerceWebForm._Default;

namespace E_CommerceWebForm
{
    public partial class Dettagli : Page
    {
          protected void Page_Load(object sender, EventArgs e)
          {
               // Se la pagina non è stata inviata al server
               if (!IsPostBack)
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
                            Product item = catalogo.FirstOrDefault(elem => elem.id_item == itemId);
                    
                            if (item != null)
                            {
                                // Visualizza le informazioni del prodotto
                                itemTitle.InnerText = item.Name;
                                itemPrice.InnerText = item.Price.ToString();
                                itemImage.ImageUrl = item.Image;                         
                            }
                            else
                            {
                                // Visualizza un messaggio di errore    
                                itemTitle.InnerText = "Non è presente un prodotto con id " + itemId;
                            }
                        }
                        else
                        {
                            itemTitle.InnerHtml = "ID non valido";
                        }
                    }
                    else
                    {
                        // Gestisci il caso in cui non ci sia alcun parametro "id_item" nella query string
                        itemTitle.InnerHtml = "ID non valido o non presente";
                    }
               }
          }

        protected void addToCart(object sender, EventArgs e)
        {
            Response.Write("Aggiunto al carrello");
            // Se la variabile di sessione "Carrello" è vuota
            if (Session["Carrello"] == null)
            {


                // Se c'è un parametro "id_item" nella query string
                if (Request.QueryString["id_item"] != null)
                {
                    // Definisce l'ID del prodotto come un numero intero (int)
                    int itemId;

                    // Prova a convertire l'ID del prodotto in un numero intero (int) e lo assegna alla variabile itemId
                    if (int.TryParse(Request.QueryString["id_item"], out itemId))
                    {
                        Session["Carrello"] = new List<Product>
                        {
                            new Product(itemId, itemTitle.InnerText, Convert.ToDecimal(itemPrice.InnerText), itemImage.ImageUrl),
                        };
                    }
                }
                else
                {
                    // Gestisci il caso in cui non ci sia alcun parametro "id_item" nella query string
                    itemTitle.InnerHtml = "ID non valido";
                }
            }
            else
            { 
                // Se la variabile di sessione "Carrello" non è vuota definisci la
                // variabile cartList dalla sessione "Carrello" 
                List<Product> cartList = Session["Carrello"] as List<Product>;

                // Se c'è un parametro "id_item" nella query string
                if (Request.QueryString["id_item"] != null)
                {
                    // Definisce l'ID del prodotto come un numero intero (int)
                    int itemId;

                    // Prova a convertire l'ID del prodotto in un numero intero (int) e lo assegna alla variabile itemId
                    if (int.TryParse(Request.QueryString["id_item"], out itemId))
                    {
                        // Aggiungi il prodotto al carrello
                        cartList.Add(new Product(itemId, itemTitle.InnerText, Convert.ToDecimal(itemPrice.InnerText), itemImage.ImageUrl));
                    }
                }
                else
                {
                    // Gestisci il caso in cui non ci sia alcun parametro "id_item" nella query string
                    itemTitle.InnerHtml = "ID non valido";
                }
            }
        }
    }
}