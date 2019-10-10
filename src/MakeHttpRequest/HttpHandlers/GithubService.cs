using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MakeHttpRequest.HttpHandlers
{
    public class GithubService
    {
        private readonly HttpClient httpClient;
        public GithubService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public void Send()
        {
            var request = new HttpRequestMessage();
            // Dictionary <string, object>
            request.Properties.Add("someID", new StringBuilder());
            httpClient.SendAsync(request);
        }
    }
}
