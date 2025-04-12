using System;

class InvalidCargoCapacityException : VehicleException
{
    public InvalidCargoCapacityException(string message) : base(message)
    {
    }
}
