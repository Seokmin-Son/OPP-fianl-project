using System;

namespace Exceptions
{
    // Thrown when a negative price is attempted to be set
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException(string message) : base(message)
        {
            // Pass the error message to the base Exception constructor
        }
    }
}
