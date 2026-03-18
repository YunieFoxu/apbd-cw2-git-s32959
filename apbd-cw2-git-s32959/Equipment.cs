namespace apbd_cw2_git_s32959;

public abstract class Equipment
{
    public string Id { get; }
    public string Name { get; set; }
    public bool Available { get; set; }
    public double HourlyRentPrice { get; set; }
    
    public Equipment(string id, string name, bool available, double hourlyRentPrice)
    {
        this.Id = id;
        this.Name = name;
        this.Available = available;
        this.HourlyRentPrice = hourlyRentPrice;
    }

    public virtual string GetInfo()
    {
        return $"Name: {this.Name}\n" +
               $"Available: {this.Available}\n" +
               $"HourlyRentPrice: {this.HourlyRentPrice}";
    }
}