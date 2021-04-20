using System.Collections.Generic;

using System.Threading.Tasks;
using FootballProject.Dal.Abstract.Repositories;
using FootballProject.Entities;
using FootballProject.Entities.Models;

namespace FootballProject.Dal.Impl.Repositories
{
    public class FootballerRepository : IFootballerRepository<int>
    {
        public Task<IEnumerable<Footballer>> GetFootballers()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Footballer>> GetFootballersWithRoles()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Footballer>> GetFootballersByRoleName(string role)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Footballer>> GetFootballersByNameSurnameNationality(string name = "", string surname = "", string nationality = "")
        {
            throw new System.NotImplementedException();
        }

        public Task<Footballer> GetFootballerById(int footballerId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Footballer>> GetFootballersOrdered(string search, bool @ascending = true)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> AddFootballer(FootballerDto footballerToAdd)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> UpdateFootballer(int playerId, FootballerDto footballerDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> DeleteFootballer(int footballerId)
        {
            throw new System.NotImplementedException();
        }
    }
}