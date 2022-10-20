using CreationalDesignPatterns.AbstractFactory.Interfaces;
using CreationalDesignPatterns.AbstractFactory.Shields;
using CreationalDesignPatterns.AbstractFactory.Weapons;

namespace CreationalDesignPatterns.AbstractFactory;

public class ModernSoldierFactory : ISoldierFactory
{
    public IShield CreateShield()
    {
        return new ModernShield();
    }

    public IWeapon CreateWeapon()
    {
        return new AK();
    }
}