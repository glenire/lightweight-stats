using LightweightStats.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightweightStats.Data.Services
{
    public interface IClubService
    {
    }
    public class ClubService : IClubService
    {
        private readonly DevelopmentLightweightStatsContext _context;

        public ClubService(DevelopmentLightweightStatsContext context)
        {
            _context = context;
        }
    }
}
