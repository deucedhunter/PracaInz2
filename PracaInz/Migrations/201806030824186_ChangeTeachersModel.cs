namespace PracaInz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTeachersModel : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Teachers", new[] { "subjectId" });
            CreateIndex("dbo.Teachers", "SubjectId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Teachers", new[] { "SubjectId" });
            CreateIndex("dbo.Teachers", "subjectId");
        }
    }
}
