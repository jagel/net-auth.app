using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Application.ExceptionHandler
{
    [Serializable]
    public class ExceptionConvertion : Exception
    {
        public string ShortMessage { get; set; }
        public ExceptionConvertion() { }

        public ExceptionConvertion(string message)
            : base(message) {
            ShortMessage = message;
        }

        public ExceptionConvertion(string message, string shortMessage)
           : base(message) { 
            ShortMessage = shortMessage;
        }

        public ExceptionConvertion(string message, Exception inner)
            : base(message, inner) { }

        public ExceptionConvertion(string message, Exception inner, string shortMessage)
           : base(message, inner) { 
            ShortMessage = shortMessage;
        }

    }
}
