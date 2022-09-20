namespace Assignment2.Tests;

public class ImmutableStudentTests
{
    [Fact]
    public void check_for_equality_record()
    {
       //Arrange
       var student1 = new Student.Model.ImmutableStudent(
         1,
         new DateTime(2015,3,1),
         new DateTime(2016,3,1),
         new DateTime(2020,4,1),
         "John",
         "Johnson"
         );

        var student2 = new Student.Model.ImmutableStudent(
         1,
         new DateTime(2015,3,1),
         new DateTime(2016,3,1),
         new DateTime(2020,4,1),
         "John",
         "Johnson"
         );


       //Act
       var result = student1 == student2; 

       //Assert
       result.Should().Be(true); 
    }

    [Fact]
    public void check_tostring_method()
    {
       //Arrange
       var student1 = new Student.Model.ImmutableStudent(
         1,
         new DateTime(2015,3,1),
         new DateTime(2016,3,1),
         new DateTime(2020,4,1),
         "John",
         "Johnson"
         );


       //Act
       var result = student1.ToString(); 

       //Assert
       result.Should().Be("ImmutableStudent { Id = 1, GivenName = John, Surname = Johnson, Status = Dropout, StartDate = 01-03-2015 00:00:00, EndDate = 01-03-2016 00:00:00, GraduationDate = 01-04-2020 00:00:00 }"); 
    }

    [Fact]
    public void check_internals_student()
    {
       //Arrange
       var student1 = new Student.Model.ImmutableStudent(
         1,
         new DateTime(2015,3,1),
         new DateTime(2016,3,1),
         new DateTime(2020,4,1),
         "John",
         "Johnson"
         );

         var student2 = new Student.Model.ImmutableStudent(
         2,
         new DateTime(2015,3,1),
         new DateTime(2016,3,1),
         new DateTime(2020,4,1),
         "John",
         "Johnson"
         );


       //Act
       var result = student1.Id == student2.Id; 

       //Assert
       result.Should().Be(false);
        }
}
