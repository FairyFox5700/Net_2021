using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public abstract class Person
    {
        private readonly int _personId;
        private readonly string _firstName;
        private readonly string _middleName;
        private readonly string _nationality;
        private readonly DateTime _dataOfBirth;
        private readonly string _placeOfBirth;

        protected Person(int personId, string firstName, string middleName, string nationality, DateTime dataOfBirth, string placeOfBirth)
        {
            _personId = personId;
            _firstName = firstName;
            _middleName = middleName;
            _nationality = nationality;
            _dataOfBirth = dataOfBirth;
            _placeOfBirth = placeOfBirth;
        }
        
        public override string ToString() => GetType().Name;

        ~Person() => Console.WriteLine($"The {ToString()} destructor is executing.");

        protected Person(Person personToCopyFrom)
        { 
            _personId = personToCopyFrom._personId;
            _firstName = personToCopyFrom._firstName;
            _middleName = personToCopyFrom._middleName;
            _nationality = personToCopyFrom._nationality;
            _dataOfBirth = personToCopyFrom._dataOfBirth;
            _placeOfBirth = personToCopyFrom._placeOfBirth;
        }

    }
}
