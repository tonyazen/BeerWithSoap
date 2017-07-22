using System.Collections.Generic;

namespace BeerWithSoapService
{
    public class GetAllBeersResponse
    {
        public BaseResponse BaseResponse { get; set; }
        public List<Beer> Beers { get; set; }

    }
}
