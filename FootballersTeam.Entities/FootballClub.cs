using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class FootballClub
    {
        private readonly int _footballClubId;
        private string _footballClubName;

        public FootballClub(int footballClubId, string footballClubName)
        {
            _footballClubId = footballClubId;
            _footballClubName = footballClubName;
            FootballClubsSeasons = new List<FootballClubsSeasons>();
            Logos = new List<Logo>();
            SponsorsClubs = new List<SponsoredClubs>();
        }

        public ICollection<FootballClubsSeasons> FootballClubsSeasons { get; set; }
        public ICollection<Logo> Logos { get; set; }
        public ICollection<SponsoredClubs> SponsorsClubs { get; set; }

        public override string ToString() => GetType().Name;

        ~FootballClub() => Console.WriteLine($"The {ToString()} destructor is executing.");

        public FootballClub(FootballClub footballerClubToCopyFrom)
        {
            _footballClubId = footballerClubToCopyFrom._footballClubId;
            _footballClubName = footballerClubToCopyFrom._footballClubName;
        }
    }
}
