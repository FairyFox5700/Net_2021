#nullable  enable
using System;
using System.Runtime.Serialization;

namespace FootballersTeam.ConsoleClient.Exceptions
{
    [Serializable]
    public class InvalidFootballerWeightException: Exception
    {
        public InvalidFootballerWeightException()
        {
        }

        protected InvalidFootballerWeightException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
   
        public InvalidFootballerWeightException(string? weight) :  base($"Invalid Footballer weight: {weight}")
        {
        }

        public InvalidFootballerWeightException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
#nullable restore