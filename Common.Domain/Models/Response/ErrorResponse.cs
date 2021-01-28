using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Common.Domain.Models.Response
{
    public class ErrorResponse
    {
        public string Origin { get; set; }
        public string MessageError { get; set; }
        public string ApplicationName { get; set; }
        public string AddditionalInformation { get; set; }
        public HttpStatusCode ResponseCode { get; set; }
    }
}
