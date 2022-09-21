namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Theory]
    [InlineData("http://www.erdetfredag.dk/", false)]
    [InlineData("https://www.erdetfredag.dk/", true)]
    public void Test_uri_is_safe(string word, bool expected)
    {
         //Arrange
         Uri uri = new Uri(word);

        //Act
        var result = Extensions.IsSecure(uri);

       //Assert
        result.Should().Be(expected);
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


