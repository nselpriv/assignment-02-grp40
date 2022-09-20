
namespace Student.Model;

public class Student
{
    public int Id {get; init; }
    public string GivenName{get; set;} = null!;
    public string Surname{get; set;} = null!;
    public Status Status{get; private set;}
    public DateTime StartDate{get; init;}
    public DateTime EndDate{get; set;}
    public DateTime GraduationDate{get; set;}

    public Student(int Id, DateTime StartDate, DateTime EndDate, DateTime GraduationDate){
        this.Id = Id;
        this.EndDate = EndDate;
        this.StartDate = StartDate;
        this.GraduationDate = GraduationDate;
        if(EndDate < GraduationDate)
        {
        this.Status = Status.Dropout;
        return;
        }
        if(DateTime.Now < EndDate && DateTime.Now < GraduationDate)
        {
        this.Status = Status.Active;
        if(DateTime.Now.Year == StartDate.Year)
        {
        this.Status = Status.New;
        return;
        }
        return; 
        }
        if(DateTime.Now > GraduationDate && GraduationDate == EndDate)
        {
        this.Status = Status.Graduated;
        return;
        }
        throw new ArgumentException("status has not been set incorrect values in dates");
    }

    public override String ToString()
    {
    return ("Student number " + this.Id + "\n"
     + "Name: " + this.GivenName + " " + this.Surname + "\n"
     + "Status: " + this.Status + "\n"
     + "Enrolled: " + this.StartDate + "\n"
     + "End: " + this.EndDate + "\n"
     + "Graduation: " + this.GraduationDate + "\n"
     );
    }
    }

    


