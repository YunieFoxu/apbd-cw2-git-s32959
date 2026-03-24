namespace apbd_cw2_git_s32959;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public UserType UserType { get; set; }
    
    public int ActiveRentals { get; set; }

    public User(int id, string name, string surname, UserType userType)
    {
        this.Id = id;
        this.Name = name;
        this.Surname = surname;
        this.UserType = userType;
        this.ActiveRentals = 0;
    }

    public override string ToString()
    {
        return $"ID: {this.Id}" + System.Environment.NewLine +
               $"Name: {this.Name}" + System.Environment.NewLine +
               $"Surname: {this.Surname}" + System.Environment.NewLine +
               $"UserType: {this.UserType}";
    }
}