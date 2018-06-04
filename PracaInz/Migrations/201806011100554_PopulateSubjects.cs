namespace PracaInz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSubjects : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SUBJECTS (Name, Description) VALUES ('Matematyka', 'Wiele dziedzin nauki i technologii w pewnym momencie zaczyna definiowaæ swoje pojêcia z dostatecznie du¿¹ precyzj¹, aby mo¿na by³o stosowaæ do nich metody matematyczne, co czêsto zapocz¹tkowuje kolejny dzia³ matematyki teoretycznej lub stosowanej.')");
            Sql("INSERT INTO SUBJECTS (Name, Description) VALUES ('Fizyka', 'Nauka przyrodnicza zajmuj¹ca siê badaniem najbardziej fundamentalnych i uniwersalnych w³aœciwoœci oraz przemian materii i energii, a tak¿e oddzia³ywañ miêdzy nimi.')");
            Sql("INSERT INTO SUBJECTS (Name, Description) VALUES ('Informatyka', 'Dyscyplina nauki zaliczana do nauk œcis³ych oraz techniki zajmuj¹ca siê przetwarzaniem informacji, w tym równie¿ technologiami przetwarzania informacji oraz technologiami wytwarzania systemów przetwarzaj¹cych informacje.')");
            Sql("INSERT INTO SUBJECTS (Name, Description) VALUES ('Chemia', 'Nauka przyrodnicza badaj¹ca naturê i w³aœciwoœci substancji, a zw³aszcza przemiany zachodz¹ce pomiêdzy nimi. Wspó³czeœnie wiadomo, ¿e przemiany substancji wynikaj¹ z praw, wed³ug których atomy ³¹cz¹ siê poprzez wi¹zania chemiczne w zwi¹zki chemiczne.')");
            Sql("INSERT INTO SUBJECTS (Name, Description) VALUES ('Historia', 'Nauka, która zajmuje siê badaniem przesz³oœci, a w znaczeniu œcis³ym badaniem dzia³añ i wytworów ludzkich, a¿ do najstarszych poœwiadczonych pismem œwiadectw, w odró¿nieniu od prehistorii, archeologii, antropologii lub historii naturalnej.')");
        }
        
        public override void Down()
        {
        }
    }
}
