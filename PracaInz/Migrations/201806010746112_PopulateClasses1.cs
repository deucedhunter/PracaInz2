namespace PracaInz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateClasses1 : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Classes (Name, Description) Values ('1A', 'Pierwsza A')");
            Sql("Insert into Classes (Name, Description) Values ('1B', 'Pierwsza B')");
            Sql("Insert into Classes (Name, Description) Values ('1C', 'Pierwsza C')");
            Sql("Insert into Classes (Name, Description) Values ('2A', 'Druga A')");
            Sql("Insert into Classes (Name, Description) Values ('2B', 'Druga B')");
            Sql("Insert into Classes (Name, Description) Values ('2C', 'Druga C')");
            Sql("Insert into Classes (Name, Description) Values ('3A', 'Trzecia A')");
            Sql("Insert into Classes (Name, Description) Values ('3B', 'Trzecia B')");
            Sql("Insert into Classes (Name, Description) Values ('3C', 'Trzecia C')");
        }
        
        public override void Down()
        {
        }
    }
}
