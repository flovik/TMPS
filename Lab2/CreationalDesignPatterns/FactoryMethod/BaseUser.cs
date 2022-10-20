using CreationalDesignPatterns.FactoryMethod.Interfaces;

namespace CreationalDesignPatterns.FactoryMethod;

//creator class
public abstract class BaseUser
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public abstract IUser CreateInstance();

    //factory method doesn't mean it is used to only create products.
    public string SendData(string data)
    {
        var user = CreateInstance();
        Console.WriteLine(
            $"Some core logic all users have, but depending on the " +
            $"concrete creator, user will be different with different " +
            $"behaviour.");

        return user.SendData(data);
    }
}