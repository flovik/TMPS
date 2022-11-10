using StructuralDesignPatterns.FacadeDecoratorComposite.Components;

namespace StructuralDesignPatterns.FacadeDecoratorComposite.DecoratorObjects;

public class Angular : WorkerDecorator
{
    public Angular(Programmer programmer) : base(programmer.Name + "I know Angular. ", programmer)
    {
    }

    public override string SayName()
    {
        return Name;
    }

    public void MakePage() { }
}