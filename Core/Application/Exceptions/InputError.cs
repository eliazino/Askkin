using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Application.Exceptions {
    public class InputError : Exception{
        public InputError(string message = "Invalid input.") : base(message) { }
    }
}
