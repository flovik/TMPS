using CreationalDesignPatterns.AbstractFactory.Interfaces;

namespace CreationalDesignPatterns.AbstractFactory.Weapons;

public class Bow : IWeapon
{
    private static int Damage = 50;
    public void Shoot()
    {
        Console.WriteLine($"Shooting with bow: -{Damage} hp");
    }
}