namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'28b80846-2f94-476b-a643-dc00d72165c7', N'jackyisme123@gmail.com', 0, N'AMT/qb8a1v4/k+i3wVyC3qq+gXjEhmExfnNnwh3SlB880xArxF6Xvt+Etn5+J3Y9sQ==', N'34f135dc-5d6c-4db4-b5e2-dd50422a40d7', NULL, 0, 0, NULL, 1, 0, N'jackyisme123@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c489e1d6-24c6-4a2d-9974-c214c4b616d9', N'admin@admin.admin', 0, N'AFstckj3MZrNW2x/TRhgJWa5ZJjVkmtcx47XjsQ37MqsqDjwx6MhSyshogcHitSohQ==', N'c46df28d-363d-4db9-8b3e-770569203005', NULL, 0, 0, NULL, 1, 0, N'admin@admin.admin')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'82ec3b7e-2f81-4958-94e5-3fc921da72f8', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c489e1d6-24c6-4a2d-9974-c214c4b616d9', N'82ec3b7e-2f81-4958-94e5-3fc921da72f8')

");
        }
        
        public override void Down()
        {
        }
    }
}
