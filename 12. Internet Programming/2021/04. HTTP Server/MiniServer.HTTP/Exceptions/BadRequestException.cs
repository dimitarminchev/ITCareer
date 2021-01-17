using System;

namespace MiniServer.HTTP
{
    public class BadRequestException : Exception
    {
        public const string error = "The Request was malformed or contains unsupported elements.";

        public BadRequestException()
        {
            throw new Exception(error);
        }

        public BadRequestException(string message) : base(message)
        {
            throw new Exception(message);
        }
    }
}
