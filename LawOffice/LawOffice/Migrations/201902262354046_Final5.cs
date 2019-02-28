namespace LawOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tasks", "LawyerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "LawyerId", c => c.Int(nullable: false));
        }
    }
}
