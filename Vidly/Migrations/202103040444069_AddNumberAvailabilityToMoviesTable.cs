namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailabilityToMoviesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailability", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailability");
        }
    }
}
