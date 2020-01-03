using System;

namespace MiniHTTP.HTTP.Exceptions
{
    public class InternalServerErrorException : Exception
    {
        private static readonly string message = "The Server has encountered an error.";

        public InternalServerErrorException() : base(message)
        {
            ;;
        }
    }
}
