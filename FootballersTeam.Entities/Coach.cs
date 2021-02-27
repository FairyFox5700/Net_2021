using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Coach:Person
    {
        private readonly int _countOfVictories;
        private readonly int _yearsOfExperience;
        private readonly int _clubId;

        public Coach(int personId, string firstName, string middleName, string nationality, DateTime dataOfBirth,
            string placeOfBirth, int countOfVictories, int yearsOfExperience, int clubId) 
            : base(personId, firstName, middleName, nationality, dataOfBirth, placeOfBirth)
        {
            _countOfVictories = countOfVictories;
            _yearsOfExperience = yearsOfExperience;
            _clubId = clubId;
            FootballClubs = new List<FootballClub>();
            Trainings = new List<Training>();
        }

        public  ICollection<FootballClub> FootballClubs  { get; set; }
        public ICollection<Training> Trainings { get; set; }

        public Coach(int personId, string firstName, string middleName, string nationality, 
            DateTime dataOfBirth, string placeOfBirth) 
            : base(personId, firstName, middleName, nationality, dataOfBirth, placeOfBirth)
        {
        }
        
        public override string ToString() => GetType().Name;

        ~Coach() => Console.WriteLine($"The {ToString()} destructor is executing.");

        public Coach(Coach coachToCopyFrom,int personId, string firstName, string middleName, string nationality, 
            DateTime dataOfBirth, string placeOfBirth) 
            : base(personId, firstName, middleName, nationality, dataOfBirth, placeOfBirth)
        {
            _countOfVictories = coachToCopyFrom._countOfVictories;
            _yearsOfExperience = coachToCopyFrom._yearsOfExperience;
            _clubId = coachToCopyFrom._clubId;
        }
    }
}
