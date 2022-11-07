using StructuralDesignPatterns.Adapter.Interfaces;
using StructuralDesignPatterns.Adapter.Models;

namespace StructuralDesignPatterns.Adapter;

public class CarAdapter : ICar
{
    //uses composition to retrieve data from service and then
    //manipulate with it in adapter and return new data for client
    private ICar _carCreator;

    public CarAdapter(ICar carCreator)
    {
        _carCreator = carCreator;
    }

    public Car CreateCar()
    {
        var car = _carCreator.CreateCar();
        car.Name = "BMW 2.0";
        car.MaxSpeed = 350;
        return car;
    }
}