using Newtonsoft.Json;
using Pdbc.Music.Api.ServiceAgent.Exceptions;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Pdbc.Music.Api.ServiceAgent.Extensions
{
    public static class HttpResponseMessageExtensions
    {
        /// <summary>
        /// Deserialization of the response to the expected response + error handling
        /// </summary>
        /// <param name="response"></param>
        /// <typeparam name="TResponse"></typeparam>
        /// <returns></returns>
        public static async Task<TResponse> Deserialize<TResponse>(this HttpResponseMessage response)
        {
            try
            {
                var r = await response.Content.ReadAsStringAsync();
                var r2 = JsonConvert.DeserializeObject<TResponse>(r);
                return r2;

                //var r2 = JsonSerializer.Deserialize<TResponse>(r);
                ////return r2;

                //await using var responseStream = await response.Content.ReadAsStreamAsync();
                //var result = await JsonSerializer.DeserializeAsync<TResponse>(responseStream);
                //return result;

            }
            catch (Exception ex)
            {
                return await response.HandleRequestCannotDeserialize<TResponse>().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Handling of invalid response (response status is not a success status code)
        /// </summary>
        /// <param name="response"></param>
        /// <typeparam name="TResponse"></typeparam>
        /// <returns></returns>
        public static async Task<TResponse> HandleInvalidResponse<TResponse>(this HttpResponseMessage response)
        {
            return await response.HandleRequestCannotDeserialize<TResponse>(response.StatusCode).ConfigureAwait(false);
        }

        /// <summary>
        /// Handling of invalid response (response status is not a success status code)
        /// </summary>
        /// <param name="response"></param>
        /// <typeparam name="TResponse"></typeparam>
        /// <returns></returns>
        public static async Task<TResponse> HandleRequestCannotDeserialize<TResponse>(this HttpResponseMessage response,
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
        {

            var r = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);

            throw new ServiceAgentException();
            //var requestUri = response.RequestMessage.RequestUri;
            //var requestMethod = response.RequestMessage.Method;

            //var request = await response.RequestMessage.Content.ReadAsStringAsync()
            //    .ConfigureAwait(false);

            //_log.Warn($"HandleRequestCannotDeserialize: {requestUri} - {requestMethod} - {request}");
            //_log.Warn($"HandleRequestCannotDeserialize: {response.StatusCode} - {response.ReasonPhrase}");
            //_log.Warn($"HandleRequestCannotDeserialize: {r}");

            //throw new WebApiClientException(r) { HttpStatusCode = statusCode };
        }

    }
}
