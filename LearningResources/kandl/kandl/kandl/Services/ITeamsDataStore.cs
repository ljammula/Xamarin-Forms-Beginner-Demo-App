using kandl.Models;
using System.Threading.Tasks;

namespace kandl.Services
{
    public interface ITeamsDataStore : IDataStore<Team>
    {
        Task<Team> GetNewestTeamAsync();
    }
}
