namespace Student.Model;

public record ImmutableStudent{
    public ImmutableStudent(int Id, DateTime StartDate, DateTime EndDate, DateTime GraduationDate, String GivenName, String Surname)
    {
        this.Id = Id;
        this.EndDate = EndDate;
        this.StartDate = StartDate;
        this.GraduationDate = GraduationDate;
        this.Surname = Surname; 
        this.GivenName = GivenName;
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

    public int Id {get; init; }
    public string GivenName{get; init;} = null!;
    public string Surname{get; init;} = null!;
    public  Status Status {get; private set;}
    public DateTime StartDate{get; init;}
    public DateTime EndDate{get; init;}
    public DateTime GraduationDate{get; init;}
}
