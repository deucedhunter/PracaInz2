namespace PracaInz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeachersAndGradesTablesToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Byte(nullable: false),
                        Description = c.String(maxLength: 255),
                        StudentId = c.Int(nullable: false),
                        subjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.subjectId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.subjectId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Adress = c.String(),
                        Phone = c.String(),
                        subjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Subjects", t => t.subjectId, cascadeDelete: true)
                .Index(t => t.subjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "subjectId", "dbo.Subjects");
            DropForeignKey("dbo.Grades", "subjectId", "dbo.Subjects");
            DropForeignKey("dbo.Grades", "StudentId", "dbo.Students");
            DropIndex("dbo.Teachers", new[] { "subjectId" });
            DropIndex("dbo.Grades", new[] { "subjectId" });
            DropIndex("dbo.Grades", new[] { "StudentId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Grades");
        }
    }
}
