
namespace BeerWithSoapService
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Style Style { get; set; }
        public string Abv { get; set; }
        public string Brewery { get; set; }
    }

    public class AddBeer
    {
        public string Name { get; set; }
        public Style Style { get; set; }
        public string Abv { get; set; }
        public string Brewery { get; set; }
    }

    public enum Style
    {
        Ale,
        Lager,
        Stout,
        IPA,
        PaleAle,
        Pilsner,
        Wheat,
        BrownAle,
        Bitter,
        Boch,
        BarleyWine,
        Porter,
        Saison,
        Lambic,
        Kolsch,
        Dunkel,
        CreamAle,
        Tripel,
        Dubbel,
        Gose,
        AmericanPaleAle,
        ScotchAle,
		Rye,
        Other
    }
}
