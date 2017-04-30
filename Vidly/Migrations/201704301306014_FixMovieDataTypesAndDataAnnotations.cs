namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMovieDataTypesAndDataAnnotations : DbMigration
    {
        public override void Up()
        {
            //Sql("ALTER TABLE Movies DROP CONSTRAINT DF__Movies__NumberOf__4BAC3F29");
            //Sql("ALTER TABLE Movies DROP CONSTRAINT DF__Movies__GenreTyp__4CA06362");

            DropForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreTypeId" });
            DropPrimaryKey("dbo.GenreTypes");
            AlterColumn("dbo.GenreTypes", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "AddedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "NumberOfStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "GenreTypeId", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.GenreTypes", "Id");
            CreateIndex("dbo.Movies", "GenreTypeId");
            AddForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreTypeId" });
            DropPrimaryKey("dbo.GenreTypes");
            AlterColumn("dbo.Movies", "GenreTypeId", c => c.Short());
            AlterColumn("dbo.Movies", "NumberOfStock", c => c.Short());
            AlterColumn("dbo.Movies", "AddedDate", c => c.DateTime());
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.GenreTypes", "Id", c => c.Short(nullable: false, identity: true));
            AddPrimaryKey("dbo.GenreTypes", "Id");
            CreateIndex("dbo.Movies", "GenreTypeId");
            AddForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes", "Id");
        }
    }
}
