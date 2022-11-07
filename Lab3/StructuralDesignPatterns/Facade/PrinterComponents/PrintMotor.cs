using StructuralDesignPatterns.Facade.Interfaces;

namespace StructuralDesignPatterns.Facade.PrinterComponents;

public class PrintMotor : IMove
{
    public void MoveObject()
    {
        Console.WriteLine("Rolling paper rollers...");
    }
}