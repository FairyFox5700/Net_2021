using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Address
    {
        private readonly int _addressId;
        private readonly string _streetAddress;
        private readonly string _postalCode;
        private readonly string _city;
        private readonly string _country;
        private readonly string _stateProvince;
        public  Stadium Stadium { get; set; }
        
        public Address(int addressId, string streetAddress, string postalCode, string city, string country, string stateProvince)
        {
            _addressId = addressId;
            _streetAddress = streetAddress;
            _postalCode = postalCode;
            _city = city;
            _country = country;
            _stateProvince = stateProvince;
        }
        
        public override string ToString() => GetType().Name;

        ~Address() => Console.WriteLine($"The {ToString()} destructor is executing.");
        
        public Address(Address addressToCopyFrom)
        {
            _addressId = addressToCopyFrom._addressId;
            _streetAddress = addressToCopyFrom._streetAddress;
            _postalCode = addressToCopyFrom._postalCode;
            _city = addressToCopyFrom._city;
            _country =addressToCopyFrom._country;
            _stateProvince = addressToCopyFrom._stateProvince;
        }

    }
}
