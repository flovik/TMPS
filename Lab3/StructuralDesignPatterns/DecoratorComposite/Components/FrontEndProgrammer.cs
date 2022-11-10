namespace StructuralDesignPatterns.FacadeDecoratorComposite.Components;

public class FrontEndProgrammer : Programmer
{
    public FrontEndProgrammer(string name) : base(name)
    {
    }

    public override string SayName()
    {
        return Name + ", I am a frontend developer. ";
    }
}