namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b5112433-88c5-48b9-8e21-9ff0848ed77f', N'guest@vidly.com', 0, N'AJ+tIYVBrasY/6cUmaqW2uExM1diGu7KIFNxa3wuS/+k5XR+Xwif6w4PYwWbV5O+qQ==', N'dabbbda6-bbe6-4352-a7dc-0e684f880ae8', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f8ac70ff-96af-4c05-adb0-882ea75972f0', N'admin@vidly.com', 0, N'APjY0PWLxXhLaPQCfzIqoEBKcrBYS5ZI5TAKQCBwufAOc2pj14ltzAy8f8WjyTzKUg==', N'f981408d-315c-43dd-b659-21a3306c6d44', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1afc15d6-ac9a-4c33-9c43-d7a3a4423ff0', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f8ac70ff-96af-4c05-adb0-882ea75972f0', N'1afc15d6-ac9a-4c33-9c43-d7a3a4423ff0')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
