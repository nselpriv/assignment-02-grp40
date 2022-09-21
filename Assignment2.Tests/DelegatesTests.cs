namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void should_reverse_strings()
    {
    var testString = "hello";

    Assignment2.Delegates.charReverser c = word => Assignment2.Delegates.reverse(word);

    var result = c(testString);

    result.Should().Be("olleh");


    }
    [Fact]
    public void should_give_decimal_products()
    {
    decimal number = 3;
    decimal expected = 9;

    Assignment2.Delegates.decimalProduct deci = d => d * d;

    var result = deci(number);

    result.Should().Be(expected);
    }

    [Theory]
    [InlineData(34, "23", false)]
    [InlineData(23, "0023", true)]
    public void check_string_and_number(int intnumber, string stringnumber, bool expected)
    {
        Assignment2.Delegates.numberChecker nc = (n1,n2) => Assignment2.Delegates.checkmethod(n1,n2);
        //Act
        var result = nc(intnumber,stringnumber);

       //Assert
        result.Should().Be(expected);
    }

}
