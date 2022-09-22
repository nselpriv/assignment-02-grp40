namespace Assignment2.Tests;
using Xunit;
using FluentAssertions;

public class QueriesTests
{
    [Fact]
    public void Test1()
    {

    }

    // 1
    [Fact]
    public void Return_Name_of_Wizards_From_Author()
    {

        //arrange
        var input = WizardCollection.Create();
        var expected = new[] { "Albus Dumbledore", "Harry Potter" };

        var result = Queries.GetAllWizardsFromAuthor("Rowling");

        //assest
        result.Should().BeEquivalentTo(expected);

    }
    [Fact]
    public void Extension_Return_Name_of_Wizards_From_Author()
    {

        //arrange
        var input = WizardCollection.Create();
        var expected = new[] { "Albus Dumbledore", "Harry Potter" };

        var result = input.Extension_GetAllWizardsFromAuthor("Rowling");

        //assest
        result.Should().BeEquivalentTo(expected);

    }
    // 2
    [Fact]
    public void GetFirstOccurenceYear_Returns1977_ForInputDarthVader()
    {

        //arrange
        var input = WizardCollection.Create();
        var expected = 1977;

        var result = Queries.GetFirstOccurenceYear("Darth");

        //assest
        result.Should().Be(expected);

    }

    [Fact]
    public void Extension_GetFirstOccurenceYear_Returns1977_ForInputDarthVader()
    {

        //arrange
        var input = WizardCollection.Create();
        var expected = 1977;

        var result = input.Extension_GetFirstOccurrenceYear("Darth");

        //assest
        result.Should().Be(expected);

    }

    [Fact]
    public void GetUniqueListOfWizards_ReturnsHarryPotterAndAlbusDumbledore_ForInputHarryPotter()
    {
        // Given
        var input = WizardCollection.Create();
        var expected = new HashSet<(string, int)> { ("Harry Potter", 1997), ("Albus Dumbledore", 1997) };

        // When
        var result = Queries.GetUniqueListOfWizards("Philosopher's Stone");

        // Then
        result.Should().BeEquivalentTo(expected);

    }

    [Fact]
    public void Extension_GetUniqueListOfWizardsForABookName_ReturnsHarryPotterAndAlbusDumbledore_ForInputPhilosophersStone()
    {
        // Given
        var input = WizardCollection.Create();
        var expected = new HashSet<(string, int)> { ("Harry Potter", 1997), ("Albus Dumbledore", 1997) };

        // When
        var result = input.Extension_GetUniqueListOfWizards("Philosopher's Stone");

        // Then
        result.Should().BeEquivalentTo(expected);

    }

    [Fact]
    public void OrderByAuthorThenByWiz_returnsListOfWizards_ForAllWizards()
    {
        var input = WizardCollection.Create();

        // Hardcoded version. Not so good if we add or remove an element.
        //var expected = new List<string> { "Mickey Mouse", "Doctor Strange", "Jareth The Goblin King", "Sauron", "Albus Dumbledore", "Harry Potter", "Darth Sidious", "Darth Vader", "Obi-Wan Kenobi", "Jafar", "Merlin" };

        // Dynamic version, only caveat is that it is basically the same code as the method it self without the usage of linq.
        var expected = input
        .OrderBy(x => x.Name)
        .OrderByDescending(x => x.Creator)
        .Select(x => x.Name)
        .Distinct()
        .ToList();

        var result = Queries.OrderByAuthorThenByWiz();
        Assert.True(result.SequenceEqual(expected));

    }
    [Fact]
    public void Extension_OrderByAuthorThenByWiz_returnsListOfWizards_ForAllWizards()
    {
        var input = WizardCollection.Create();

        // Hardcoded version. Not so good if we add or remove an element.
        //var expected = new List<string> { "Mickey Mouse", "Doctor Strange", "Jareth The Goblin King", "Sauron", "Albus Dumbledore", "Harry Potter", "Darth Sidious", "Darth Vader", "Obi-Wan Kenobi", "Jafar", "Merlin" };

        // Dynamic version, only caveat is that it is basically the same code as the method it self without the usage of linq.
        var expected = input
        .OrderBy(x => x.Name)
        .OrderByDescending(x => x.Creator)
        .Select(x => x.Name)
        .Distinct()
        .ToList();

        var result = input.Extension_OrderByAuthorThenByWiz();
        Assert.True(result.SequenceEqual(expected));

    }
}
