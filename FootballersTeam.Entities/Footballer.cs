using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using System.IO.Pipes;

namespace FootballProject.Entities
{
    public class Footballer:Person
    {
        private static int _counter;
        private decimal _height;
        private  decimal _weight;
        private readonly int? _roleId;

        public decimal Height
        {
            get => _height;
            set => _height = value;
        }

        public decimal Weight
        {
            get => _weight;
            set => _weight = value;
        }

        public int? RoleId => _roleId;

        public Role Role { get; set; }
        public ICollection<FootballResults> FootballResults { get; set; }

        public Footballer()
        {
            
        }
        public Footballer( string firstName, string middleName, string nationality, 
            DateTime dataOfBirth, string placeOfBirth, decimal height, decimal weight, Role role) : 
            base(_counter++, firstName, middleName, nationality, dataOfBirth, placeOfBirth)
        {
            _height = height;
            _weight = weight;
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

        public Footballer(Footballer footballerToCopyFrom): base(footballerToCopyFrom)
        {
            _height = footballerToCopyFrom._height;
            _weight = footballerToCopyFrom._weight;
            _roleId = footballerToCopyFrom._roleId;
        }
        
    }
}
