#nullable  enable
using System;
using System.Runtime.Serialization;

namespace FootballersTeam.ConsoleClient.Exceptions
{
    [Serializable]
    public class InvalidFootballerHeightException:Exception
    {
        public InvalidFootballerHeightException()
        {
        }

        protected InvalidFootballerHeightException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public InvalidFootballerHeightException(string? height) : base($"Invalid Footballer height: {height}")
        {
        }

        public InvalidFootballerHeightException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
#nullable restore