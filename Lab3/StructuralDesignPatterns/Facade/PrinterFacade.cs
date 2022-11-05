using StructuralDesignPatterns.Facade.Interfaces;
using StructuralDesignPatterns.Facade.PrinterComponents;

namespace StructuralDesignPatterns.Facade;

public class PrinterFacade : IPrint
{
    private IElectronicCircuit _electronicCircuit;
    private IInk _inkCartridge;
    private IMove _paperRollers;
    private IMove _printMotor;
    private IStabilizer _stabilizerBar;

    public PrinterFacade(IElectronicCircuit electronicCircuit, IInk inkCartridge, IMove paperRollers, IMove printMotor, IStabilizer stabilizerBar)
    {
        _electronicCircuit = electronicCircuit;
        _inkCartridge = inkCartridge;
        _paperRollers = paperRollers;
        _printMotor = printMotor;
        _stabilizerBar = stabilizerBar;
    }

    public void PrintDocument()
    {
        Console.WriteLine("Printing started! *bzzz*");
        _electronicCircuit.TranslateInfo();
        _printMotor.MoveObject();
        _paperRollers.MoveObject();
        _stabilizerBar.StabilizePaper();
        _inkCartridge.ApplyInk();
        Console.WriteLine("Printing finished!");
    }
}