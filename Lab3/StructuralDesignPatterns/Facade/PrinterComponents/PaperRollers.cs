using StructuralDesignPatterns.Facade.Interfaces;

namespace StructuralDesignPatterns.Facade.PrinterComponents;

public class PaperRollers : IMove
{
    public void MoveObject()
    {
        Console.WriteLine("Moving the papers from the paper feed inside...");
    }
}