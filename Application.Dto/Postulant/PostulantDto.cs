namespace Application.Dto.Postulant;

public class PostulantDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public string WorkingPlaces { get; set; }
    public string Languages { get; set; }
    public string Skills { get; set; }
    public string StudyCenter { get; set; }
    public string About { get; set; }
    public string ProfilePicture { get; set; }
    public string BannerPicture { get; set; }
    public byte[] PasswordHash { get; set; } = new byte[32];
    public byte[] PasswordSalt { get; set; } = new byte[32];
    public int RoleId { get; set; }
}