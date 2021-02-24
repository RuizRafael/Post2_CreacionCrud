using Microsoft.EntityFrameworkCore;
using POST2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POST2.Data
{
    public class LlegadasContext : DbContext
    {
        public LlegadasContext(DbContextOptions<LlegadasContext> options) : base(options) { }
        public DbSet<Llegada> Llegadas{ get; set; }
        
    }
}
