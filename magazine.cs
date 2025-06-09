namespace lbms;

public class magazine : library_item
{
    public int Issuenum { get; set; }
    public magazine(string id, string title, int issuenum) : base(id, title)
    {
        Issuenum = issuenum;
    }
    public void display()
    {
        Console.WriteLine($"The title is {Issuenum}");
    }
    public magazine() {}
}