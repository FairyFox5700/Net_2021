using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballProject.Entities
{
    public class Role
    {
        private string _roleName;

        public string RoleName
        {
            get => _roleName;
            set => _roleName = value;
        }

        public int RoleId => _roleId;

        private int _roleId;

        public Role()
        {
            _roleName = "footballer";
            _roleId = 1;
        }
        public Role(int roleId, string roleName)
        {
            _roleId = roleId;
            _roleName = roleName;
            Footballers = new List<Footballer>();
        }
        
        public override string ToString() => GetType().Name;

        ~Role() => Console.WriteLine($"The {ToString()} destructor is executing.");

        protected Role(Role roleToCopyFrom)
        { 
            _roleId = roleToCopyFrom._roleId;
            _roleName = roleToCopyFrom._roleName;
        }

        public ICollection<Footballer> Footballers { get; set; }
    }
}
