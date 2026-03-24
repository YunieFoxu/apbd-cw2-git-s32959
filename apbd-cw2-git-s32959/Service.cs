namespace apbd_cw2_git_s32959;

public class Service
{
    private List<Equipment> _equipmentList;
    private List<User> _users;
    private List<Rental> _rentals;
    private int _userCounter;
    private int _equipmentCounter;
    private int _rentalCounter;
    private Dictionary<UserType, int> userLimits;

    public Service()
    {
        this._equipmentList = new List<Equipment>();
        this._users = new List<User>();
        this._rentals = new List<Rental>();
        this._userCounter = 0;
        this._equipmentCounter = 0;
    }

    public void AddUser(string name, string surname, UserType userType)
    {
        _users.Add(new User(++_userCounter, name, surname, userType));
    }
    
    public void AddLaptop(
        string name, 
        double hourlyRentPrice,
        string cpu,
        string gpu
    )
    {
        _equipmentList.Add(new Laptop(
            ++this._equipmentCounter, name, true, hourlyRentPrice, cpu, gpu
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
            ++this._equipmentCounter, name, true, hourlyRentPrice, resolution, fps
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
            ++this._equipmentCounter, name, true, hourlyRentPrice, refreshRate, batteryLife
        ));
    }

    public void ListEquipment()
    {
        foreach (Equipment eq in _equipmentList)
        {
            Console.WriteLine($"Name: {eq.Name}, ID: {eq.Id}, IsAvailable: {eq.Available}");
        }
    }

    public void ListAvailableEquipment()
    {
        foreach (Equipment eq in _equipmentList)
        {
            if (eq.Available) Console.WriteLine($"Name: {eq.Name}, ID: {eq.Id}");
        }
    }

    public void RentEquipment(int userid, int equipmentId , int days)
    {
        bool flag = true;
        foreach (User user in _users)
        {
            foreach (Equipment equipment in _equipmentList)
            {
                if (user.Id==userid && equipment.Id==equipmentId) {
                    if (user.ActiveRentals < (int)user.UserType)
                    {
                        if (equipment.Available)
                        {
                            _rentals.Add(new Rental(
                                _rentalCounter++, 
                                user, 
                                equipment,
                                DateTime.Now, 
                                DateTime.Now.AddDays(days)
                            ));
                            user.ActiveRentals++;
                        }
                        else
                        {
                            Console.WriteLine("Equipment not available for rent");
                            flag = false;
                            break;
                        }
                        flag = false;    
                    }
                    else
                    {
                        Console.WriteLine("Limit reached for user");
                        flag = false;
                        break;
                    }
                    
                }
            }
        }
        if (flag) Console.WriteLine("No such User or Equipment in Database");
    }

    public void ReturnEquipment(int rentalId)
    {
        bool flag = true;
        foreach (Rental rental in _rentals)
        {
            if (rental.Id == rentalId)
            {
                rental.ActualReturnDate = DateTime.Now;
                TimeSpan? dateDiff = rental.ActualReturnDate - rental.ExpectedReturnDate;
                Console.WriteLine($"Returned equipment {dateDiff?.Days} days late");
                Console.WriteLine($"Extra costs for delay: " +
                                  $"{dateDiff?.Days*rental.Equipment.DailyRentPrice}"
                );
                rental.Equipment.Available = true;
                rental.User.ActiveRentals--;
                flag = false;
            }
        }
        if (flag) Console.WriteLine("No such Rental in Database");
    }

    public void MakeEquipmentUnavailable(int equipmentId)
    {
        bool flag = true;
        foreach (Equipment equipment in _equipmentList)
        {
            if (equipment.Id == equipmentId)
            {
                equipment.Available = false;
                flag = false;
            }
        }

        if (flag)
        {
            Console.WriteLine("No such Equipment exists");    
        }
    }

    public void ShowActiveRentalsForUser(int userid)
    {
        Console.WriteLine($"Active rentals for user {userid}");
        foreach (Rental rental in _rentals)
        {
            if (rental.User.Id==userid & rental.ActualReturnDate == null) 
                Console.WriteLine($"Rental ID: {rental.Id}");
        }
    }

    public void ShowExpiredRentals()
    {
        Console.WriteLine("Expired rentals:");
        foreach (Rental rental in _rentals)
        {
            if (rental.ActualReturnDate == null & rental.ExpectedReturnDate<DateTime.Now)
                Console.WriteLine($"Rental ID: {rental.Id}, User ID: {rental.User.Id}");
        }
    }

    public void ShowRaport()
    {
        int ActiveRentals = 0;
        int ExpiredRentals = 0;
        foreach (Rental rental in _rentals)
        {
            if (rental.ExpectedReturnDate == null)
                if (rental.ExpectedReturnDate > DateTime.Now)
                    ExpiredRentals++;
                else
                    ActiveRentals++;
                
        }
        Console.WriteLine("Raport: ");
        Console.WriteLine($"Amount of users: {_users.Count}");
        Console.WriteLine($"Overall rentals: {_rentals.Count}");
        Console.WriteLine($"Active rentals: {ActiveRentals}");
        Console.WriteLine($"Expired rentals: {ExpiredRentals}");
        
    }
}