using System;

namespace Exceptions
{
    // Can be extended for more specific vehicle exceptions
    public class VehicleException : Exception
    {
        public VehicleException(string message) : base(message)
        {
            // Pass the error message to the base Exception constructor
        }
    }
}