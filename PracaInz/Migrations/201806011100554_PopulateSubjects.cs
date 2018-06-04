namespace PracaInz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSubjects : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SUBJECTS (Name, Description) VALUES ('Matematyka', 'Wiele dziedzin nauki i technologii w pewnym momencie zaczyna definiowa� swoje poj�cia z dostatecznie du�� precyzj�, aby mo�na by�o stosowa� do nich metody matematyczne, co cz�sto zapocz�tkowuje kolejny dzia� matematyki teoretycznej lub stosowanej.')");
            Sql("INSERT INTO SUBJECTS (Name, Description) VALUES ('Fizyka', 'Nauka przyrodnicza zajmuj�ca si� badaniem najbardziej fundamentalnych i uniwersalnych w�a�ciwo�ci oraz przemian materii i energii, a tak�e oddzia�ywa� mi�dzy nimi.')");
            Sql("INSERT INTO SUBJECTS (Name, Description) VALUES ('Informatyka', 'Dyscyplina nauki zaliczana do nauk �cis�ych oraz techniki zajmuj�ca si� przetwarzaniem informacji, w tym r�wnie� technologiami przetwarzania informacji oraz technologiami wytwarzania system�w przetwarzaj�cych informacje.')");
            Sql("INSERT INTO SUBJECTS (Name, Description) VALUES ('Chemia', 'Nauka przyrodnicza badaj�ca natur� i w�a�ciwo�ci substancji, a zw�aszcza przemiany zachodz�ce pomi�dzy nimi. Wsp�cze�nie wiadomo, �e przemiany substancji wynikaj� z praw, wed�ug kt�rych atomy ��cz� si� poprzez wi�zania chemiczne w zwi�zki chemiczne.')");
            Sql("INSERT INTO SUBJECTS (Name, Description) VALUES ('Historia', 'Nauka, kt�ra zajmuje si� badaniem przesz�o�ci, a w znaczeniu �cis�ym badaniem dzia�a� i wytwor�w ludzkich, a� do najstarszych po�wiadczonych pismem �wiadectw, w odr�nieniu od prehistorii, archeologii, antropologii lub historii naturalnej.')");
        }
        
        public override void Down()
        {
        }
    }
}
