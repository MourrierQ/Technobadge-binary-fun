namespace BinaryPuzzle.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDifficultyFixed : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Difficulty", "PlayerId", "dbo.Player");
            DropIndex("dbo.Difficulty", new[] { "PlayerId" });
            AlterColumn("dbo.Difficulty", "PlayerId", c => c.Int());
            CreateIndex("dbo.Difficulty", "PlayerId");
            AddForeignKey("dbo.Difficulty", "PlayerId", "dbo.Player", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Difficulty", "PlayerId", "dbo.Player");
            DropIndex("dbo.Difficulty", new[] { "PlayerId" });
            AlterColumn("dbo.Difficulty", "PlayerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Difficulty", "PlayerId");
            AddForeignKey("dbo.Difficulty", "PlayerId", "dbo.Player", "Id", cascadeDelete: true);
        }
    }
}
