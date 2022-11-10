using StructuralDesignPatterns.FacadeDecoratorComposite.Components;

namespace StructuralDesignPatterns.FacadeDecoratorComposite;

public abstract class WorkerDecorator : Programmer
{
    protected Programmer Programmer;
    public WorkerDecorator(string name, Programmer programmer) : base(name)
    {
        Programmer = programmer;
    }
}