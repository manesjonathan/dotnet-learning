namespace helloWorld;

public class Client
{
    private int id;
    private string name;
    private DateTime joinedDate;

    
    public Client(int id, string name, DateTime joinedDate)
    {
        this.id = id;
        this.name = name;
        this.joinedDate = joinedDate;
    }
    
    
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public DateTime JoinedDate
    {
        get { return joinedDate; }
        set { joinedDate = value; }
    }
}