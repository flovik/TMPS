using StructuralDesignPatterns.Decorator.Components;

namespace StructuralDesignPatterns.Decorator.DecoratorObjects;

public class Cheese : PizzaDecorator
{
    public Cheese(Pizza pizza) : base(pizza.Description + ", cheese", pizza)
    {
    }

    public override double GetCost()
    {
        return Pizza.GetCost() + 10;
    }
}