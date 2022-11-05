//decorator

using StructuralDesignPatterns.Decorator.Components;
using StructuralDesignPatterns.Decorator.DecoratorObjects;

Pizza ThiccPizzaWithBaconAndCheese = new ThiccPizza(); //ThiccPizza -> Pizza
ThiccPizzaWithBaconAndCheese = new Bacon(ThiccPizzaWithBaconAndCheese); //Bacon -> PizzaDecorator -> Pizza
ThiccPizzaWithBaconAndCheese = new Cheese(ThiccPizzaWithBaconAndCheese); //Cheese -> PizzaDecorator -> Pizza
Console.WriteLine(ThiccPizzaWithBaconAndCheese.Description + ", will cost " + ThiccPizzaWithBaconAndCheese.GetCost() + " leis");

Pizza SkinnyPizzaWithOnions = new SkinnyPizza();
SkinnyPizzaWithOnions = new Onions(SkinnyPizzaWithOnions);
Console.WriteLine(SkinnyPizzaWithOnions.Description + ", will cost " + SkinnyPizzaWithOnions.GetCost() + " leis");
