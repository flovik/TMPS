using CreationalDesignPatterns.FactoryMethod.Interfaces;

namespace CreationalDesignPatterns.FactoryMethod;

//concrete class that provide various implementations of IUser
public class GoldUser : IUser
{
    public string SendData(string data)
    {
        return $"Gold user received data: {data}";
    }
}