using Application.Dto.Company;
using Application.Dto.Postulant;
using Application.MainModule;
using Application.MainModule.Interface;
using Hangfire.MemoryStorage.Dto;
using Infrastructure.CrossCutting.Wrapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Distributed.Services.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : CoreController
{
    private readonly ICompanyAppService _companyAppService;

    public CompanyController(ICompanyAppService companyAppService)
    {
        _companyAppService = companyAppService;
    }

    [AllowAnonymous]
    [HttpPost("Register")]
    [ProducesResponseType(typeof(JsonResult<CompanyDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> RegisterPostulant(RegisterCompanyDto register)
    {
        var result = await _companyAppService.Register(register);
        return new OkObjectResult(new JsonResult<CompanyDto>(result));
    }

    [AllowAnonymous]
    [HttpPost("Login")]
    [ProducesResponseType(typeof(JsonResult<LoginCompanyResponseDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> LocingCompany(LoginCompanyDto loginCompany)
    {
        var result = await _companyAppService.Login(loginCompany);
        return new OkObjectResult(new JsonResult<LoginCompanyResponseDto>(result));
    }

    [AllowAnonymous]
    [HttpGet("Get")]
    [ProducesResponseType(typeof(JsonResult<CompanyDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetById(int companyId)
    {
        var result = await _companyAppService.GetById(companyId);
        return new OkObjectResult(new JsonResult<CompanyDto>(result));
    }

    [HttpPost(nameof(Add))]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Add([FromBody] AddCompanyDto companyDto)
    {
        var response = await _companyAppService.Add(companyDto);
        return new OkObjectResult(new JsonResult<string>(response));
    }

    [HttpPut(nameof(Update))]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Update([FromBody] UpdateCompanyDto updateCompanyDto)
    {
        var response = await _companyAppService.Update(updateCompanyDto);
        return new OkObjectResult(new JsonResult<string>(response));
    }
}