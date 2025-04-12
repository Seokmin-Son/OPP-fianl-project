using System;

namespace Exceptions
{
    public class InvalidSpeedException : Exception
    {
        public InvalidSpeedException(string message) : base(message)
        {
        }
    }
}
