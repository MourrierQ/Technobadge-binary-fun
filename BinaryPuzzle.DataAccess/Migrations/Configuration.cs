namespace BinaryPuzzle.DataAccess.Migrations
{
    using BinaryPuzzle.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BinaryPuzzle.DataAccess.BinaryPuzzleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BinaryPuzzle.DataAccess.BinaryPuzzleDbContext context)
        {
            context.Players.AddOrUpdate(
                u => u.Name,
                new  Player { Name = "Thomas"},
                new Player { Name = "Andres"},
                new Player {Name = "Julia"},
                new Player { Name = "Chrisse",}
                );

            context.Difficulty.AddOrUpdate(
                d => d.Name,
                new Difficulty { Name = "Easy" },
                new Difficulty { Name = "Normal" },
                new Difficulty { Name = "Expert" });
        }
    }
}
