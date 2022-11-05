using StructuralDesignPatterns.Composite.Interfaces;

namespace StructuralDesignPatterns.Composite;

public class ManagerComposite : IWorker
{
    public IList<IWorker> workers { get; } = new List<IWorker>();
    public string Name;
    public ManagerComposite(string name)
    {
        Name = name;
    }

    public void AddWorker(IWorker worker)
    {
        workers.Add(worker);
    }

    public void RemoveWorker(IWorker worker)
    {
        workers.Remove(worker);
    }

    public void SayName()
    {
        Console.WriteLine($"Hi, I am {Name}, a manager");
    }
}