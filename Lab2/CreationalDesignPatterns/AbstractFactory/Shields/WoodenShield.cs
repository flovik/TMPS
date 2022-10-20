using CreationalDesignPatterns.AbstractFactory.Interfaces;

namespace CreationalDesignPatterns.AbstractFactory.Shields;

public class WoodenShield : IShield
{
    private static int DamageSupress = 30;
    public void Protect()
    {
        Console.WriteLine($"Protecting owner! Damage reflected {DamageSupress}");
    }
}