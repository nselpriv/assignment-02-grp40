namespace Assignment2.Tests;

public class StudentTests
{
    [Fact]
    public void check_for_student()
    {
       //Arrange
       var student = new Student.Model.Student(
         1,
         new DateTime(2015,3,1),
         new DateTime(2016,3,1),
         new DateTime(2020,4,1)
         );
         student.Surname = "johnson";

       //Act
       var result = student.Surname;

       //Assert
        result.Should().Be("johnson");
    }


     [Fact]
    public void check_for_dropout()
    {
       //Arrange
       var student = new Student.Model.Student(
         1,
         new DateTime(2015,3,1),
         new DateTime(2016,3,1),
         new DateTime(2020,4,1)
         );

       //Act
       var result = student.Status;

       //Assert
        result.Should().Be(Student.Model.Status.Dropout);
    }

     [Fact]
    public void check_for_active()
    {
       //Arrange
       var student = new Student.Model.Student(
         1,
         new DateTime(2015,3,1),
         new DateTime(2120,4,1),
         new DateTime(2120,4,1)
         );

       //Act
       var result = student.Status;

       //Assert
        result.Should().Be(Student.Model.Status.Active);
    }

     [Fact]
    public void check_for_new()
    {
       //Arrange
       var student = new Student.Model.Student(
         1,
         new DateTime(2022,3,1),
         new DateTime(2120,4,1),
         new DateTime(2120,4,1)
         );

       //Act
       var result = student.Status;

       //Assert
        result.Should().Be(Student.Model.Status.New);
    }

     [Fact]
    public void check_for_Graduated()
    {
       //Arrange
       var student = new Student.Model.Student(
         1,
         new DateTime(2001,3,1),
         new DateTime(2003,4,1),
         new DateTime(2003,4,1)
         );

       //Act
       var result = student.Status;

       //Assert
        result.Should().Be(Student.Model.Status.Graduated);
    }
    
}