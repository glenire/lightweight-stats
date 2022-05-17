using LightweightStats.API.Models;
using LightweightStats.Shared.Interfaces;

namespace LightweightStats.API.Services
{
    public class ClubService : IClubService
    {
        private readonly ILogger _logger;
        private readonly DatabaseContext _dbContext;

        public ClubService(ILogger logger, DatabaseContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
    }
}
