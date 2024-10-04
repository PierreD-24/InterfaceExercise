using System;
public class Truck : ICompany, IVehicle
{
   public Truck()
   {

   }

   public int NumberOfWheels { get; set; } = 4;
    public string Model {get; set;} = "Ford";
    public string Make {get; set;} = "F150";
    public int MilesPerGallon {get; set;} = 23;
    public string Logo { get; set; } = "Cursive Ford";
    public int Employees {get; set;} = 2000;
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