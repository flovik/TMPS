using CreationalDesignPatterns.AbstractFactory.Interfaces;
using CreationalDesignPatterns.AbstractFactory.Shields;
using CreationalDesignPatterns.AbstractFactory.Weapons;

namespace CreationalDesignPatterns.AbstractFactory;

public class ArcherFactory : ISoldierFactory
{
    public IShield CreateShield()
    {
        return new WoodenShield();
    }

    public IWeapon CreateWeapon()
    {
        return new Bow();
    }
}