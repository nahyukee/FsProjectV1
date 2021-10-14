namespace FsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToGig : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Gigs", new[] { "ArtistID" });
            DropIndex("dbo.Gigs", new[] { "GenreID" });
            AlterColumn("dbo.Gigs", "Venue", c => c.String(maxLength: 255));
            CreateIndex("dbo.Gigs", "ArtistId");
            CreateIndex("dbo.Gigs", "GenreId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Gigs", new[] { "GenreId" });
            DropIndex("dbo.Gigs", new[] { "ArtistId" });
            AlterColumn("dbo.Gigs", "Venue", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Gigs", "GenreID");
            CreateIndex("dbo.Gigs", "ArtistID");
        }
    }
}
