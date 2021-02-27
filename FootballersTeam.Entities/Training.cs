using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Training
    {
        private readonly int _trainingId;
        private readonly DateTime _trainingData;
        private readonly int _coachId;
        private readonly int _stadiumId;
        private Coach _coach;
        private Stadium _stadium;

        public Training(int trainingId, DateTime trainingData, int coachId, int stadiumId, Coach coach, Stadium stadium)
        {
            _trainingId = trainingId;
            _trainingData = trainingData;
            _coachId = coachId;
            _stadiumId = stadiumId;
            Coach = coach;
            Stadium = stadium;
        }

        public override string ToString() => GetType().Name;

        ~ Training() => Console.WriteLine($"The {ToString()} destructor is executing.");

        protected Training(Training trainingToCopyFrom)
        { 
            _trainingId = trainingToCopyFrom._trainingId;
            _trainingData = trainingToCopyFrom._trainingData;
            _coachId = trainingToCopyFrom._coachId;
            _stadiumId = trainingToCopyFrom._stadiumId;
        }
        
        public Coach Coach
        {
            get => _coach;
            set => _coach = value;
        }

        public Stadium Stadium
        {
            get => _stadium;
            set => _stadium = value;
        }
    }
}
