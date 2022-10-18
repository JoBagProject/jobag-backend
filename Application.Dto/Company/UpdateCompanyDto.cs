namespace Application.Dto.Company;

public class UpdateCompanyDto
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Description { get; set; }
    public string WebsiteUrl { get; set; }
    public string ProfilePicture { get; set; }
    public string BannerPicture { get; set; }
}