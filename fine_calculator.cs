namespace lbms;

public class Library
{
    public string Name { get; set; }
    public int Days { get; set; }
    public double Rate { get; set; }
    public string Membership { get; set; }
    public Library(string name, int days, double rate, string membership)
    {
        Name = name;
        Days = days;
        Rate = rate;
        Membership = membership;
    }

}
public class Fine : Library
{
    public Fine(string name, int days, double rate, string membership):base(name,days,rate,membership) {
        Name = name;
        Days = days;
        Rate = rate;
        Membership = membership;
        
    }
    public void calculate(string name, int days)
    {
        Console.WriteLine($"The fine amount for {name} is{days * 5}");
    }    public void calculate(string name, int days, double rate)
    {
        Console.WriteLine($"The fine amount for {name} is{days * rate}");
    }
    public void calculate(string name, int days, double rate, string membership)
    {
        switch (membership)
        {
            case "Silver":
                Console.WriteLine($"The fine amount for {name} is{days * rate - 10}");
                break;
            case "Gold":
                Console.WriteLine($"The fine amount for {name} is{days * rate - 20}");
                break;
            case "Diamond":
                Console.WriteLine($"The fine amount for {name} is{days * rate - 30}");
                break;

        }
    }
    
    
    
}