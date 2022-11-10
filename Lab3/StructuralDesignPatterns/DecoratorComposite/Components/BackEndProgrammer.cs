namespace StructuralDesignPatterns.FacadeDecoratorComposite.Components;

public class BackEndProgrammer : Programmer
{
    public BackEndProgrammer(string name) : base(name)
    {
    }

    public override string SayName()
    {
        return Name + ", I am a backend developer. ";
    }
}