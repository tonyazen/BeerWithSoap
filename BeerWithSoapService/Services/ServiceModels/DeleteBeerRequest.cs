﻿
namespace BeerWithSoapService.Services.ServiceModels
{
    public class DeleteBeerRequest
    {
        public BaseRequest BaseRequest { get; set; }
        public int Id { get; set; }
    }
}