using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace E_CommerceWebForm
{

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Inizializza la sessione Catalogo con una lista di prodotti
            Session["Catalogo"] = new List<Product>
            {
                new Product(1, "iPhone", 1400, "https://flaminiacomputer.it/wp-content/uploads/2022/11/iphone-14-finish-select-202209-6-1inch_AV2_GEO_EMEA.jpeg", "Ultimo modello di iPhone con fotocamera avanzata. Offre prestazioni eccezionali, design elegante e funzionalità all'avanguardia. Ideale per chi cerca un dispositivo versatile e affidabile.", "Elettronica"),
                new Product(2, "Macbook", 1800, "https://5.imimg.com/data5/SELLER/Default/2021/2/KQ/EU/PX/122095513/apple-laptop-i7.PNG", "Potente laptop Macbook per professionisti. Dotato di processore ad alte prestazioni, schermo retina luminoso e batteria a lunga durata. Perfetto per il lavoro creativo e multitasking intensivo.", "Elettronica"),
                new Product(3, "iPad", 1100, "https://www.juice.it/media/catalog/product/cache/7b46027f9500ccaf74b03362113ee58a/I/P/IPAD2022_1.jpeg", "Tablet iPad con schermo retina ad alta definizione. Offre un'esperienza di navigazione fluida, prestazioni veloci e una vasta gamma di app disponibili sull'App Store. Ideale per il lavoro, lo studio e l'intrattenimento.", "Elettronica"),
                new Product(4, "Nintendo Switch", 350, "https://cf-images.dustin.eu/cdn-cgi/image/format=auto,quality=75,width=828,,fit=contain/image/d200001001436703/nintendo-switch-oled.jpg", "Console Nintendo Switch per il gioco in movimento. Offre una vasta libreria di giochi, modalità di gioco flessibili e possibilità di giocare ovunque tu sia. Perfetto per i giocatori di tutte le età.", "Giochi e intrattenimento"),
                new Product(5, "Smart TV 4K", 900, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSzxlEEUAFWIlBR0nMLUukbvUD__n-wQJk1oYiMQ925cp8VnLlVEJ24qPsNE89DIeslhtg&usqp=CAU", "TV intelligente con risoluzione 4K per un'esperienza di visione superiore. Ideale per lo streaming di film, serie TV e giochi. Dotata di tecnologie avanzate per una qualità dell'immagine nitida e colori vividi.", "Elettronica"),
                new Product(6, "Fotocamera DSLR", 1200, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWuGV-JmZ09OJ3ZgHAvzWyLs2I2u2tSQ1O6A&usqp=CAU", "Fotocamera digitale reflex con obiettivo intercambiabile. Perfetta per gli appassionati di fotografia che desiderano catturare immagini ad alta definizione e dettagliate. Facile da usare e versatile in qualsiasi situazione.", "Elettronica"),
                new Product(7, "Stampante 3D", 500, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQl-1WKlZXxMH-Smyc95GFiYv3WTMNSFbjOfrVSzEVJbBZC3nS4SJycPzBPRcUtZ2GIL0&usqp=CAU", "Stampante 3D per la creazione di oggetti tridimensionali. Ideale per prototipazione rapida, modellazione e stampa di pezzi personalizzati. Dotata di funzionalità avanzate e compatibilità con una vasta gamma di materiali.", "Elettronica"),
                new Product(8, "Aspirapolvere Robot", 300, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSe-bQGZ4mUdBpmL-mX7AfA2GCg_b8Ns0DGLvABm9ChghYixtuaB0LYLaG_SbpDlnilTiA&usqp=CAU", "Aspirapolvere autonomo controllabile tramite smartphone. Ottimizza la pulizia della casa con la tecnologia di navigazione intelligente e la capacità di programmazione. Perfetto per chi desidera un ambiente domestico pulito con il minimo sforzo.", "Elettrodomestici"),
                new Product(9, "Orologio Smart", 250, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTCi8G7288cvHBv-_6h_UqHJTCB0vbQE69gPg&usqp=CAU", "Orologio intelligente con monitoraggio fitness e notifiche. Tiene traccia dell'attività fisica, del sonno e fornisce aggiornamenti in tempo reale sulle chiamate e i messaggi. Stile moderno e funzionalità avanzate per uno stile di vita connesso.", "Elettronica"),
                new Product(10, "Drone", 700, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQwahwa1T4tWnfYnT93sy2gKPMgbSP2XS9rng&usqp=CAU", "Drone con fotocamera HD per riprese aeree. Perfetto per gli appassionati di fotografia e video che desiderano catturare immagini panoramiche e video mozzafiato dall'alto. Facile da pilotare e dotato di funzioni di sicurezza avanzate.", "Elettronica"),
                new Product(11, "Cuffie Bluetooth", 150, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRybztL1FPOm42Su6df0bjDEIsjrFfLy7qMwQ&usqp=CAU", "Cuffie senza fili con cancellazione attiva del rumore. Offrono un'esperienza di ascolto immersiva e priva di distrazioni, ideale per ascoltare musica, podcast e chiamate senza fili. Design ergonomico e qualità audio superiore.", "Elettronica"),
                new Product(12, "Tastiera Meccanica", 100, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjX5LdogF8VtkEro2yMZgnxRiULwy-OSQxBw&usqp=CAU", "Tastiera per gaming con switch meccanici. Offre una risposta tattile e una precisione di battitura superiori, ideale per i giocatori che cercano prestazioni elevate. Retroilluminazione personalizzabile e costruzione robusta per una durata nel tempo.", "Elettronica"),
                new Product(13, "Bici Elettrica", 1200, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYlAtasVpHT7FlicbGcDF4dCDWTEZrhNOMuA&usqp=CAU", "Bicicletta elettrica con motore potente e batteria a lunga durata. Perfetta per gli spostamenti urbani e le avventure all'aperto. Design elegante, prestazioni affidabili e comfort durante il viaggio.", "Sport e tempo libero"),
                new Product(14, "Barbecue a Gas", 400, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmC68hFeV54YeO786aqI0V4lrQoogKezBkGw&usqp=CAU", "Barbecue alimentato a gas per grigliate all'aperto. Offre una soluzione conveniente e veloce per cucinare carne, pesce e verdure. Facile da usare e pulire, ideale per feste e riunioni all'aperto.", "Casa e giardino"),
                new Product(15, "Telescopio", 800, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTTmpbaxrGFxjO302hsGHdYD055QtLGBCvhww&usqp=CAU", "Telescopio per osservare le stelle e i pianeti. Perfetto per gli astrofili e gli appassionati di astronomia che desiderano esplorare il cielo notturno. Qualità ottica superiore e design ergonomico per un'esperienza di osservazione confortevole.", "Hobby e tempo libero"),
                new Product(16, "Stampante Fotografica", 200, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSIMbhXXzA-lzYzIaG1WDgARi8NnQIxxuK_Q&usqp=CAU", "Stampante per foto di alta qualità. Ideale per stampare foto istantanee e souvenir personalizzati. Facile da usare e compatibile con una vasta gamma di formati e tipi di carta fotografica.", "Elettronica"),
                new Product(17, "Hoverboard", 250, "https://www.grecoshop.it/shop/custom/grecos/prodotti/22/OVERBOARDROSSOGRANDE.jpg", "Hoverboard elettrico per spostamenti divertenti. Offre un'esperienza di guida intuitiva e divertente, ideale per gli spostamenti urbani e i momenti di svago. Design compatto e prestazioni affidabili.", "Sport e tempo libero"),
                new Product(18, "Borsa da Viaggio", 80, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTqRGX4VMPTuoGJq-ldKqMtLsobvKWa9sivMQ&usqp=CAU", "Borsa resistente per viaggi e avventure. Perfetta per trasportare abbigliamento, accessori e altri oggetti essenziali durante i viaggi. Design versatile e materiali di alta qualità per una durata nel tempo.", "Viaggi"),
                new Product(19, "Box VR", 300, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRH3hVD4CVBNOly2fUjvLd-LaSxYRLoCgxbjA&usqp=CAU", "Sistema di realtà virtuale per allenamenti interattivi. Offre una vasta gamma di esperienze di fitness, giochi e simulazioni immersive. Ideale per allenarsi in modo divertente e motivante, direttamente a casa.", "Sport e tempo libero"),
                new Product(20, "Monitor Gaming", 600, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRNq8PSD2q4LAv9xIC4z0JmSBwZSc7ZtMXLLA&usqp=CAU", "Monitor ad alta frequenza di aggiornamento per il gaming fluido. Offre una risposta veloce e immagini nitide, ideale per i giocatori che cercano prestazioni elevate. Design ergonomico e qualità visiva superiore.", "Elettronica")

            };
            // ottieni la lista di prodotti dalla sessione Catalogo
            List<Product> catalogo = Session["Catalogo"] as List<Product>;

            // Assegna la lista di prodotti al controllo Repeater 
            CatalogoRepeater.DataSource = catalogo;
            // Visualizza i prodotti nella pagina 
            CatalogoRepeater.DataBind();
        }

        // Metodo per gestire il click del bottone Aggiungi al carrello
        // Riceve l'id del prodotto da aggiungere al carrello attraverso il CommandArgument del bottone
        // Non restituisce nulla
        protected void addToCartButton_Click(object sender, EventArgs e)
        {

            int itemId = Convert.ToInt32((sender as Button).CommandArgument);// necessario using System.Web.UI.WebControls per usare sender as Button;
            // Aggiungi il prodotto al carrello
            Response.Write(itemId + " Aggiunto al carrello<br>");
            Cart.AddToCart(itemId);
        }
    }
}