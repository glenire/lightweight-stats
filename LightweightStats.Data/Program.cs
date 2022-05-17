using LightweightStats.Data.Models;
using LightweightStats.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightweightStats.Data
{
    public class Program
    {
        private readonly ILogger<Program> _logger;

        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
        }

        public Program(ILogger<Program> logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.LogInformation("Program is running.");
            _logger.LogInformation("Program is completed.");
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddDbContext<DevelopmentLightweightStatsContext>(options =>
                        options.UseSqlServer("name=ConnectionStrings:DBConnection"));
                    services.AddScoped<IClubService, ClubService>();
                });
        }
    }
}
