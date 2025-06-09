namespace lbms;

public class library_item
{
    public string Id { get; set; }
    public string Title { get; set; }
    public library_item() { }
    public library_item(string title)
    {
        Title = title;
    }
    public library_item(string title, string id)
    {
        Title = title;
        Id = id;
    }
    
    
    
    public void showInfo()
    {
        Console.WriteLine($"The id is {Id}");
        Console.WriteLine($"The title is {Title}");
    }
    
}
