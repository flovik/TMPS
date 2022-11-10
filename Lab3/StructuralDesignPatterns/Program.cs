//decorator

using System.Security.AccessControl;
using StructuralDesignPatterns.Adapter;
using StructuralDesignPatterns.Adapter.Interfaces;
using StructuralDesignPatterns.Composite;
using StructuralDesignPatterns.Decorator.Components;
using StructuralDesignPatterns.Decorator.DecoratorObjects;
using StructuralDesignPatterns.Facade;
using StructuralDesignPatterns.Facade.PrinterComponents;
using StructuralDesignPatterns.FacadeDecoratorComposite;
using StructuralDesignPatterns.FacadeDecoratorComposite.Components;
using StructuralDesignPatterns.FacadeDecoratorComposite.DecoratorObjects;
using StructuralDesignPatterns.FacadeDecoratorComposite.Interfaces;
using StructuralDesignPatterns.Proxy;
using StructuralDesignPatterns.Proxy.Context;
using StructuralDesignPatterns.Proxy.Interfaces;
using StructuralDesignPatterns.Proxy.Models;
using StructuralDesignPatterns.Proxy.Repositories;
using StructuralDesignPatterns.ProxyAdapter;
using StructuralDesignPatterns.ProxyAdapter.Interfaces;

Pizza ThiccPizzaWithBaconAndCheese = new ThiccPizza(); //ThiccPizza -> Pizza
ThiccPizzaWithBaconAndCheese = new Bacon(ThiccPizzaWithBaconAndCheese); //Bacon -> PizzaDecorator -> Pizza
ThiccPizzaWithBaconAndCheese = new Cheese(ThiccPizzaWithBaconAndCheese); //Cheese -> PizzaDecorator -> Pizza
Console.WriteLine(ThiccPizzaWithBaconAndCheese.Description + ", will cost " + ThiccPizzaWithBaconAndCheese.GetCost() + " leis");

Pizza SkinnyPizzaWithOnions = new SkinnyPizza();
SkinnyPizzaWithOnions = new Onions(SkinnyPizzaWithOnions);
Console.WriteLine(SkinnyPizzaWithOnions.Description + ", will cost " + SkinnyPizzaWithOnions.GetCost() + " leis");

//facade

var printer = new PrinterFacade(
    new ElectronicCircuit(),
    new InkCartridge(),
    new PaperRollers(),
    new PrintMotor(),
    new StabilizerBar());

printer.PrintDocument();

//proxy
//adds a new layer between client and database
//behaves like original object (implements the same contracts), but has some 
//buffs on top
//with adapter

//adapterProxy
var path = "C:\\Personal testing\\TMPS\\Lab3\\StructuralDesignPatterns\\Proxy\\a.png";
ITargetInterface adapterProxy = new ImageReaderAdapter(new ImageReader());
var a = adapterProxy.ReadImage(path);

var id = Guid.NewGuid();
using var context = new DesignPatternsContext();
IUserRepository proxy = new UserRepositoryProxy(new UserRepository(context));
proxy.CreateUser(new User {Name = "Victor", UserId = id, Photo = a});
proxy.GetUserPhoto(id); 
proxy.GetUserPhoto(id);
proxy.GetUserPhoto(id);

//adapter 
ICar adapter = new CarAdapter(new CarCreator());
var car = adapter.CreateCar();

//composite
var root = new ManagerComposite("Vasile Albie");
var manager1 = new ManagerComposite("Manager 1");
var manager2 = new ManagerComposite("Manager 2");
var manager3 = new ManagerComposite("Manager 3");

var programmer1 = new ProgrammerLeaf("Programmer1");
var programmer2 = new ProgrammerLeaf("Programmer2");
var programmer3 = new ProgrammerLeaf("Programmer3");

root.AddWorker(manager1);
root.AddWorker(manager2);

manager1.AddWorker(programmer1);

manager2.AddWorker(manager3);
manager2.AddWorker(programmer2);

manager3.AddWorker(programmer3);

var it = new TreeIterator();
it.IterateTree(root);

/*
              root 
    manager1        manager2
  programmer1      manager3  programmer2
                programmer3
*/


//decoratorComposite
Programmer FrontendProgrammerReact = new FrontEndProgrammer("Hi, I am a frontend programmer. ");
FrontendProgrammerReact = new React(FrontendProgrammerReact);

Programmer backendProgrammerSQLMessageBroker = new BackEndProgrammer("Hi, I am a backend dev. ");
backendProgrammerSQLMessageBroker = new SQL(backendProgrammerSQLMessageBroker);
backendProgrammerSQLMessageBroker = new MessageBroker(backendProgrammerSQLMessageBroker);

Programmer FrontendProgrammerAngularReact = new FrontEndProgrammer("Hi hi.");
FrontendProgrammerAngularReact = new Angular(FrontendProgrammerAngularReact);
FrontendProgrammerAngularReact = new React(FrontendProgrammerAngularReact);

var bigManager = new ProgrammersManagerComposite("Serioja");
var backendTeamManager = new ProgrammersManagerComposite("Back end manager");
var frontendTeamManager = new ProgrammersManagerComposite("Front end manager");

bigManager.AddWorker(backendTeamManager);
bigManager.AddWorker(frontendTeamManager);

frontendTeamManager.AddWorker(FrontendProgrammerAngularReact);
frontendTeamManager.AddWorker(FrontendProgrammerReact);

backendTeamManager.AddWorker(backendProgrammerSQLMessageBroker);

var programmerIterator = new WorkersIterator();
programmerIterator.IterateTree(bigManager);