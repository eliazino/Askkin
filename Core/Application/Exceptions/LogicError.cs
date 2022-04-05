using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Application.Exceptions {
    public class LogicError : Exception {
        public LogicError(string message = "Logic Error") : base(message) { }
    }
}
