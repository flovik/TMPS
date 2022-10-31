using CreationalDesignPatterns.FactoryMethod.Interfaces;

namespace CreationalDesignPatterns.FactoryMethod;

//concrete class creator
public class SilverUserCreator : BaseUser
{
    public override IUser CreateInstance()
    {
        return new SilverUser();
    }
}