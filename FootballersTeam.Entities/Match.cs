using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Match
    {
        private readonly string _matchName;
        private readonly int _matchId;
        private readonly decimal _ticketPrice;
        private readonly DateTime _matchDate;
        private readonly int _stadiumId;
        private readonly Stadium _stadium;
        private readonly FootballResults _footballResults;

        public Match(int matchId, string matchName, decimal ticketPrice, int stadiumId, Stadium stadium, FootballResults footballResults) : this(matchId, matchName, ticketPrice, new DateTime(), stadiumId, stadium, footballResults)
        {
        }

        public Match(int matchId, string matchName, decimal ticketPrice, DateTime matchDate, int stadiumId, Stadium stadium, FootballResults footballResults)
        {
            _matchId = matchId;
            _matchName = matchName;
            _ticketPrice = ticketPrice;
            _matchDate = matchDate;
            _stadiumId = stadiumId;
            _stadium = stadium ?? throw new ArgumentNullException(nameof(stadium));
            _footballResults = footballResults ?? throw new ArgumentNullException(nameof(footballResults));
        }
        
        public override string ToString() => GetType().Name;

        ~Match() => Console.WriteLine($"The {ToString()} destructor is executing.");

        public Match(Match matchToCopyFrom)
        { 
            _matchId = matchToCopyFrom._matchId;
            _matchName = matchToCopyFrom._matchName;
            _ticketPrice = matchToCopyFrom._ticketPrice;
            _matchDate = matchToCopyFrom._matchDate;
            _stadiumId = matchToCopyFrom._stadiumId;
        }

    }
}
