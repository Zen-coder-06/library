namespace lbms;

public class book
{
    //public string title { get; set; }
    //public string isbn { get; set; }
    //public string author { get; set; }
    public string title;
    public string isbn;
    public string author;
    public void display()
    {
        Console.WriteLine($"The title is {title}");
        Console.WriteLine($"The isbn is {isbn}");
        Console.WriteLine($"The author name is {author}");
    }
    public book(string Title, string Isbn, string Author)
    {
        title = Title;
        isbn = Isbn;
        author = Author;
    }
    public void search()
    {

    }

}
