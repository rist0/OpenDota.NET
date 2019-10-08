using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Requests
{
    public class Request : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _httpClientHandler;

        public string ApiKey { get; set; }

        public Request(string apiKey = null, IWebProxy proxy = null)
        {
            ApiKey = apiKey;

            _httpClientHandler = new HttpClientHandler
            {
                UseProxy = true,
                Proxy = proxy
            };

            _httpClient = new HttpClient(_httpClientHandler)
            {
                Timeout = TimeSpan.FromSeconds(30), 
                BaseAddress = new Uri("https://api.opendota.com/api/")
            };
        }

        public async Task<HttpResponseMessage> GetRequestResponseMessageAsync(string url, List<string> queryParameters = null)
        {
            try
            {
                var fullUrl = url;

                if (queryParameters == null)
                {
                    if (ApiKey != null)
                    {
                        queryParameters = new List<string>();

                        fullUrl = $@"{url}?{BuildArgumentsString(queryParameters)}";
                    }
                }
                else
                {
                    fullUrl = $@"{url}?{BuildArgumentsString(queryParameters)}";
                }

                var message = await _httpClient.GetAsync(fullUrl);

                return message;
            }
            catch (HttpRequestException ex)
            {
                var innerExceptionMsg = ex.InnerException?.Message ?? string.Empty;

                Console.WriteLine(innerExceptionMsg);

                return null;
                // re?
            }
        }

        public async Task<HttpResponseMessage> PostRequest(string url, HttpContent content = null)
        {
            content = new StringContent("");

            var response = await _httpClient.PostAsync(url, content);

            return response;
        }

        private string BuildArgumentsString(List<string> arguments)
        {
            if (ApiKey != null)
            {
                arguments.Add($@"api_key={ApiKey}");
            }

            return arguments.Where(arg => !string.IsNullOrEmpty(arg))
                            .Aggregate(string.Empty, (current, arg) => current + "&" + arg);
        }

        public void Dispose()
        {
            _httpClient.Dispose();
            _httpClientHandler.Dispose();
        }
    }
}
