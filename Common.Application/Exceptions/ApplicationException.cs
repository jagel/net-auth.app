using Common.Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Application.Exceptions
{
    public class ApplicationException : Exception
    {
        public ErrorResponse ModelResponse { get; set; }
        public ApplicationException(ErrorResponse errorResponse) : base(errorResponse.MessageError)
        {
            ModelResponse = errorResponse;
        }
    }
}
