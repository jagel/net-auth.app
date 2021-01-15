using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Infrastructure.HandlerExceptions
{
    [Serializable]
    class DbConvertionException : Exception
    {
        public string ShortMessage { get; set; }
        public DbConvertionException() { }

        public DbConvertionException(string message)
            : base(message)
        {
            ShortMessage = message;
        }

        public DbConvertionException(string message, string shortMessage)
           : base(message)
        {
            ShortMessage = shortMessage;
        }

        public DbConvertionException(string message, Exception inner)
            : base(message, inner) { }

        public DbConvertionException(string message, Exception inner, string shortMessage)
           : base(message, inner)
        {
            ShortMessage = shortMessage;
        }
    }
}
