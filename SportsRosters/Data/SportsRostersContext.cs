using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportsRosters.Models;

namespace SportsRosters.Data
{
    public class SportsRostersContext : DbContext
    {
        public SportsRostersContext (DbContextOptions<SportsRostersContext> options)
            : base(options)
        {
        }

        public DbSet<SportsRosters.Models.BaseballRoster> BaseballRoster { get; set; } = default!;
    }
}
