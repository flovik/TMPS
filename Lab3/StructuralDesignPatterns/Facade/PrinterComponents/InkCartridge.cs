using StructuralDesignPatterns.Facade.Interfaces;

namespace StructuralDesignPatterns.Facade.PrinterComponents;

public class InkCartridge : IInk
{
    public void ApplyInk()
    {
        Console.WriteLine("Applying ink on paper...");
    }
}