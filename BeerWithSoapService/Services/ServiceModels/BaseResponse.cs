using System;

namespace BeerWithSoapService.Services.ServiceModels
{
    public class BaseResponse
    {
        public DateTime RequestTimeStamp { get; set; }
        public String RequestId { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
        public string DisplayErrorMessage { get; set; }
        public string TechnicalErrorMessage { get; set; }
    }

    [Serializable]
    public enum ResponseStatus
    {
        Success,
        Failure
    }


}
