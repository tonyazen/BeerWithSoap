using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace BeerWithSoapService.Services
{
    class BeerRepository
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(BeerRepository));
        private List<Beer> _beerStore = new List<Beer>();

        public BeerRepository()
        {
            var beers = new List<Beer>
            {
                new Beer
                {
                    Id = 001,
                    Name = "Red's Rye",
                    Style = Style.IPA,
                    Abv = "6.6%",
                    Brewery = "Founder's Brewing Co."
                },
                new Beer
                {
                    Id = 002,
                    Name = "Fresh Squeezed",
                    Style = Style.IPA,
                    Abv = "6.4%",
                    Brewery = "Deschutes Brewery"
                },
                new Beer
                {
                    Id = 003,
                    Name = "Dragon's Milk",
                    Style = Style.Stout,
                    Abv = "11%",
                    Brewery = "New Holland Brewing Co."
                },
                new Beer
                {
                    Id = 004,
                    Name = "Two Hearted Ale",
                    Style = Style.IPA,
                    Abv = "7%",
                    Brewery = "Bell's Brewery"
                },
                new Beer
                {
                    Id = 005,
                    Name = "Grapefruit IPA",
                    Style = Style.IPA,
                    Abv = "5%",
                    Brewery = "Perrin Brewing Co."

                },
                new Beer
                {
                    Id = 006,
                    Name = "Kentucky Breakfast Stout",
                    Style = Style.Stout,
                    Abv = "12.4%",
                    Brewery = "Founder's Brewing Co."
                },
                new Beer
                {
                    Id = 007,
                    Name = "Victory at Sea",
                    Style = Style.Porter,
                    Abv = "10%",
                    Brewery = "Ballast Point Brewing Company"
                },
                new Beer
                {
                    Id = 008,
                    Name = "Vanilla Porter",
                    Style = Style.Porter,
                    Abv = "5.4%",
                    Brewery = "Breckenridge Brewery"
                },
                new Beer
                {
                    Id = 009,
                    Name = "DryPA",
                    Style = Style.PaleAle,
                    Abv = "6.2%",
                    Brewery = "Greyline Brewing Co."
                },
                new Beer
                {
                    Id = 010,
                    Name = "Chaga Khan",
                    Style = Style.Stout,
                    Abv = "10.4",
                    Brewery = "City Built Brewing"
                }
            };

            _beerStore = beers;
        }

        public List<Beer> GetAllBeers()
        {
            if (_beerStore != null)
                return _beerStore;

            return new List<Beer>
            {
                new Beer
                {
                    Id = 0,
                    Name = "",
                    Abv = "",
                    Brewery = "",
                    Style = Style.Other
                }
            };
        }

        public Beer GetBeer(int id)
        {
            if (_beerStore != null)
            {
                try
                {
                    return _beerStore.FirstOrDefault(beer => beer.Id == id);
                }
                catch (Exception ex)
                {
                    _logger.Error($"GetBeer Exception. Id: {id}. Exception: {ex}");
                    return null;
                }
            }

            return null;
        }

        public Beer AddBeer(AddBeer beer)
        {
            if (_beerStore != null)
            {
                try
                {
                    var maxId = _beerStore.Max(b => b.Id);
                    var newBeer = new Beer
                    {
                        Id = maxId + 1,
                        Name = beer.Name,
                        Abv = beer.Abv,
                        Brewery = beer.Brewery,
                        Style = beer.Style
                    };

                    _beerStore.Add(newBeer);

                    return null;
                }
                catch (Exception ex)
                {
                    _logger.Error($"AddBeer Exception. Beer: {beer.Name}, {beer.Style}, {beer.Abv}, {beer.Brewery}. Exception: {ex}");
                    return null;
                }
            }

            return null;
        }

        public Beer UpdateBeer(Beer updateBeer)
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                try
                {
                    foreach (var beer in _beerStore)
                    {
                        if (beer.Id == updateBeer.Id)
                        {
                            beer.Name = updateBeer.Name;
                        }
                    }

                    return _beerStore.FirstOrDefault(beer => beer.Id == updateBeer.Id);
                }
                catch (Exception ex)
                {
                    _logger.Error($"UpdateBeer Exception. Id: {updateBeer.Id}. Exception: {ex}");
                    return updateBeer;
                }
            }

            return updateBeer;
        }

        public bool DeleteBeer(int id)
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                try
                {
                    var beerToRemove = _beerStore.FirstOrDefault(beer => beer.Id == id);
                    _beerStore.Remove(beerToRemove);

                    return true;
                }
                catch (Exception ex)
                {
                    _logger.Error($"DeleteBeer Exception. Id: {id}. Exception: {ex}.");
                    return false;
                }
            }

            return false;
        }
    }
}