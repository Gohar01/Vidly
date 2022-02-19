namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres(Id, Name) Values(1, 'Action')");
            Sql("Insert Into Genres(Id, Name) Values(2, 'Comedy')");
            Sql("Insert Into Genres(Id, Name) Values(3, 'Drama')");    
            Sql("Insert Into Genres(Id, Name) Values(4, 'Fantasy')");
            Sql("Insert Into Genres(Id, Name) Values(5, 'Mystery')");
            Sql("Insert Into Genres(Id, Name) Values(6, 'Horror')");
            Sql("Insert Into Genres(Id, Name) Values(7, 'Thriller')");
            Sql("Insert Into Genres(Id, Name) Values(8, 'Romance')");
            Sql("Insert Into Genres(Id, Name) Values(9, 'SciFci')");

        }
        
        public override void Down()
        {
        }
    }
}
