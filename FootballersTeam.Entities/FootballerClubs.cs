using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class FootballerClubs
    {
        private readonly int _footballerClubId;
        private readonly int _personId;
        private readonly string _firstName;
        private readonly string _middleName;
        private readonly string _nationality;
        private readonly DateTime _dataOfBirth;
        private readonly string _placeOfBirth;
        private readonly string _footballerClubName;
        private readonly int _clubId;
        private readonly int _playerId;

        public FootballerClubs(int footballerClubId, int personId, string firstName,
            string middleName, string nationality,
            DateTime dataOfBirth, string placeOfBirth, 
            string footballerClubName, int clubId, 
            int playerId, FootballClub club, Footballer player)
        {
            _footballerClubId = footballerClubId;
            _personId = personId;
            _firstName = firstName;
            _middleName = middleName;
            _nationality = nationality;
            _dataOfBirth = dataOfBirth;
            _placeOfBirth = placeOfBirth;
            _footballerClubName = footballerClubName;
            _clubId = clubId;
            _playerId = playerId;
            Club = club ?? throw new ArgumentNullException(nameof(club));
            Player = player ?? throw new ArgumentNullException(nameof(player));
        }

        public FootballClub Club { get; set; }
        public Footballer Player { get; set; }
        
        public override string ToString() => GetType().Name;

        ~FootballerClubs() => Console.WriteLine($"The {ToString()} destructor is executing.");

        public FootballerClubs(FootballerClubs footballClubToCopyFrom)
        {
            _footballerClubId = footballClubToCopyFrom._footballerClubId;
            _personId = footballClubToCopyFrom._personId;
            _firstName = footballClubToCopyFrom._firstName;
            _middleName = footballClubToCopyFrom._middleName;
            _nationality = footballClubToCopyFrom._nationality;
            _dataOfBirth = footballClubToCopyFrom._dataOfBirth;
            _placeOfBirth = footballClubToCopyFrom._placeOfBirth;
            _footballerClubName = footballClubToCopyFrom._footballerClubName;
            _clubId = footballClubToCopyFrom._clubId;
            _playerId = footballClubToCopyFrom._playerId;
        }
    }
}
