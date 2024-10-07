public interface IVehicle
{
    public int NumberOfWheels { get; set; }
    public string Model {get; set;}
    public string Make {get; set;}
    public int MilesPerGallon {get; set;}
    public bool HasChangedGears {get; set;}

    public void Drive();
    public void Reverse();
    public void Park();
    public void ChangeGears(bool isChanged);
}