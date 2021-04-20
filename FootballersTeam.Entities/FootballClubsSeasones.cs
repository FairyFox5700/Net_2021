using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class FootballClubsSeasons
    {
        private int? _clubId;
        private int _footballClubsSeasonId;
        private int _seasonId;

        public FootballClubsSeasons()
        {

        }
        public FootballClubsSeasons(int footballClubsSeasonId, int? clubId, int seasonId, FootballClub club, Season season)
        {
            _footballClubsSeasonId = footballClubsSeasonId;
            _clubId = clubId;
            _seasonId = seasonId;
            Club = club ?? throw new ArgumentNullException(nameof(club));
            Season = season ?? throw new ArgumentNullException(nameof(season));
        }
        public FootballClub Club { get; set; }
        public Season Season { get; set; }
        public override string ToString() => GetType().Name;

        ~FootballClubsSeasons() => Console.WriteLine($"The {ToString()} destructor is executing.");

        public FootballClubsSeasons(FootballClubsSeasons footballClubSeasonToCopyFrom)
        {
            _footballClubsSeasonId = footballClubSeasonToCopyFrom._footballClubsSeasonId;
            _clubId = footballClubSeasonToCopyFrom._clubId;
            _seasonId = footballClubSeasonToCopyFrom._seasonId;
        }
    }
}
