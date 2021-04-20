using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class SponsoredClubs
    {
        private readonly int _sponsorClubId;
        private readonly int _clubId;
        private readonly int _sponsorId;
        private readonly FootballClub _club;
        private readonly Sponsor _sponsor;

        public SponsoredClubs(int sponsorClubId, int clubId, int sponsorId, FootballClub club, Sponsor sponsor)
        {
            _sponsorClubId = sponsorClubId;
            _clubId = clubId;
            _sponsorId = sponsorId;
            _club = club;
            _sponsor = sponsor;
        }

        public override string ToString() => GetType().Name;

        ~SponsoredClubs() => Console.WriteLine($"The {ToString()} destructor is executing.");

        protected SponsoredClubs(SponsoredClubs sponsoredClubsToCopyFrom)
        {
            _sponsorClubId = sponsoredClubsToCopyFrom._sponsorClubId;
            _clubId = sponsoredClubsToCopyFrom._clubId;
            _sponsorId = sponsoredClubsToCopyFrom._sponsorId;
            _club = sponsoredClubsToCopyFrom._club;
            _sponsor = sponsoredClubsToCopyFrom._sponsor;
        }

    }
}
