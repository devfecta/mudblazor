using JCW.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;

namespace JCW.Data
{
    public class JCWDatabaseContext : DbContext
    {
        public string ConnectionString { get; set; }

        public JCWDatabaseContext(DbContextOptions options) : base(options) { }


        public DbSet<Job> ? Jobs { get; set; }
 
    }
}
