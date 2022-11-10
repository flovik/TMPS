using StructuralDesignPatterns.FacadeDecoratorComposite.Components;

namespace StructuralDesignPatterns.FacadeDecoratorComposite.DecoratorObjects;

public class React : WorkerDecorator
{
    public React(Programmer programmer) : base(programmer.Name + "I know React. ", programmer)
    {
    }

    public override string SayName()
    {
        return Name;
    }

    public void SetupRedux() { }
}