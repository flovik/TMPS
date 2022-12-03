namespace BehavioralDesignPatterns.Strategy;

public class Sorter
{
    private ISortStrategy sortStrategy;

    public Sorter(ISortStrategy sortStrategy)
    {
        this.sortStrategy = sortStrategy;
    }

    public void ChangeStrategy(ISortStrategy strategy)
    {
        sortStrategy = strategy ??= new BubbleSort();
    }

    public ICollection<int> Sort(ICollection<int> array)
    {
        return sortStrategy.Sort(array);
    }
}