using Application.Dto.Company;
using Application.Dto.Postulant;

namespace Application.MainModule.Interface;

public interface ICompanyAppService
{
    Task<CompanyDto> GetById(int companyId);
    Task<string> Add(AddCompanyDto companyDto);
    Task<string> Update(UpdateCompanyDto updateCompanyDto);
    Task<CompanyDto> Register(RegisterCompanyDto register);
    Task<LoginCompanyResponseDto> Login(LoginCompanyDto login);

}
