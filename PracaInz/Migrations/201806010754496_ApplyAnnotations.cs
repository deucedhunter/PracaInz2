namespace PracaInz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Subjects", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Subjects", "Description", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subjects", "Description", c => c.String());
            AlterColumn("dbo.Subjects", "Name", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
        }
    }
}
