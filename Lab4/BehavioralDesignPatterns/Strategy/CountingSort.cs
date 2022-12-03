namespace BehavioralDesignPatterns.Strategy;

public class CountingSort : ISortStrategy
{
    public ICollection<int> Sort(ICollection<int> array)
    {
        Console.WriteLine("Sorting an array using counting sort, good for a narrow range of numbers");
        return array;
    }
}