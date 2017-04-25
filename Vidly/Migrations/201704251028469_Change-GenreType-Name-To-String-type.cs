namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenreTypeNameToStringtype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GenreTypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GenreTypes", "Name", c => c.Byte(nullable: false));
        }
    }
}
