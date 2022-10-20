namespace CreationalDesignPatterns.AbstractFactory.Interfaces;

public interface ISoldierFactory
{
    IShield CreateShield();
    IWeapon CreateWeapon();
}