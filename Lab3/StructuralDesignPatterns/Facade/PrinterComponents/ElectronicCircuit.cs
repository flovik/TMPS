using StructuralDesignPatterns.Facade.Interfaces;

namespace StructuralDesignPatterns.Facade.PrinterComponents;

public class ElectronicCircuit : IElectronicCircuit
{
    public void TranslateInfo()
    {
        Console.WriteLine("Translating instructions from computer into " +
                          "movements to print");
    }
}