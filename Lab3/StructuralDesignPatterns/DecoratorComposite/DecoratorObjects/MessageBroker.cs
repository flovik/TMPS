using StructuralDesignPatterns.FacadeDecoratorComposite.Components;

namespace StructuralDesignPatterns.FacadeDecoratorComposite.DecoratorObjects;

public class MessageBroker : WorkerDecorator
{
    public MessageBroker(Programmer programmer) : base(programmer.Name + "I know RabbitMQ. ", programmer)
    {
    }

    public override string SayName()
    {
        return Name;
    }

    public void ProcessRequest() { }
}