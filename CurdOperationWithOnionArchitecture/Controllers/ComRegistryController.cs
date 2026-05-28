using CurdOperationWithOnionArchitecture.DTO.Request;
using CurdOperationWithOnionArchitecture.DTO.Response;
using CurdOperationWithOnionArchitecture.Services;
using CurdOperationWithOnionArchitecture.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurdOperationWithOnionArchitecture.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ComRegistryController : ControllerBase
    {
        private readonly IComRegistryServices _comRegistryServices;


        public ComRegistryController(IComRegistryServices comRegistryServices)
        {
            _comRegistryServices = comRegistryServices;
        }

        //api/ComRegistry/GetAllCompanies
        [HttpGet("GetAllCompanies")]
        public async Task<ActionResult<IEnumerable<ComRegistryResponseDTO>>> GetAllCompanies()
        {
            var companies = await _comRegistryServices.GetAllCompanie();

            return Ok(companies);

        }

        //api/ComRegistry/GetCompanyById/1
        [HttpGet("GetCompanyById/{id}")]
        public async Task<IActionResult> GetCompanyById(int id)
        {
            var company = await _comRegistryServices.GetCompanyById(id);
            if (company == null)
            {
                return NotFound();
            }
            return Ok(company);
        }

        //api/ComRegistry/CreateCompany
        [HttpPost("CreateCompany")]
        public async Task<IActionResult> CreateCompany(ComRegistryRequestDTO comRegistryRequestDTO)
        {
            var company = await _comRegistryServices.CreateCompany(comRegistryRequestDTO);
            return Ok(company);
        }

        //api/ComRegistry/UpdateCompany
        [HttpPut("UpdateCompany")]
        public async Task<IActionResult> UpdateCompany(UpdateComRegistryRequestDTO updateComRegistryRequestDTO)
        {
            var company = await _comRegistryServices.UpdateCompany(updateComRegistryRequestDTO);
            if (company == null)
            {
                return NotFound();
            }
            return Ok(company);
        }
         
        //api/ComRegistry/DeleteCompany/1
        [HttpDelete("DeleteCompany/{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var result = await _comRegistryServices.DeleteCompany(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}
