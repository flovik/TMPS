using CreationalDesignPatterns.AbstractFactory.Interfaces;

namespace CreationalDesignPatterns.AbstractFactory.Shields;

public class ModernShield : IShield
{
    private static int DamageSupress = 300;
    public void Protect()
    {
        Console.WriteLine($"Protecting owner! Damage reflected {DamageSupress}");
    }
}