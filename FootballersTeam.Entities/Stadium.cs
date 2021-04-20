using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Stadium
    {
        private readonly int _stadiumId;
        private readonly string _stadiumName;
        private readonly int _capacity;
        private readonly string _yearOfBuild;
        private readonly string _surface;
        private readonly int _addressId;
        private readonly Address _address;

        public Stadium()
        {

        }
        public Stadium(int stadiumId, string stadiumName, int capacity,
            string yearOfBuild, string surface, int addressId,
            Address address)
        {
            _stadiumId = stadiumId;
            _stadiumName = stadiumName;
            _capacity = capacity;
            _yearOfBuild = yearOfBuild;
            _surface = surface;
            _addressId = addressId;
            _address = address ?? throw new ArgumentNullException(nameof(address));
            Matches = new List<Match>();
        }
        public override string ToString() => GetType().Name;

        ~Stadium() => Console.WriteLine($"The {ToString()} destructor is executing.");

        protected Stadium(Stadium stadiumToCopyFrom)
        {
            _stadiumId = stadiumToCopyFrom._stadiumId;
            _stadiumName = stadiumToCopyFrom._stadiumName;
            _capacity = stadiumToCopyFrom._capacity;
            _yearOfBuild = stadiumToCopyFrom._yearOfBuild;
            _surface = stadiumToCopyFrom._surface;
            _addressId = stadiumToCopyFrom._addressId;
        }
        public ICollection<Match> Matches { get; set; }


    }
}
