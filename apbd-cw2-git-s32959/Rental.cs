namespace apbd_cw2_git_s32959;

public class Rental
{
    public int Id { get; }
    public User User { get; }

    public Equipment Equipment { get; }
    public DateTime RentDate { get; set; }
    public DateTime? ExpectedReturnDate { get; set; }
    public DateTime? ActualReturnDate { get; set; }

    public Rental(int id, User user, Equipment equipment, DateTime rentDate, DateTime expectedReturnDate)
    {
        this.Id = id;
        this.User = user;
        this.Equipment = equipment;
        this.RentDate = rentDate;
        this.ExpectedReturnDate = expectedReturnDate;
        this.ActualReturnDate = null;
        equipment.Available = false;
    }
}