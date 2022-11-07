using StructuralDesignPatterns.Decorator.Components;

namespace StructuralDesignPatterns.Decorator.DecoratorObjects;

public class Onions : PizzaDecorator
{
    public Onions(Pizza pizza) : base(pizza.Description + ", onions", pizza)
    {
    }

    public override double GetCost()
    {
        return Pizza.GetCost() + 6;
    }
}