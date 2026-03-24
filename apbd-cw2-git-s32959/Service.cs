namespace apbd_cw2_git_s32959;

public class Service
{
    private List<Equipment> _equipmentList;
    private List<User> _users;
    private int _userCounter;
    private int _equipmentCounter;

    public Service()
    {
        this._equipmentList = new List<Equipment>();
        this._users = new List<User>();
        this._userCounter = 0;
        this._equipmentCounter = 0;
    }

    public void AddUser(string name, string surname, UserType userType)
    {
        _users.Add(new User(_userCounter++, name, surname, userType));
    }
    
    public void AddLaptop(
        string name, 
        double hourlyRentPrice,
        string cpu,
        string gpu
    )
    {
        _equipmentList.Add(new Laptop(
            this._equipmentCounter++, name, true, hourlyRentPrice, cpu, gpu
        ));
    }

    public void AddCamera(
        string name, 
        double hourlyRentPrice,
        string resolution,
        int fps
    )
    {
        this._equipmentList.Add(new Camera(
            this._equipmentCounter++, name, true, hourlyRentPrice, resolution, fps
        ));
    }

    public void AddVrHeadSet(
        string name,
        double hourlyRentPrice,
        int refreshRate,
        string batteryLife
    )
    {
        this._equipmentList.Add(new VrHeadSet(
            this._equipmentCounter++, name, true, hourlyRentPrice, refreshRate, batteryLife
        ));
    }
}