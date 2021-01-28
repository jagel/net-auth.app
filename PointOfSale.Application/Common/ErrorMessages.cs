using Common.Domain.Models.Response;
using common = Common.Application.Exceptions;

namespace PointOfSale.Application.Common
{
    public static class ErrorMessages
    {
        public readonly static ErrorResponse UsernameAlreadyExist = new ErrorResponse
        {
            AddditionalInformation = "The user is registered in the database previously",
            ApplicationName = "Point Of sale",
            MessageError = "User exist in database",
            Origin = "Validations",
            ResponseCode = System.Net.HttpStatusCode.Conflict
        };

    }
}
