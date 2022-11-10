using StructuralDesignPatterns.FacadeDecoratorComposite.Interfaces;

namespace StructuralDesignPatterns.FacadeDecoratorComposite;

public class ProgrammersManagerComposite : IWorker
{
    public IList<IWorker> workers { get; } = new List<IWorker>();
    public ProgrammersManagerComposite(string name)
    {
        Name = name;
    }

    public string Name { get; set; }    

    public string SayName()
    {
        return Name;
    }

    public void AddWorker(IWorker worker)
    {
        workers.Add(worker);
    }

    public void RemoveWorker(IWorker worker)
    {
        workers.Remove(worker);
    }
}