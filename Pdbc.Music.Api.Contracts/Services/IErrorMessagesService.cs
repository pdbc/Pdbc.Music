using System.Threading.Tasks;
using Pdbc.Music.Api.Contracts.Requests.Errors;

namespace Pdbc.Music.Api.Contracts
{
    /// <summary>
    /// Service for getting the translations of error keys
    /// </summary>
    public interface IErrorMessagesService
    {

        /// <summary>
        /// Gets the error translations.
        /// </summary>
        /// <param name="request">The messageRequest.</param>
        /// <returns></returns>
        Task<ListErrorMessagesResponse> ListErrorMessages(ListErrorMessagesRequest request);

        /// <summary>
        /// Gets the specified error translation.
        /// </summary>
        /// <param name="messageRequest">The messageRequest.</param>
        /// <returns></returns>
        Task<GetErrorMessageResponse> GetErrorMessage(GetErrorMessageRequest messageRequest);
    }
}
