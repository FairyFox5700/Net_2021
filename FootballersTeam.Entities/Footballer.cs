using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Footballer:Person
    {
        private decimal _height;
        private readonly decimal _weight;
        private readonly int? _roleId;
        public Role Role { get; set; }
        public ICollection<FootballResults> FootballResults { get; set; }
        
        public Footballer(int personId, string firstName, string middleName, string nationality, 
            DateTime dataOfBirth, string placeOfBirth, decimal height, decimal weight, int? roleId,
            Role role) : 
            base(personId, firstName, middleName, nationality, dataOfBirth, placeOfBirth)
        {
            _height = height;
            _weight = weight;
            _roleId = roleId;
            Role = role ?? throw new ArgumentNullException(nameof(role));
            FootballResults =new List<FootballResults>();
        }


        public Footballer(int personId, string firstName, string middleName, 
            string nationality, DateTime dataOfBirth, string placeOfBirth) 
            : base(personId, firstName, middleName, nationality, dataOfBirth, placeOfBirth)
        {
            
        }
        
        public override string ToString() => GetType().Name;

        ~Footballer() => Console.WriteLine($"The {ToString()} destructor is executing.");

        public Footballer(Footballer footballerToCopyFrom,int personId, string firstName, string middleName, string nationality, 
            DateTime dataOfBirth, string placeOfBirth) 
            : base(personId, firstName, middleName, nationality, dataOfBirth, placeOfBirth)
        {
            _height = footballerToCopyFrom._height;
            _weight = footballerToCopyFrom._weight;
            _roleId = footballerToCopyFrom._roleId;
        }
    }
}
