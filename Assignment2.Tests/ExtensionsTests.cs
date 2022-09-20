namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Test_uri_is_safe()
    {
         //Arrange
         Uri uri = new Uri("https://www.erdetfredag.dk/");

        //Act
        var result = Extensions.IsSecure(uri);

       //Assert
        result.Should().Be(true);
    }

    [Fact]
    public void Test_uri_is_not_safe()
    {
         //Arrange
         Uri uri = new Uri("http://www.erdetfredag.dk/");

        //Act
        var result = Extensions.IsSecure(uri);

       //Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Test_word_count_simple()
    {
         //Arrange
         String str = ("måske testen bliver rigtig denne gang");

        //Act
        var result = Extensions.WordCount(str);
       //Assert
        result.Should().Be(6);
    }

    public void Test_word_count_hard()
    {
         //Arrange
         String str = ("måske testzzen!!!234234234bliveØær ##@ rigtig9deẞe gang");

        //Act
        var result = Extensions.WordCount(str);
       //Assert
        result.Should().Be(6);
    }
}


