﻿using System;

namespace MiniServer.HTTP
{
    public class InternalServerErrorException : Exception
    {
        private const string InternalServerErrorExceptionDefaultMessage = "The Server has encountered an error.";

        public InternalServerErrorException() : this(InternalServerErrorExceptionDefaultMessage)
        {
            ;;
        }

        public InternalServerErrorException(string name) : base(name)
        {
            ;;
        }
    }
}
