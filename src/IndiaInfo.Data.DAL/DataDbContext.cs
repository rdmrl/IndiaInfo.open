using System;
using IndiaInfo.Data.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace IndiaInfo.Data.DAL
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options) { }

        public DbSet<State> States { get; set; }
    }
}
