//template method - we have an algorithm that subclasses may or may not override, they can change their behaviour but not the algorithm's steps

using BehavioralDesignPatterns.Strategy;
using BehavioralDesignPatterns.TemplateMethod;

BreadTemplate bread = new WheatBread();
bread.PrepareBread();

bread = new RyeBread();
bread.PrepareBread();

//strategy - based on the condition we have, change the strategy in the runtime, switch algorithm based on the situation
var sorter = new Sorter(new BubbleSort());
sorter.Sort(new List<int>());

sorter.ChangeStrategy(new QuickSort());
sorter.Sort(new List<int>());

sorter.ChangeStrategy(new CountingSort());
sorter.Sort(new List<int>());