using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static E_CommerceWebForm._Default;

namespace E_CommerceWebForm
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Controlla se c'è un parametro "id_item" nella query string
                if (Request.QueryString["id_item"] != null)
                {
                    // Ottieni l'ID dall'URL della query string
                    int itemId;

                    // Ottieni la lista di prodotti dalla sessione
                    List<Product> Products = Session["Catalogo"] as List<Product>;

                   // Verifica se l'ID dall'URL è un numero valido
                    if (int.TryParse(Request.QueryString["id_item"], out itemId))
                    {
                        // Cerca il prodotto corrispondente nella lista Products
                        Product product = Products.FirstOrDefault(p => p.id_item == itemId);

                        if (product != null)
                        {
                            ItemDetails.InnerHtml = product.Name + "<br>" + product.Price;
                            //Esegui le azioni necessarie con il prodotto trovato
                            // Ad esempio, puoi utilizzare product.Name, product.Price, etc.
                            // per visualizzare le informazioni del prodotto sulla pagina "About.aspx"
                        }
                        else
                        {
                            // Gestisci il caso in cui non viene trovato nessun prodotto con l'ID specificato
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    // Gestisci il caso in cui non ci sia alcun parametro "id_item" nella query string
                    ItemDetails.InnerHtml = "ID non valido";
                }
            }
        }
    }
}