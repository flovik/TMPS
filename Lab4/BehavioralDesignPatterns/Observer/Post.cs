namespace BehavioralDesignPatterns.Observer;

public class Post
{
    public DateTime Date;
    public string Header;
    public string Body;

    public Post(string header, string body)
    {
        Date = DateTime.Now;
        Header = header;
        Body = body;
    }
}