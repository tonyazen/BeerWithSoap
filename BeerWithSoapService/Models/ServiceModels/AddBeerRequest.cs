
namespace BeerWithSoapService.Models.ServiceModels
{
    public class AddBeerRequest
    {
        public BaseRequest BaseRequest { get; set; }
        public AddBeer Beer { get; set; }
    }
}
