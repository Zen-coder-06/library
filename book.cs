namespace lbms;

public class Book : library_item
{
    public string id{ get; set; }
    public string isbn { get; set; }
    public string author { get; set; }
    public Book(string title) : base(title)
    {
        Title = title;
    }

    public Book() { }

}

