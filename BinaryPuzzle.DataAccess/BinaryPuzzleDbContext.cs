using BinaryPuzzle.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace BinaryPuzzle.DataAccess
{
    public class BinaryPuzzleDbContext:DbContext
    {
        public BinaryPuzzleDbContext():base("BinaryPuzzleDb")
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Difficulty> Difficulty { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
