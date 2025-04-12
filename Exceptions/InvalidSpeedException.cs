using System;

class InvalidSpeedException : VehicleException
{
    public InvalidSpeedException(string message) : base(message)
    {
    }
}
