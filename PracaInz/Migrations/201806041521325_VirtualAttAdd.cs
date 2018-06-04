namespace PracaInz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VirtualAttAdd : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Grades", new[] { "subjectId" });
            CreateIndex("dbo.Grades", "SubjectId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Grades", new[] { "SubjectId" });
            CreateIndex("dbo.Grades", "subjectId");
        }
    }
}
