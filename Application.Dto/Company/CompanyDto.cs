namespace Application.Dto.Company;

public class CompanyDto
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Description { get; set; }
    public string WebsiteUrl { get; set; }
    public string ProfilePicture { get; set; }
    public string BannerPicture { get; set; }
    public string Email { get; set; } = string.Empty;
    public byte[] PasswordHash { get; set; } = new byte[32];
    public byte[] PasswordSalt { get; set; } = new byte[32];
    public int RoleId { get; set; }
}