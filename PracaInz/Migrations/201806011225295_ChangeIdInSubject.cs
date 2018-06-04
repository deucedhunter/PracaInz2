namespace PracaInz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIdInSubject : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Subjects");
            AlterColumn("dbo.Subjects", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Subjects", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Subjects");
            AlterColumn("dbo.Subjects", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Subjects", "Id");
        }
    }
}
