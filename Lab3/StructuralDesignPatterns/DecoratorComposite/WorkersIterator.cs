using StructuralDesignPatterns.Composite;
using StructuralDesignPatterns.FacadeDecoratorComposite.Components;

namespace StructuralDesignPatterns.FacadeDecoratorComposite;

public class WorkersIterator
{
    private Stack<ProgrammersManagerComposite> _stack = new();
    public void IterateTree(ProgrammersManagerComposite root)
    {
        _stack.Push(root);
        while (_stack.Count != 0)
        {
            var manager = _stack.Pop();
            Console.WriteLine(manager.SayName());

            foreach (var managerWorker in manager.workers)
            {
                switch (managerWorker)
                {
                    case ProgrammersManagerComposite worker:
                        _stack.Push(worker);
                        break;
                    case Programmer:
                        Console.WriteLine(managerWorker.SayName());
                        break;
                }
            }
        }
    }
}