namespace apbd_cw2_git_s32959;

public class Camera : Equipment
{
    public string Resolution { get; set; }
    public int Fps { get; set; }

    public Camera(
        string id, 
        string name, 
        bool available, 
        double hourlyRentPrice,
        string resolution,
        int fps
        ) 
        : base(id, name, available, hourlyRentPrice)
        {
            this.Resolution = resolution;
            this.Fps = fps;
        }
}