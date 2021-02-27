using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Score
    {
        private readonly int _scoreId;
        private readonly int _scoredGoals;
        private readonly int _missedGoals;

        public Score(int scoreId, int scoredGoals, int missedGoals, FootballResults footballResults)
        {
            _scoreId = scoreId;
            _scoredGoals = scoredGoals;
            _missedGoals = missedGoals;
            FootballResults = footballResults;
        }
        public override string ToString() => GetType().Name;

        ~Score() => Console.WriteLine($"The {ToString()} destructor is executing.");

        protected Score(Score scoreToCopyFrom)
        { 
            
            _scoreId = scoreToCopyFrom._scoreId;
            _scoredGoals =  scoreToCopyFrom._scoredGoals;
            _missedGoals =  scoreToCopyFrom._missedGoals;
        }

        public FootballResults FootballResults { get; set; }
    }
}
