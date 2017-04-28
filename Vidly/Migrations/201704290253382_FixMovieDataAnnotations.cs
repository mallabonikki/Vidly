namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMovieDataAnnotations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreTypeId" });
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AlterColumn("dbo.Movies", "AddedDate", c => c.DateTime());
            AlterColumn("dbo.Movies", "NumberOfStock", c => c.Short());
            AlterColumn("dbo.Movies", "GenreTypeId", c => c.Short());
            CreateIndex("dbo.Movies", "GenreTypeId");
            AddForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreTypeId" });
            AlterColumn("dbo.Movies", "GenreTypeId", c => c.Short(nullable: false));
            AlterColumn("dbo.Movies", "NumberOfStock", c => c.Short(nullable: false));
            AlterColumn("dbo.Movies", "AddedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Title", c => c.String());
            CreateIndex("dbo.Movies", "GenreTypeId");
            AddForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes", "Id", cascadeDelete: true);
        }
    }
}
