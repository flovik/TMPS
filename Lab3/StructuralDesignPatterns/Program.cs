//decorator

using System.Security.AccessControl;
using StructuralDesignPatterns.Adapter;
using StructuralDesignPatterns.Adapter.Interfaces;
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