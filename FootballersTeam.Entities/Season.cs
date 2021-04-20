using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Season
    {
        private readonly int _seasonId;
        private readonly string _leagueName;

        public Season()
        {

        }
        public Season(int seasonId, string leagueName)
        {
            _seasonId = seasonId;
            _leagueName = leagueName;
            FootballClubsSeasones = new List<FootballClubsSeasons>();
        }

        public override string ToString() => GetType().Name;

        ~Season() => Console.WriteLine($"The {ToString()} destructor is executing.");

        protected Season(Season seasonToCopyFrom)
        {
            _seasonId = seasonToCopyFrom._seasonId;
            _leagueName = seasonToCopyFrom._leagueName;
        }
        public ICollection<FootballClubsSeasons> FootballClubsSeasones { get; set; }
    }
}
