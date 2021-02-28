using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class FootballResults
    {
        private readonly int _resultId;
        private readonly int _scoreId;
        private readonly int? _cardId;
        private readonly int _matchId;
        private readonly int _footballerId;

        public FootballResults()
        {
            
        }
        public FootballResults(int resultId, int scoreId, int? cardId, int matchId, int footballerId, Card card, 
            Footballer footballer, Match match, Score score)
        {
            _resultId = resultId;
            _scoreId = scoreId;
            _cardId = cardId;
            _matchId = matchId;
            _footballerId = footballerId;
            Card = card ?? throw new ArgumentNullException(nameof(card));
            Footballer = footballer ?? throw new ArgumentNullException(nameof(footballer));
            Match = match ?? throw new ArgumentNullException(nameof(match));
            Score = score ?? throw new ArgumentNullException(nameof(score));
        }

        public Card Card { get; set; }
        public Footballer Footballer { get; set; }
        public Match Match { get; set; }
        public Score Score { get; set; }
        
        
        public override string ToString() => GetType().Name;

        ~FootballResults() => Console.WriteLine($"The {ToString()} destructor is executing.");

        public FootballResults(FootballResults footballResultsToCopyFrom)
        {
            _resultId = footballResultsToCopyFrom._resultId;
            _scoreId = footballResultsToCopyFrom._scoreId;
            _cardId = footballResultsToCopyFrom._cardId;
            _matchId = footballResultsToCopyFrom._matchId;
            _footballerId = footballResultsToCopyFrom._footballerId;
        }
       
    }
}
