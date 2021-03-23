using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Logo
    {
        private readonly int _logoId;
        private readonly byte[] _image;
        private readonly string _imageName;
        private readonly int _clubId;
        private readonly FootballClub _club;

        public Logo(int logoId, string imageName, int clubId, FootballClub club, byte[] image = null)
        {
            _logoId = logoId;
            _image = image;
            _imageName = imageName;
            _clubId = clubId;
            _club = club ?? throw new ArgumentNullException(nameof(club));
        }

        public override string ToString() => GetType().Name;

        ~Logo() => Console.WriteLine($"The {ToString()} destructor is executing.");

        public Logo(Logo logoToCopyFrom)
        {
            _logoId = logoToCopyFrom._logoId;
            _image = logoToCopyFrom._image;
            _imageName = logoToCopyFrom._imageName;
            _clubId = logoToCopyFrom._clubId;
        }


    }
}
