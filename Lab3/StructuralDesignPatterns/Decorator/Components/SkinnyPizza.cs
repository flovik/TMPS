namespace StructuralDesignPatterns.Decorator.Components;

public class SkinnyPizza : Pizza
{
    //concrete component
    public SkinnyPizza() : base("Pizza with skinny dough")
    {
    }

    public override double GetCost()
    {
        return 40.0;
    }
}