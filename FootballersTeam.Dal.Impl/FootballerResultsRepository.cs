
using System.Collections.Generic;
using System.Threading.Tasks;
using FootballProject.Dal.Abstract.Repositories;
using FootballProject.Entities.Models;


namespace FootballProject.Dal.Impl.Repositories
{
    public class FootballerResultsRepository:IFootballersResultRepository<int>
    {
        public Task<TotalResultsForMatch> GetTotalResultsForMatchById(int matchId)
        {
            throw new System.NotImplementedException();
        }

        public Task<TotalResultsForFootballer> GetTotalResultsForPlayerById(int playerId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<FootballResultsResponse>> GetFootballResultsByMatchId(int matchId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<FootballResultsResponse>> GetFootballerResultsByPlayersIdOrderedBy(int playerId, string orderBy)
        {
            throw new System.NotImplementedException();
        }
    }
}