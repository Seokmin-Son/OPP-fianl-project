using System;

namespace Exceptions
{
    public class InvalidCargoCapacityException : Exception
    {
        public InvalidCargoCapacityException(string message) : base(message)
        {
        }
    }
}