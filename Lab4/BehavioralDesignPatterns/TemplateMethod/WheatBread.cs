namespace BehavioralDesignPatterns.TemplateMethod;

public class WheatBread : BreadTemplate
{
    protected override void Scaling()
    {
        Console.WriteLine("Measuring right amount of wheat");
    }

    protected override void Mixing()
    {
        Console.WriteLine("Applying straight dough method of mixing");
    }

    protected override void Kneading()
    {
        Console.WriteLine("Kneading by hand");
    }

    protected override void BulkFerment()
    {
        Console.WriteLine("Yeast is resting...");
    }

    protected override void Shaping()
    {
        Console.WriteLine("Make oval rolls");
    }

    protected override void Baking()
    {
        Console.WriteLine("Bake at 95 Celsius");
    }
}