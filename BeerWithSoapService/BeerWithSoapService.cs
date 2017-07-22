using System;

namespace BeerWithSoapService
{
    public class BeerWithSoapService : IBeerWithSoapService
    {
        public AddBeerResponse AddBeer(AddBeerRequest addBeerRequest)
        {
            var response = new AddBeerResponse()
            {
                BaseResponse = CreateBaseResponse(addBeerRequest.BaseRequest)
            };

            response.BaseResponse = VerifyBaseRequest(addBeerRequest.BaseRequest, response.BaseResponse);

            if (response.BaseResponse.ResponseStatus == ResponseStatus.Failure)
            {
                response.Beer = null;
                return response;
            }

            var beer = new Beer
            {
                Id = 011,
                Name = addBeerRequest.Beer.Name,
                Style = addBeerRequest.Beer.Style,
                Abv = addBeerRequest.Beer.Abv,
                Brewery = addBeerRequest.Beer.Brewery
            };

            response.Beer = beer;
            return response;
        }

        public DeleteBeerResponse DeleteBeer(DeleteBeerRequest deleteBeerRequest)
        {
            var response = new DeleteBeerResponse()
            {
                BaseResponse = CreateBaseResponse(deleteBeerRequest.BaseRequest)
            };

            response.BaseResponse = VerifyBaseRequest(deleteBeerRequest.BaseRequest, response.BaseResponse);

            return response;
        }

        public GetAllBeersResponse GetAllBeers(GetAllBeersRequest getAllBeersRequest)
        {
            var response = new GetAllBeersResponse()
            {
                BaseResponse = CreateBaseResponse(getAllBeersRequest.BaseRequest)
            };

            response.BaseResponse = VerifyBaseRequest(getAllBeersRequest.BaseRequest, response.BaseResponse);

            if (response.BaseResponse.ResponseStatus == ResponseStatus.Failure)
            {
                response.Beers = null;
                return response;
            }

            var beer = new Beer();
            var beers = beer.GetAllBeers();

            response.Beers = beers;
            return response;
        }

        public GetBeerResponse GetBeer(GetBeerRequest getBeerRequest)
        {
            var response = new GetBeerResponse()
            {
                BaseResponse = CreateBaseResponse(getBeerRequest.BaseRequest)
            };

            response.BaseResponse = VerifyBaseRequest(getBeerRequest.BaseRequest, response.BaseResponse);

            if (response.BaseResponse.ResponseStatus == ResponseStatus.Failure)
            {
                response.Beer = null;
                return response;
            }

            var beer = new Beer();
            var beers =  beer.GetAllBeers();

            foreach (var b in beers)
            {
                if (b.Id == getBeerRequest.Id)
                    response.Beer = b;
            }

            return response;
        }

        public UpdateBeerResponse UpdateBeer(UpdateBeerRequest updateBeerRequest)
        {
            var response = new UpdateBeerResponse()
            {
                BaseResponse = CreateBaseResponse(updateBeerRequest.BaseRequest)
            };

            response.BaseResponse = VerifyBaseRequest(updateBeerRequest.BaseRequest, response.BaseResponse);

            if (response.BaseResponse.ResponseStatus == ResponseStatus.Failure)
            {
                response.Beer = null;
                return response;
            }

            var beer = new Beer();
            var beers = beer.GetAllBeers();

            foreach (var b in beers)
            {
                if (b.Id == updateBeerRequest.Beer.Id)
                {
                    beer.Name = updateBeerRequest.Beer.Name;
                    beer.Style = updateBeerRequest.Beer.Style;
                    beer.Abv = updateBeerRequest.Beer.Abv;
                    beer.Brewery = updateBeerRequest.Beer.Brewery;
                };

                response.Beer = beer;
            }

            return response;
        }

        private BaseResponse VerifyBaseRequest(BaseRequest baseRequest, BaseResponse baseResponse)
        {
            if (baseRequest.APIKey != "ILoveBeer")
                baseResponse.TechnicalErrorMessage = "The API Key is not valid";
            if (baseRequest.ClientCode != "TonyaZen")
                baseResponse.TechnicalErrorMessage = "The Client Code is not valid";
            if (string.IsNullOrEmpty(baseRequest.RequestId))
                baseResponse.TechnicalErrorMessage = "Request Id is required";
            baseResponse.ResponseStatus = baseResponse.TechnicalErrorMessage.Length > 0 ? ResponseStatus.Success : ResponseStatus.Failure;
            return baseResponse;
        }

        private BaseResponse CreateBaseResponse(BaseRequest baseRequest)
        {
            return new BaseResponse
            {
                RequestTimeStamp = DateTime.Now,
                RequestId = baseRequest.RequestId,
                ResponseStatus = ResponseStatus.Success
            };
        }
        
    }
}
