using System;
using System.Collections.Generic;
using System.Web.UI;

namespace E_CommerceWebForm
{

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Creare una lista di prodotti e assegnarla alla variabile di sessione "Catalogo"
            Session["Catalogo"] = new List<Product>
            {
                new Product(1,"iPhone", 1400, "https://flaminiacomputer.it/wp-content/uploads/2022/11/iphone-14-finish-select-202209-6-1inch_AV2_GEO_EMEA.jpeg"),
                new Product(2,"Macbook", 1800, "https://5.imimg.com/data5/SELLER/Default/2021/2/KQ/EU/PX/122095513/apple-laptop-i7.PNG"),
                new Product(3,"iPad", 1100, "https://www.juice.it/media/catalog/product/cache/7b46027f9500ccaf74b03362113ee58a/I/P/IPAD2022_1.jpeg"),
                new Product(4,"Nintendo Switch", 350, "https://cf-images.dustin.eu/cdn-cgi/image/format=auto,quality=75,width=828,,fit=contain/image/d200001001436703/nintendo-switch-oled.jpg"),
            };

            // ottieni la lista di prodotti dalla sessione Catalogo
            List<Product> catalogo = Session["Catalogo"] as List<Product>;

            // Assegna la lista di prodotti al controllo Repeater 
            CatalogoRepeater.DataSource = catalogo;
            // Visualizza i prodotti nella pagina 
            CatalogoRepeater.DataBind();
        }

        protected void addToCartButton_Click(object sender, EventArgs e)
        {

            // int itemId = Convert.ToInt32((sender as Button).CommandArgument);// necessario using System.Web.UI.WebControls per usare sender as Button;
            // Aggiungi il prodotto al carrello
            // Response.Write(itemId + " Aggiunto al carrello<br>");
            // Cart.AddToCart(itemId);
        }
    }
}