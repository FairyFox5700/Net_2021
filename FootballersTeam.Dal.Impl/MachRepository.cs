using System;
using System.Collections.Generic;

using System.Threading.Tasks;

using FootballProject.Dal.Abstract.Repositories;

using Match = FootballProject.Entities.Match;

namespace FootballProject.Dal.Impl.Repositories
{
    public class MachRepository:IMatchesRepository<int>
    {
      
        public async Task<IEnumerable<Match>> GetAllMatches()
        {
            throw new NotImplementedException();
        }
 
        public async Task<Match> GetMatchByMatchId(int matchId)
        {
            throw new NotImplementedException();
        }

        
        public async Task<IEnumerable<Match>> GetNextMatches()
        {
            throw new NotImplementedException();
        }
    }
}