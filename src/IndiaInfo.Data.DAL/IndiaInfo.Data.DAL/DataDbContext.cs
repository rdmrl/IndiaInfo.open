using System;
using Microsoft.EntityFrameworkCore;

namespace IndiaInfo.Data.DAL
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options) { }
    }
}
