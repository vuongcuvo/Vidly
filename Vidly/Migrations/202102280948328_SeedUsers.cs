namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2fed7635-1b01-4ac5-ba6c-90a56968bf45', N'guest@vidly.com', 0, N'ACwPieypMU0BG1mwUpcJ1QWhW1a6vWgoXWZ08k69nCRhkJFTyMDOC8q5JTW6Ev7isQ==', N'0a5e6c36-dbf3-4eeb-b065-d53a436ff52e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'aa4f6eec-9cf5-47ed-9632-bdd451bb3fde', N'admin@vidly.com', 0, N'ADiwyD+48IfvBXKvrdNHUTzkzfz2BoLKvYFdo4bAt6CdH/YvFERlOuH4E3owAcpY6w==', N'cb6a4d99-f34f-4393-a8d4-c22ed465a13d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2dd9d8c3-3fb4-4fae-8447-77629467f776', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aa4f6eec-9cf5-47ed-9632-bdd451bb3fde', N'2dd9d8c3-3fb4-4fae-8447-77629467f776')
");
        }
        
        public override void Down()
        {
        }
    }
}
