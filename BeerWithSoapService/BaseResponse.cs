using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerWithSoapService
{
    public class BaseResponse
    {
        public DateTime RequestTimeStamp { get; set; }
        public String RequestId { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
        public string DisplayErrorMessage { get; set; }
        public string TechnicalErrorMessage { get; set; }
    }

    public enum ResponseStatus
    {
        Success,
        Failure
    }


}
