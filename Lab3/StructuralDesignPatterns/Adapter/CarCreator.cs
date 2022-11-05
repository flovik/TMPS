using StructuralDesignPatterns.Adapter.Interfaces;
using StructuralDesignPatterns.Adapter.Models;

namespace StructuralDesignPatterns.Adapter;

public class CarCreator : ICar
{
    public Car CreateCar()
    {
        return new Car {Name = "BMW", MaxSpeed = 300};
    }
}