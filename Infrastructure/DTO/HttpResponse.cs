using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DTO {
    public class HttpResponse {
        public string response { get; set; }
        public int statusCode { get; set; }
        public Exception error { get; set; }
    }
    public enum HTTPVerb {
        POST = 1,
        PUT = 2,
        GET = 3,
        OPTIONS = 4,
        DELETE = 5
    }
}
