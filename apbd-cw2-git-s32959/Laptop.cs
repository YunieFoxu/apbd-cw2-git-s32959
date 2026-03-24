namespace apbd_cw2_git_s32959;

public class Laptop : Equipment
{
    public string Cpu { get; set; }
    public string Gpu{ get; set; }
    
    public Laptop(
        int id, 
        string name, 
        bool available, 
        double hourlyRentPrice,
        string cpu,
        string gpu) 
        : base(id, name, available, hourlyRentPrice)
    {
        this.Cpu = cpu;
        this.Gpu = gpu;
    }

    public override string ToString()
    {
        return base.ToString() + System.Environment.NewLine +
               $"CPU: {this.Cpu}" + System.Environment.NewLine +
               $"GPU: {this.Gpu}";
    }
}