using System;

namespace MiniServer.HTTP.Exceptions
{
    public class BadRequestException : Exception
    {
        private const string BadRequestExceptionDefaultMessage = "The Request was malformed or contains unsupported elements.";

        public BadRequestException() : this(BadRequestExceptionDefaultMessage)
        {
            ; ;
        }

        public BadRequestException(string name) : base(name)
        {
            ; ;
        }
    }
}
