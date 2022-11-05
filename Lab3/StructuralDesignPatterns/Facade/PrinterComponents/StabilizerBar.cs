using StructuralDesignPatterns.Facade.Interfaces;

namespace StructuralDesignPatterns.Facade.PrinterComponents;

public class StabilizerBar : IStabilizer
{
    public void StabilizePaper()
    {
        Console.WriteLine("Stabilize paper...");
    }
}