using Common.Domain.Models.Response;
using System;

namespace Common.Infrastructure.Common
{
    public class InfrastructureException : Exception
    {
        public ErrorResponse ModelResponse { get; set; }
        public InfrastructureException(ErrorResponse errorResponse) : base(errorResponse.MessageError)
        {
            ModelResponse = errorResponse;
        }
    }
}
