namespace BinaryPuzzle.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDifficulty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Difficulty",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        PlayerId = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Player", t => t.PlayerId, cascadeDelete: true)
                .Index(t => t.PlayerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Difficulty", "PlayerId", "dbo.Player");
            DropIndex("dbo.Difficulty", new[] { "PlayerId" });
            DropTable("dbo.Difficulty");
        }
    }
}
