namespace BehavioralDesignPatterns.Strategy;

public class QuickSort : ISortStrategy
{
    public ICollection<int> Sort(ICollection<int> array)
    {
        Console.WriteLine("Sorting an array using quick sort, good for evenly partitioned numbers");
        return array;
    }
}