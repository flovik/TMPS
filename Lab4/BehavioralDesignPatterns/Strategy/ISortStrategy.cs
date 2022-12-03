namespace BehavioralDesignPatterns.Strategy;

public interface ISortStrategy
{
    ICollection<int> Sort(ICollection<int> array);
}