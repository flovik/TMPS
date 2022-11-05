using StructuralDesignPatterns.Composite.Interfaces;

namespace StructuralDesignPatterns.Composite;

public class TreeIterator
{
    private Stack<ManagerComposite> _stack = new();
    public void IterateTree(ManagerComposite root)
    {
        _stack.Push(root);
        while (_stack.Count != 0)
        {
            var manager = _stack.Pop();
            manager.SayName();

            foreach (var managerWorker in manager.workers)
            {
                switch (managerWorker)
                {
                    case ManagerComposite worker:
                        _stack.Push(worker);
                        break;
                    case ProgrammerLeaf:
                        managerWorker.SayName();
                        break;
                }
            }
        }
    }
}