using System;

class InvalidPriceException : VehicleException
{
    public InvalidPriceException(string message) : base(message)
    {
    }
}
