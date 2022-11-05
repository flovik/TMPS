namespace StructuralDesignPatterns.Proxy.Models;

public class User
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public byte[] Photo { get; set; }
}