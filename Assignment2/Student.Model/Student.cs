
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

    public Status setStatus()
    {
    //students graduationtime is the same as their endtime ie. they are graduated
    if(this.GraduationDate.CompareTo(this.EndDate) == 0 && this.GraduationDate.Year.CompareTo(DateTime.Now.Year) < 0)
    {
        this.Status=Status.Graduated;
        return Status.Graduated;
    }
        //students graduationtime is later than their endtime ie. they are dropouts
    if(this.GraduationDate.CompareTo(this.EndDate) == -1)
    {
        this.Status=Status.Dropout;
        return Status.Dropout;
    }
    //students starting year is this year ie. they are new 
    if(this.StartDate.Year.CompareTo(DateTime.Now.Year) == 0)
    {
        this.Status=Status.New;
        return Status.New;
    }
    //students who have not yet graduated but are still active
    if(this.GraduationDate.Year.CompareTo(DateTime.Now.Year) == -1)
    {
        this.Status=Status.Active;
        return Status.Active;
    }
    throw new ArgumentException("status may have not been initialized proper in student");
    }
    
    public override String ToString()
    {
    return ("Student number " + Id + "\n"
     + "Name: " + GivenName + " " + Surname + "\n"
     + "Status: " + Status + "\n"
     + "Enrolled: " + StartDate + "\n"
     + "End: " + EndDate + "\n"
     + "Graduation: " + GraduationDate + "\n"
     );
    }
    }

    


