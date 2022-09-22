namespace Assignment2;

public class Queries
{

    public static IEnumerable<string> GetAllWizardsFromAuthor(string AuthorName)
    {
        var wizzy = WizardCollection.Create();


        return (from wizards in wizzy
                where wizards.Creator.Contains(AuthorName)
                select wizards.Name).Distinct();



    }

    public static int GetFirstOccurenceYear(string StartsWith)
    {
        var wizzy = WizardCollection.Create();
        return (int)(from w in wizzy
                     where w.Name.StartsWith(StartsWith)
                     orderby w.Year
                     select w.Year).First()!;
    }

    public static IEnumerable<(string, int?)> GetUniqueListOfWizards(string bookName)
    {
        var wizzy = WizardCollection.Create();
        return (from w in wizzy
                where w.Medium.Equals(bookName)
                select (w.Name, w.Year))
                .Distinct();
    }

    public static IEnumerable<string> OrderByAuthorThenByWiz()
    {
        var wizzy = WizardCollection.Create();

        return (from w in wizzy
                orderby w.Creator descending, w.Name
                select w.Name).Distinct();

    }
}

// Extension Class
public static class wizardHelper
{
    public static IEnumerable<string> Extension_GetAllWizardsFromAuthor(this WizardCollection w, string AuthorName)
    {
        var wizzy = WizardCollection.Create();
        var hashS = new HashSet<string>();
        foreach (var wiz in wizzy)
        {
            if (wiz.Creator.Contains(AuthorName))
                hashS.Add(wiz.Name);

        }
        return hashS;
    }

    public static int? Extension_GetFirstOccurrenceYear(this WizardCollection w, string consistOf)
    {
        var wizzy = WizardCollection.Create();
        var listOfOccurrences = new List<int?>();

        foreach (var wiz in wizzy)
        {
            if (wiz.Name.Contains(consistOf) && !listOfOccurrences.Contains(wiz.Year))
            {
                listOfOccurrences.Add(wiz.Year);
            }
        }
        listOfOccurrences.Sort();
        return listOfOccurrences.First();

    }

    public static IEnumerable<(string, int?)> Extension_GetUniqueListOfWizards(this WizardCollection w, string bookName)
    {
        var wizzy = WizardCollection.Create();
        var hashS = new HashSet<(string, int?)>();
        foreach (var wiz in wizzy)
        {
            if (wiz.Medium.Equals(bookName))
            {
                hashS.Add((wiz.Name, wiz.Year));
            }
        }
        return hashS;


    }

    public static IEnumerable<string> Extension_OrderByAuthorThenByWiz(this WizardCollection w)
    {
        var wizzy = WizardCollection.Create();
        var finalWizzy = wizzy.OrderByDescending(s => s.Creator).ThenBy(s => s.Name).Distinct();
        foreach (var wiz in finalWizzy)
        {
            yield return wiz.Name;
        }
    }
}