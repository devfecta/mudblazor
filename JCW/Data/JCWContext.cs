using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JCW.Models;

namespace JCW.Data
{
    public class JCWContext : DbContext
    {
        public JCWContext (DbContextOptions<JCWContext> options)
            : base(options)
        {
        }

        public DbSet<Job> Job { get; set; } = default!;
    }
}
