namespace StructuralDesignPatterns.Decorator.Components;

public abstract class Pizza
{
    public string Description { get; protected set; }

    protected Pizza(string description)
    {
        Description = description;
    }
    public abstract double GetCost();
}