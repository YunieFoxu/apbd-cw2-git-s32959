namespace apbd_cw2_git_s32959;

public abstract class Equipment
{
    public int Id { get; }
    public string Name { get; set; }
    public bool Available { get; set; }
    public double DailyRentPrice { get; set; }
    
    public Equipment(int id, string name, bool available, double dailyRentPrice)
    {
        this.Id = id;
        this.Name = name;
        this.Available = available;
        this.DailyRentPrice = dailyRentPrice;
    }
    
    public override string ToString()
    {
        return $"Name: {this.Name}" + System.Environment.NewLine +
               $"Available: {this.Available}" + System.Environment.NewLine +
               $"HourlyRentPrice: {this.DailyRentPrice}";
    }
}