using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Application.Exceptions {
    public class AuthenticationError : Exception{
        public AuthenticationError(string message = "Invalid Profile. Access denied") : base(message) { }
    }
}
