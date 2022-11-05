using StructuralDesignPatterns.Composite.Interfaces;

namespace StructuralDesignPatterns.Composite;

public class ProgrammerLeaf : IWorker
{
    public string Name;
    public ProgrammerLeaf(string name)
    {
        Name = name;
    }

    public void SayName()
    {
        Console.WriteLine($"Hi, I am {Name}, a programmer");
    }
}