using CreationalDesignPatterns.AbstractFactory.Interfaces;

namespace CreationalDesignPatterns.AbstractFactory;

public class Soldier
{
    private IWeapon _weapon;
    private IShield _shield;

    public Soldier(ISoldierFactory factory)
    {
        _weapon = factory.CreateWeapon();
        _shield = factory.CreateShield();
    }

    public void Attack()
    {
        _weapon.Shoot();
    }

    public void Defend()
    {
        _shield.Protect();
    }
}