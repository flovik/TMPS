using CreationalDesignPatterns.AbstractFactory.Interfaces;

namespace CreationalDesignPatterns.AbstractFactory.Weapons;

public class AK : IWeapon
{
    private static int Damage = 150;
    public void Shoot()
    {
        Console.WriteLine($"Shooting with AK: - {Damage} HP");
    }
}