namespace Assignment2.Tests;

using FluentAssertions;

public class QueriesTests
{
    [Fact]
    public void Test1()
    {
        
    }

    [Fact]
    public void Return_Name_of_Wizards_From_Author(){

        //arrange
        var input = WizardCollection.Create();
       // var expected = new [] {"Albus Dumbledore", "Harry Potter"};
        var expected = new [] {"Sauron"};

        //act
        var result = Queries.GetAllWizardsFromAuthor("Tolkien");

        //assest
        result.Should().BeEquivalentTo(expected);

    }
}
