using System;
using System.Web.UI;


namespace E_CommerceWebForm
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ottieni quantità di prodotti nel carrello
            int cartQuantity = Cart.GetCartQuantity();
            // Visualizza la quantità di prodotti nel carrello
            CarrelloNavbar.InnerText = "Carrello (" + cartQuantity.ToString() + " units)";
        }
    }
}