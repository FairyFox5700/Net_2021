using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Card
    {
        private readonly int _cardId;
        private readonly int _redCardCount;
        private readonly int _yellowCardCount;

        public Card()
        {
            
        }

        public Card(int cardId, int redCardCount, int yellowCardCount,FootballResults footballeResult)
        {
            _cardId = cardId;
            _redCardCount = redCardCount;
            _yellowCardCount = yellowCardCount;
        }

        public FootballResults FootballResults { get; set; }
        
        public override string ToString() => GetType().Name;

        ~Card() => Console.WriteLine($"The {ToString()} destructor is executing.");
        
        public Card(Card cardToCopyFrom)
        {
            _cardId = cardToCopyFrom._cardId;
            _redCardCount = cardToCopyFrom._redCardCount;
            _yellowCardCount = cardToCopyFrom._yellowCardCount;
        }
    }
}
