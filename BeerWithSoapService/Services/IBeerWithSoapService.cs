using System.ServiceModel;
using BeerWithSoapService.Services.ServiceModels;

namespace BeerWithSoapService.Services
{
    [ServiceContract]
    public interface IBeerWithSoapService
    {
        [OperationContract]
        GetAllBeersResponse GetAllBeers(GetAllBeersRequest getAllBeersRequest);

        [OperationContract]
        GetBeerResponse GetBeer(GetBeerRequest getBeerRequest);

        [OperationContract]
        AddBeerResponse AddBeer(AddBeerRequest beerRequest);

        [OperationContract]
        UpdateBeerResponse UpdateBeer(UpdateBeerRequest updateBeerRequest);

        [OperationContract]
        DeleteBeerResponse DeleteBeer(DeleteBeerRequest deleteBeerRequest);

    }
}
