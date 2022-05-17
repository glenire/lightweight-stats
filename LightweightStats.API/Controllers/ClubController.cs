using LightweightStats.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LightweightStats.API.Controllers
{
    [Route("v1/[controller]")]
    public class ClubController : Controller
    {
        private readonly DatabaseContext _dbContext;

        public ClubController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<List<Club>> GetClubs()
        {
            var results = await _dbContext.Clubs.ToListAsync();
            return results;
        }
    }
}
