using CreationalDesignPatterns.FactoryMethod.Interfaces;

namespace CreationalDesignPatterns.FactoryMethod;

//concrete class creator
public class GoldUserCreator : BaseUser
{
    public override IUser CreateInstance()
    {
        return new GoldUser();
    }
}