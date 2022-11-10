using StructuralDesignPatterns.FacadeDecoratorComposite.Interfaces;

namespace StructuralDesignPatterns.FacadeDecoratorComposite.Components;


public abstract class Programmer : IWorker
{
    public string Name;
    protected Programmer(string name)
    {
        Name = name;
    }
    public abstract string SayName();
}