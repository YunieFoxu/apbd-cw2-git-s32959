namespace apbd_cw2_git_s32959;

public class VrHeadSet : Equipment
{
    public int RefreshRate { get; set; }

    public VrHeadSet(string id,
        string name,
        bool available,
        double hourlyRentPrice,
        int refreshRate)
        : base(id, name, available, hourlyRentPrice)
    {
        this.RefreshRate = refreshRate;
    }
}