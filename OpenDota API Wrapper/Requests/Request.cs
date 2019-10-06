using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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
                Timeout = TimeSpan.FromSeconds(30)
            };

            _httpClient.DefaultRequestHeaders.Add("User-Agent",
                                                  "Mozilla/5.0 (Windows NT 6.4; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2225.0 Safari/537.36");
            _httpClient.BaseAddress = new Uri("https://api.opendota.com/api/");
        }

        public async Task<HttpResponseMessage> GetRequestResponseMessageAsync(string url, List<string> queryParameters = null)
        {
            try
            {
                if (queryParameters == null)
                {
                    if (ApiKey != null)
                    {
                        queryParameters = new List<string>();
                    }
                }

                var urlWithQueryParameters = queryParameters == null ? url : $@"{url}?{BuildArgumentsString(queryParameters)}";

                var message = await _httpClient.GetAsync(urlWithQueryParameters);

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

        public async Task<HttpResponseMessage> PostRequest(string url, List<string> queryParameters = null)
        {
            // TODO: This
            return null;
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
