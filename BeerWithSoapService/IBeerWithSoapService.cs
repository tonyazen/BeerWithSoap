﻿using System.ServiceModel;
using BeerWithSoapService.Models.ServiceModels;

namespace BeerWithSoapService
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
