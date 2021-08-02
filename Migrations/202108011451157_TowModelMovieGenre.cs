namespace MVC_FIRST_PROJECT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TowModelMovieGenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropPrimaryKey("dbo.Genres");
            AddColumn("dbo.Genres", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Movies", "Genre_Id", c => c.Int());
            AddPrimaryKey("dbo.Genres", "Id");
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id");
            DropColumn("dbo.Genres", "GenreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "GenreId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropPrimaryKey("dbo.Genres");
            DropColumn("dbo.Movies", "Genre_Id");
            DropColumn("dbo.Genres", "Id");
            AddPrimaryKey("dbo.Genres", "GenreId");
            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "GenreId", cascadeDelete: true);
        }
    }
}
