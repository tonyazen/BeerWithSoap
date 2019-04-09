using System;
using System.Collections.Generic;
using System.Linq;
using log4net;

namespace BeerWithSoapService
{
    class BeerRepository
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(BeerRepository));
        private static List<Beer> _beerStore { get; set; }

        public BeerRepository()
        {
            var beers = new List<Beer>
            {
                new Beer
                {
                    Id = 001,
	                Name = "Red Eye Rye",
                    Style = Style.Rye,
	                Abv = "6.7%",
                    Brewery = "Detroit Beer Co."
				},
                new Beer
                {
                    Id = 002,
	                Name = "Poetic Pestilence",
                    Style = Style.IPA,
	                Abv = "11%",
                    Brewery = "Jolly Pumpkin Brewery"
				},
                new Beer
                {
                    Id = 003,
	                Name = "Vanilla Java Porter",
                    Style = Style.Porter,
	                Abv = "5%",
                    Brewery = "Atwater Brewery & Tap House"
				},
                new Beer
                {
                    Id = 004,
	                Name = "Breakfast Stout",
                    Style = Style.Stout,
	                Abv = "8.3%",
                    Brewery = "Founders Brewing Co."
				},
                new Beer
                {
                    Id = 005,
	                Name = "The Duke",
                    Style = Style.PaleAle,
	                Abv = "5.4%",
                    Brewery = "Granite City Brewery"
				}
            };

            _beerStore = beers;
        }

        public List<Beer> GetAllBeers()
        {
            if (_beerStore != null)
            {
                return _beerStore;
            }

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
                    return _beerStore.FirstOrDefault(b => b.Id == id);
                }
                catch(Exception ex)
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

                    return newBeer;
                }
                catch (Exception ex)
                {
                    _logger.Error(
                        $"AddBeer Exception. Beer: {beer.Name}, {beer.Style}, {beer.Abv}, {beer.Brewery}. Exception: {ex}");
                    return null;
                }
            }

            return null;
        }

        public Beer UpdateBeer(Beer updateBeer)
        {
            if (_beerStore != null)
            {
                try
                {
                    foreach (var beer in _beerStore)
                    {
                        if (beer.Id == updateBeer.Id)
                        {
                            beer.Name = updateBeer.Name;
                            beer.Abv = updateBeer.Abv;
                            beer.Style = updateBeer.Style;
                            beer.Brewery = updateBeer.Brewery;
                        }
                    }

                    return updateBeer;
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

            if (_beerStore != null)
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