//template method - we have an algorithm that subclasses may or may not override, they can change their behaviour but not the algorithm's steps

using BehavioralDesignPatterns.Mediator;
using BehavioralDesignPatterns.Observer;
using BehavioralDesignPatterns.State;
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

//observer - defines a subscription mechanism to notify multiple subscribers if 
//some events in the class are changing
FacebookGroup facebook = new FacebookGroup();
//new post created, notify
facebook.NewPost();
var sub = new Subscriber(facebook, "Victor");
facebook.NotifySubscribers();

sub.UnSubscribe();
facebook.NotifySubscribers();

//mediator - reduces dependencies between objects. No direct communication is established
//between objects, and they talk with each other via a mediator.

var mediator = new EmailMediator();
var user1 = new User("Victor", mediator);
var user2 = new User("Pechea", mediator);
var user3 = new User("Serioja", mediator);

mediator.AddUser(user1);
mediator.AddUser(user3);

user2.SendEmail("Aleo");
user1.SendEmail("Aleo, Serioja");

//state - lets change the behaviour of a class when the state changes
var notepad = new Notepad();
notepad.AddTextWithStyle("Text scris in default. ");
notepad.ChangeState(new UpperCaseState());
notepad.AddTextWithStyle("Acest text va fi reprezentat in uppercase. ");
notepad.ChangeState(new BoldCaseState());
notepad.AddTextWithStyle("Da acesta e text in bold");
Console.WriteLine(notepad.Text);