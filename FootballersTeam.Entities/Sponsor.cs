using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Sponsor : Person
    {
        private readonly string _sponsorshipKind;
        private readonly decimal _sponsorshipSum;

        public Sponsor(int personId, string firstName, string middleName, string nationality,
            DateTime dataOfBirth, string placeOfBirth, string sponsorshipKind,
            decimal sponsorshipSum)
            : base(personId, firstName, middleName, nationality, dataOfBirth, placeOfBirth)
        {
            _sponsorshipKind = sponsorshipKind;
            _sponsorshipSum = sponsorshipSum;
        }

        public Sponsor()
        {

        }
        public ICollection<SponsoredClubs> SponsoresClubs { get; set; }

        public Sponsor(int personId, string firstName, string middleName,
            string nationality, DateTime dataOfBirth, string placeOfBirth)
            : base(personId, firstName, middleName, nationality, dataOfBirth, placeOfBirth)
        {
        }

        public override string ToString() => GetType().Name;

        ~Sponsor() => Console.WriteLine($"The {ToString()} destructor is executing.");

        public Sponsor(Sponsor sponsorToCopyFrom, int personId, string firstName, string middleName, string nationality,
            DateTime dataOfBirth, string placeOfBirth)
            : base(personId, firstName, middleName, nationality, dataOfBirth, placeOfBirth)
        {
            _sponsorshipKind = sponsorToCopyFrom._sponsorshipKind;
            _sponsorshipSum = sponsorToCopyFrom._sponsorshipSum;
        }
    }
}
