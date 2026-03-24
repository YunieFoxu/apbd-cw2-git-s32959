namespace apbd_cw2_git_s32959;

public class VrHeadSet : Equipment
{
    public int RefreshRate { get; set; }
    public string BatteryLife { get; set; }

    public VrHeadSet(int id,
        string name,
        bool available,
        double hourlyRentPrice,
        int refreshRate,
        string batteryLife)
        : base(id, name, available, hourlyRentPrice)
    {
        this.RefreshRate = refreshRate;
        this.BatteryLife = batteryLife;
    }

    public override string ToString()
    {
        return base.ToString() + System.Environment.NewLine +
               $"RefreshRate: {this.RefreshRate}" + System.Environment.NewLine +
               $"BatteryLife: {this.BatteryLife}";
    }
}