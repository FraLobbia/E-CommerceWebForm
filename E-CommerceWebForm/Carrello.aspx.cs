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
                // cicla la lista di prodotti e crea un elemento HTML per visualizzare le informazioni del prodotto
                foreach (Product item in cartList)
                {
                    // Crea un nuovo elemento HTML per visualizzare le informazioni del prodotto
                    string cardHtml = $@"
                                            <div class='card col border'>
                                                <img src='{item.Image}' class='card-img-top' alt='{item.Name}' style='max-height:200px;object-fit:contain'>

                                                <div class='card-body d-flex flex-column justify-content-between mt-3'>                                               
                                                    <div>    
                                                        <h5 class='card-title'>{item.Name}</h5>
                                                        <p class='card-text'>Prezzo: {item.Price}</p>
                                                    </div>  
                                                
                                                    <div>
                                                       <a href='Dettagli.aspx?id_item={item.id_item}' class='btn btn-primary mt-4'>Dettagli</a>

                                                     

                                                    </div>   
                                                </div>
                                            </div>";
                    // Aggiungi l'elemento HTML al contenitore "containerProducts"
                    containerProducts.InnerHtml += cardHtml;
                }
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
                containerProducts.InnerHtml = "<h3>Il carrello è vuoto</h3>";
            }

        }

        protected void handleDelete(object sender, EventArgs e)
        {
            // da finire
        }
    }
}