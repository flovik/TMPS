namespace BehavioralDesignPatterns.TemplateMethod;

public class RyeBread : BreadTemplate
{
    protected override void ProofingYeast()
    {
        Console.WriteLine("Checking if yeast is not too old");
    }

    protected override void Scaling()
    {
        Console.WriteLine("Measuring right amount of rye");
    }

    protected override void Mixing()
    {
        Console.WriteLine("Applying sponge method of mixing");
    }

    protected override void Kneading()
    {
        Console.WriteLine("Kneading with mixer");
    }

    protected override void BulkFerment()
    {
        Console.WriteLine("Yeast is resting...");
    }

    protected override void Shaping()
    {
        Console.WriteLine("Make circle rolls");
    }

    protected override void Baking()
    {
        Console.WriteLine("Bake at 90 Celsius");
    }
}