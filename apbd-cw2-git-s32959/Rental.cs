namespace apbd_cw2_git_s32959;

public class Rental
{
    public int Id { get; set; }
    public User User { get; set; }
    public DateTime RentDate { get; set; }
    public DateTime? ExpectedReturnDate { get; set; }
    public DateTime? ActualReturnDate { get; set; }

    public Rental(int id, User user, DateTime rentDate, DateTime expectedReturnDate)
    {
        this.Id = id;
        this.User = user;
        this.RentDate = rentDate;
        this.ExpectedReturnDate = expectedReturnDate;
        this.ActualReturnDate = null;
    }
}