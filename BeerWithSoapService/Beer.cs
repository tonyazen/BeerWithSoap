using System.Collections.Generic;

namespace BeerWithSoapService
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Style Style { get; set; }
        public string Abv { get; set; }
        public string Brewery { get; set; }

        public List<Beer> GetAllBeers()
        {
            var beers = new List<Beer>();

            beers.Add(new Beer
            {
                Id = 001,
                Name = "Red's Rye",
                Style = Style.IPA,
                Abv = "6.6%",
                Brewery = "Founder's Brewing Co."
            });
            beers.Add(new Beer
            {
                Id = 002,
                Name = "Fresh Squeezed",
                Style = Style.IPA,
                Abv = "6.4%",
                Brewery = "Deschutes Brewery"
            });
            beers.Add(new Beer
            {
                Id = 003,
                Name = "Dragon's Milk",
                Style = Style.Stout,
                Abv = "11%",
                Brewery = "New Holland Brewing Co."
            });
            beers.Add(new Beer
            {
                Id = 004,
                Name = "Two Hearted Ale",
                Style = Style.IPA,
                Abv = "7%",
                Brewery = "Bell's Brewery"
            });
            beers.Add(new Beer
            {
                Id = 005,
                Name = "Grapefruit IPA",
                Style = Style.IPA,
                Abv = "5%",
                Brewery = "Perrin Brewing Co."
            });
            beers.Add(new Beer
            {
                Id = 006,
                Name = "Kentucky Breakfast Stout",
                Style = Style.Stout,
                Abv = "12.4%",
                Brewery = "Founder's Brewing Co."
            });
            beers.Add(new Beer
            {
                Id = 007,
                Name = "Victory at Sea",
                Style = Style.Porter,
                Abv = "10%",
                Brewery = "Ballast Point Brewing Company"
            });
            beers.Add(new Beer
            {
                Id = 008,
                Name = "Vanilla Porter",
                Style = Style.Porter,
                Abv = "5.4%",
                Brewery = "Breckenridge Brewery"
            });
            beers.Add(new Beer
            {
                Id = 009,
                Name = "DryPA",
                Style = Style.PaleAle,
                Abv = "6.2%",
                Brewery = "Greyline Brewing Co."
            });
            beers.Add(new Beer
            {
                Id = 010,
                Name = "Chaga Khan",
                Style = Style.Stout,
                Abv = "10.4",
                Brewery = "City Built Brewing"
            });


            return beers;
        }

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
        ScotchAle
    }
}
