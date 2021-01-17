using System;

namespace MiniServer.HTTP
{
    public class InternalServerErrorException : Exception
    {
        public const string error = "The Server has encountered an error.";

        public InternalServerErrorException()
        {
            throw new Exception(error);
        }
    }
}
