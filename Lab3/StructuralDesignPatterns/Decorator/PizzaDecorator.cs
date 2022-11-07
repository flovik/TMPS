using StructuralDesignPatterns.Decorator.Components;

namespace StructuralDesignPatterns.Decorator;

public abstract class PizzaDecorator : Pizza
{
    protected Pizza Pizza;

    protected PizzaDecorator(string description, Pizza pizza) : base(description)
    {
        Pizza = pizza;
    }
}