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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (Product item in Products)
                {
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
                    containerProducts.InnerHtml += cardHtml;
                }
               
            }
        }

        public class Product
        {
            public int id_item { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Image { get; set; }

            public Product(int id, string name, decimal price, string image)
            {
                id_item = id;
                Name = name;
                Price = price;
                Image = image;
            }
        }

        public List<Product> Products // create a list of products and their prices
        {
            // create a list of products and their prices
            get
            {
                if (Session["Catalogo"] == null)
                {
                    Session["Catalogo"] = new List<Product>
                        {
                        new Product(1,"iPhone", 1400, "https://flaminiacomputer.it/wp-content/uploads/2022/11/iphone-14-finish-select-202209-6-1inch_AV2_GEO_EMEA.jpeg"),
                        new Product(2,"Macbook", 1800, "https://5.imimg.com/data5/SELLER/Default/2021/2/KQ/EU/PX/122095513/apple-laptop-i7.PNG"),
                        new Product(3,"iPad", 1100, "https://www.juice.it/media/catalog/product/cache/7b46027f9500ccaf74b03362113ee58a/I/P/IPAD2022_1.jpeg"),
                        new Product(4,"Nintendo Switch", 350, "https://cf-images.dustin.eu/cdn-cgi/image/format=auto,quality=75,width=828,,fit=contain/image/d200001001436703/nintendo-switch-oled.jpg"),

                    };
                }
                return (List<Product>)Session["Catalogo"];
            }
        }
    }
}