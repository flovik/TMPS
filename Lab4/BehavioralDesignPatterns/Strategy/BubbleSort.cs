namespace BehavioralDesignPatterns.Strategy;

public class BubbleSort : ISortStrategy
{
    public ICollection<int> Sort(ICollection<int> array)
    {
        Console.WriteLine("Sorting array using bubble sort, for small arrays");
        return array;
    }
}