 namespace FsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) Values (1, 'Pop')");
            Sql("INSERT INTO Genres (Id, Name) Values (2, 'HipHop')");
            Sql("INSERT INTO Genres (Id, Name) Values (3, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) Values (4, 'Country')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
