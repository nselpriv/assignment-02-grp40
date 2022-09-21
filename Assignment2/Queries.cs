namespace Assignment2;

public class Queries
{
    
    public static IEnumerable<string> GetAllWizardsFromAuthor(string AuthorName)
    {
         var wizzy = WizardCollection.Create();

        
        return   from wizards in wizzy
                 where wizards.Creator.Contains(AuthorName)
                 select wizards.Name;
                 


    }
}
