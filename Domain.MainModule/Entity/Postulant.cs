using Domain.Core.Entity;

namespace Domain.MainModule.Entity;

public class Postulant : Entity<int>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public double Salary { get; set; } = 0;
    public string Email { get; set; } = string.Empty;
    public int PhoneNumber { get; set; } = 0;
    public string WorkingPlaces { get; set; }
    public string Languages { get; set; }
    public string Skills { get; set; }
    public string About { get; set; }
    public string StudyCenter { get; set; }
    public string ProfilePicture { get; set; } = "https://images.nightcafe.studio//assets/profile.png";
    public string BannerPicture { get; set; } =
        "https://www.generationsforpeace.org/wp-content/uploads/2018/03/empty.jpg";
    public byte[] PasswordHash { get; set; } = new byte[32];
    public byte[] PasswordSalt { get; set; } = new byte[32];
    public int RoleId { get; set; }
    public Role PostulantRole { get; set; }
    public ICollection<Postulation> Postulations { get; set; }
    public ICollection<SavedJobOffers> SavedJobOffers { get; set; }

}