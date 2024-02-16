using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static E_CommerceWebForm.Global;

namespace E_CommerceWebForm
{
    // Classe parziale Carrello 
    public partial class Carrello : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //// Se la pagina non è stata inviata al server 
            //if (!IsPostBack)
            //{
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
               }
               else
               {
                  // Se la lista di prodotti è vuota
                  containerProducts.InnerHtml = "<h3>Il carrello è vuoto</h3>";
               }
            //}
        }
    }
}