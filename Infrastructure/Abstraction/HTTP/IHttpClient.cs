using Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Abstraction.HTTP {
    public interface IHttpClient {
        Task<HttpResponse> client(string url, string request, HTTPVerb verb, string contenttype, Dictionary<string, string> headers = null);
    }
}
