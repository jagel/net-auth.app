using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Common.Domain.Models.Response
{
    public class ResponseStandardModel<TModelResponse>
    {
        public TModelResponse Response { get; set; }
        public string Message { get; set; }
        public IEnumerable<ErrorResponse> Errors { get; set; }
    }
}
