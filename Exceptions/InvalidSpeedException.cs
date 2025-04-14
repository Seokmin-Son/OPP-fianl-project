using System;

namespace Exceptions
{
    // Thrown when speed is set to zero or negative value
    public class InvalidSpeedException : Exception
    {
        public InvalidSpeedException(string message) : base(message)
        {
            // Pass the error message to the base Exception constructor

        }
    }
}
