using CreationalDesignPatterns.FactoryMethod.Interfaces;

namespace CreationalDesignPatterns.FactoryMethod;

//concrete class that provide various implementations of IUser
public class SilverUser : IUser
{
    public string SendData(string data)
    {
        return $"Silver user received data: {data}";
    }
}