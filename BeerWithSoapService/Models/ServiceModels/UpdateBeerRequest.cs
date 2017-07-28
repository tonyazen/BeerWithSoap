
namespace BeerWithSoapService.Models.ServiceModels
{
    public class UpdateBeerRequest
    {
        public BaseRequest BaseRequest { get; set; }
        public Beer Beer { get; set; }
    }
}
