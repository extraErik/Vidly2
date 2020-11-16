namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'12b91660-453a-40f1-b808-8d64cd3a1082', N'guest@vidly.com', 0, N'ACWI3WRaZGK0u6oxrN6xSv07AxQF/lFk5aYq4/13a6NDFPPvaf1kXiJHk/fc1lb4ug==', N'e57832e7-97bb-4af6-a4de-bd5d54b7aed7', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'87b95cba-dc55-4cd6-a493-91da0826eb53', N'admin@vidly.com', 0, N'AOqx1gZ2kWArDiMDkG+aIPifEVk2TgTCOxAg4nBHPEbxBfEsgljqr6aKdDsR4tilyA==', N'363552f1-caef-4715-9274-223b48997ff3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7d6da607-cf2f-4af6-a1f9-bcca4fc8c85a', N'CanManageMovies')
 
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'87b95cba-dc55-4cd6-a493-91da0826eb53', N'7d6da607-cf2f-4af6-a1f9-bcca4fc8c85a')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
