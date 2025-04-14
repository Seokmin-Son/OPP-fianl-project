using System;

namespace Exceptions
{
    //Thrown when cargo capacity is outside acceptable range
    public class InvalidCargoCapacityException : Exception
    {
        public InvalidCargoCapacityException(string message) : base(message)
        {
            // Pass the error message to the base Exception constructor
        }
    }
}