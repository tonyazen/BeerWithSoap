﻿
namespace BeerWithSoapService.Models.ServiceModels
{
    public class BaseRequest
    {
        public string APIKey { get; set; }
        public string ClientCode { get; set; }
        public string RequestId { get; set; }
        public string Version { get; set; }
    }
}
