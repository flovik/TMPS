using StructuralDesignPatterns.Decorator.Components;

namespace StructuralDesignPatterns.Decorator.DecoratorObjects;

public class Bacon : PizzaDecorator
{
    public Bacon(Pizza pizza) : base(pizza.Description + ", bacon", pizza)
    {
    }

    public override double GetCost()
    {
        return Pizza.GetCost() + 15;
    }
}