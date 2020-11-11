namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (3, 'Drama')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (4, 'Family')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (5, 'Fantasy')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (6, 'Horror')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (7, 'Romance')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (8, 'Sci-Fi')");
        }
        
        public override void Down()
        {
        }
    }
}
