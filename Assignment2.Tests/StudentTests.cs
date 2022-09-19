namespace Assignment2.Tests;

public class StudentTests
{
    [Fact]
    public void check_for_student()
    {
       //Arrange
       var student = new Student.Model.Student{
        Id = 01,
        GivenName = "John",
        Surname = "Johnson",
        StartDate = new DateTime(01/12),
        EndDate = new DateTime(02/12),
        GraduationDate = new DateTime(03/12)
          };

       //Act
       var result = student.Surname = "Not johnson anymore" ;

       //Assert

        result.Equals("not johnson anymore");

    }
    [Fact]
    public void check_for_correctgraduation_new()
    {
       //Arrange
       var student = new Student.Model.Student{
        Id = 01,
        GivenName = "John",
        Surname = "Johnson",
        StartDate = new DateTime(01/01/2022),
        EndDate = new DateTime(02/12/2022),
        GraduationDate = new DateTime(03/12/2022)
          };

       //Act
       student.setStatus();
       //Assert
        student.Status.Equals(Student.Model.Status.New);
    }
    [Fact]
    public void check_for_correctgraduation_dropout()
    {
       //Arrange
       var student = new Student.Model.Student{
        Id = 01,
        GivenName = "John",
        Surname = "Johnson",
        StartDate = new DateTime(01/01/2022),
        EndDate = new DateTime(01/01/2023),
        GraduationDate = new DateTime(01/01/2025)
          };

       //Act
       student.setStatus();
       //Assert
        student.Status.Equals(Student.Model.Status.Dropout);
    }
    [Fact]
    public void check_for_correctgraduation_graduted()
    {
       //Arrange
       var student = new Student.Model.Student{
        Id = 01,
        GivenName = "John",
        Surname = "Johnson",
        StartDate = new DateTime(1/1/2001),
        EndDate = new DateTime(1/1/2004),
        GraduationDate = new DateTime(01/01/2004)
          };

       //Act
       student.setStatus();
       //Assert
        student.Status.Equals(Student.Model.Status.Graduated);
    }
    [Fact]
    public void check_for_correctgraduation_active()
    {
       //Arrange
       var student = new Student.Model.Student{
        Id = 01,
        GivenName = "John",
        Surname = "Johnson",
        StartDate = new DateTime(1/1/2001),
        EndDate = new DateTime(1/1/2025),
        GraduationDate = new DateTime(01/01/2025)
          };

          Console.WriteLine(student.ToString());

       //Act
       student.setStatus();
       //Assert
        student.Status.Equals(Student.Model.Status.Active);
    }
    
}
