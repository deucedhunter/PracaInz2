namespace PracaInz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeachersData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Teachers(FirstName, LastName, Adress, Phone, SubjectId) Values('Rados³aw', 'Machoñ', 'Wojska Polskiego 63', '+48 737 357 123', 1)");
            Sql("Insert into Teachers(FirstName, LastName, Adress, Phone, SubjectId) Values('Czes³aw', 'Kowalski', 'Augustopwska 63', '+48 737 423 543', 2)");
            Sql("Insert into Teachers(FirstName, LastName, Adress, Phone, SubjectId) Values('Miros³aw', 'Alchimowicz', 'Warszawska 63', '+48 737 265 768', 3)");
            Sql("Insert into Teachers(FirstName, LastName, Adress, Phone, SubjectId) Values('W³adys³aw', 'Bernardzki', 'Tomaszkowa 63', '+48 737 234 453', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
