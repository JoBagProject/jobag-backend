using Domain.Core.Entity;

namespace Domain.MainModule.Entity;
public class Company : Entity<int>
{
    public string CompanyName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string WebsiteUrl { get; set; } = string.Empty;
    public string ProfilePicture { get; set; } = string.Empty;
    public string BannerPicture { get; set; }
    public int RoleId { get; set; }
    public byte[] PasswordHash { get; set; } = new byte[32];
    public byte[] PasswordSalt { get; set; } = new byte[32];
    public Role CompanyRole { get; set; }
}