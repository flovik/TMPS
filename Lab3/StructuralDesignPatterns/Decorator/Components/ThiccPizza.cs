namespace StructuralDesignPatterns.Decorator.Components;

public class ThiccPizza : Pizza
{
    public ThiccPizza() : base("Pizza with thicc dough")
    {
    }

    public override double GetCost()
    {
        return 50.0;
    }
}