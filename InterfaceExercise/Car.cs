using System;
public class Car : ICompany, IVehicle
{
    public Car()
    {

    }

    public bool FuelEfficient { get; set; } = true;
    public bool Compact { get; set; } = true;
    public int NumberOfWheels { get; set; } = 4;
    public string Model {get; set;} = "Dodge";
    public string Make {get; set;} = "Charger";
    public int MilesPerGallon {get; set;} = 20;
    public string Logo { get; set; } = "Ram";
    public int Employees {get; set;} = 1000;
    public bool HasChangedGears {get; set;}

    public void Drive()
    {
        Console.WriteLine($"The {GetType().Name} is driving forward.");
    }
    public void Reverse()
    {
        if (HasChangedGears == true)
        {
            Console.WriteLine($"The {GetType().Name} is reversing.");
            HasChangedGears = false;
        }
        else
        {
            Console.WriteLine("Can't reverse until we change gears");
        }
    }
    public void Park()
    {
        if (HasChangedGears == true)
        {
            Console.WriteLine($"The {GetType().Name} is parked.");
            HasChangedGears = false;
        }
        else
        {
            Console.WriteLine("Can't park until we change gears");
        }
    }

    public void ChangeGears(bool isChanged)
    {
        HasChangedGears = isChanged;
    }
}