//decorator

using System.Security.AccessControl;
using StructuralDesignPatterns.Adapter;
using StructuralDesignPatterns.Adapter.Interfaces;
using StructuralDesignPatterns.Composite;
using StructuralDesignPatterns.Decorator.Components;
using StructuralDesignPatterns.Decorator.DecoratorObjects;
using StructuralDesignPatterns.Facade;
using StructuralDesignPatterns.Facade.PrinterComponents;
using StructuralDesignPatterns.Proxy;
using StructuralDesignPatterns.Proxy.Context;
using StructuralDesignPatterns.Proxy.Interfaces;
using StructuralDesignPatterns.Proxy.Models;
using StructuralDesignPatterns.Proxy.Repositories;

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

using var fs = new FileStream(
    "D:\\Personal projects\\TMPS\\Lab3\\StructuralDesignPatterns\\Proxy\\a.png",
    FileMode.OpenOrCreate);
var id = Guid.NewGuid();
using var ms = new MemoryStream();
fs.CopyTo(ms);
var a = ms.ToArray();

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