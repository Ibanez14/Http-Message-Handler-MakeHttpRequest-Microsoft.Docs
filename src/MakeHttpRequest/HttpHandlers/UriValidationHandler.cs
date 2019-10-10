using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace MakeHttpRequest.HttpHandlers
{
    public class UriHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync
            (HttpRequestMessage request,
            CancellationToken cancellationToken)
        {

            var request2 = request.RequestUri.ToString();

            request.Properties.Add("newKey", new Program());

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
