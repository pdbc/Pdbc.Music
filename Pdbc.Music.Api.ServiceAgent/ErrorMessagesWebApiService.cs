using System.Net.Http;
using System.Threading.Tasks;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Api.ServiceAgent.Extensions;
using RestSharp;

namespace Pdbc.Music.Api.ServiceAgent
{
    public class ErrorMessagesWebApiService : IErrorMessagesWebApiService
    {
        private string _route = "ErrorMessages";
        private readonly WebApiClientProxy _proxy;
        
        public ErrorMessagesWebApiService(IHttpClientFactory clientFactory, IMusicApiServiceAgentConfiguration configuration)
        {
            _proxy = new WebApiClientProxy(clientFactory, configuration.Name);
        }
       
        public async Task<ListErrorMessagesResponse> ListErrorMessages(ListErrorMessagesRequest request)
        {
            var response = await _proxy.CallAsync(c => c.GetAsync($"/{_route}/{request.Language}"));
            return await response.Deserialize<ListErrorMessagesResponse>();
        }

        public async Task<GetErrorMessageResponse> GetErrorMessage(GetErrorMessageRequest request)
        {
            var response = await _proxy.CallAsync(c => c.GetAsync($"{_route}/{request.Language}/{request.Key}"));
            return await response.Deserialize<GetErrorMessageResponse>();

           
        }
    }
}
