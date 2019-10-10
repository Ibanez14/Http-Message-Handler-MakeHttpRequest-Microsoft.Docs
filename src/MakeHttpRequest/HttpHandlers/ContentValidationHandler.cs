using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MakeHttpRequest.HttpHandlers
{
    public class ContentHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync
            (HttpRequestMessage request, CancellationToken cancellationToken)
        {
            bool containerKey = request.Properties.ContainsKey("newKey");
            string mediaType = request.Content.Headers?.ContentType?.MediaType;
            if(containerKey)
            {
                // A ton of logic
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}
