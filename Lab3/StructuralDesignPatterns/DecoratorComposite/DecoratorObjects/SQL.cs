using StructuralDesignPatterns.FacadeDecoratorComposite.Components;

namespace StructuralDesignPatterns.FacadeDecoratorComposite.DecoratorObjects;

public class SQL : WorkerDecorator
{
    public SQL(Programmer programmer) : base(programmer.Name + "I know SQL databases. ", programmer)
    {
    }

    public override string SayName()
    {
        return Name;
    }

    public void WorkWithDatabase() { }
}