namespace PracaInz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEducator : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Classes", "idTeacher", c => c.Int(nullable: false));
            AddColumn("dbo.Classes", "Teacher_TeacherId", c => c.Int());
            AlterColumn("dbo.Classes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Classes", "Description", c => c.String(maxLength: 255));
            CreateIndex("dbo.Classes", "Teacher_TeacherId");
            AddForeignKey("dbo.Classes", "Teacher_TeacherId", "dbo.Teachers", "TeacherId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "Teacher_TeacherId", "dbo.Teachers");
            DropIndex("dbo.Classes", new[] { "Teacher_TeacherId" });
            AlterColumn("dbo.Classes", "Description", c => c.String());
            AlterColumn("dbo.Classes", "Name", c => c.String());
            DropColumn("dbo.Classes", "Teacher_TeacherId");
            DropColumn("dbo.Classes", "idTeacher");
        }
    }
}
