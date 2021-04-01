using System.Threading.Tasks;
using Pdbc.Music.Api.Contracts.Requests.Errors;

namespace Pdbc.Music.Api.Contracts
{
    /// <summary>
    /// Service for getting the translations of error keys
    /// </summary>
    public interface IErrorService
    {

        /// <summary>
        /// Gets the error translations.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<ListErrorsResponse> ListErrorMessages(ListErrorsRequest request);

        /// <summary>
        /// Gets the specified error translation.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<GetErrorResponse> GetErrorMessage(GetErrorRequest request);
    }
}
