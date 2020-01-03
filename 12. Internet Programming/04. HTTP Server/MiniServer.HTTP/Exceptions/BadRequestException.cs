using System;

namespace MiniServer.HTTP.Exceptions
{
    public class BadRequestException : Exception
    {

        private static readonly string message = "The Request was malformed or contains unsupported elements.";

        public BadRequestException() : base(message)
        {
            ;;
        }
    }
}
