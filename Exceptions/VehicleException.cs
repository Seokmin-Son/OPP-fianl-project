using System;

namespace Exceptions
{
    public class VehicleException : Exception
    {
        public VehicleException(string message) : base(message)
        {
        }
    }
}