using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CurdOperationWithOnionArchitecture.DTO.Request;
using CurdOperationWithOnionArchitecture.DTO.Response;
using CurdOperationWithOnionArchitecture.Model;
using CurdOperationWithOnionArchitecture.Services.Interface;
using Microsoft.EntityFrameworkCore;
namespace CurdOperationWithOnionArchitecture.Services
{
    public  class ComRegistryServises : IComRegistryServices
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public ComRegistryServises(ApplicationDbContext applicationDbContext ,IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<ComRegistryResponseDTO> CreateCompany(ComRegistryRequestDTO request)
        {
            var company = _mapper.Map<CompanyResistry>(request);
            await _applicationDbContext.CompanyResistries.AddAsync(company);
            await _applicationDbContext.SaveChangesAsync();
            return _mapper.Map<ComRegistryResponseDTO>(company);
        }

        public async Task<bool> DeleteCompany(int id) 
        {
            //throw new NotImplementedException();
            var company = await _applicationDbContext.CompanyResistries.FindAsync(id);
            if(company == null) { return false;
            }
            return true;
        }

        public async Task<IEnumerable<ComRegistryResponseDTO>> GetAllCompanie()
        {
            var companies = await _applicationDbContext.CompanyResistries
                //.AsNoTracking()
                //.AsSplitQuery()
                .ToListAsync();
            return _mapper.Map<IEnumerable<ComRegistryResponseDTO>>(companies);
        }

        public async Task<ComRegistryResponseDTO> GetCompanyById(int id)
        {
            //throw new NotImplementedException();
            var company = await _applicationDbContext.CompanyResistries.FindAsync(id);
            if(company == null) { return null; }
            return _mapper.Map<ComRegistryResponseDTO>(company);
        }     
        public async Task<ComRegistryResponseDTO> UpdateCompany( UpdateComRegistryRequestDTO request)
        {
            // throw new NotImplementedException();
            var company = await _applicationDbContext.CompanyResistries.FindAsync(request.Id);
            if (company == null)
            {
                return null;
            }
            _mapper.Map(request, company);
            await _applicationDbContext.SaveChangesAsync();
            return _mapper.Map<ComRegistryResponseDTO>(company);
        }
    }
}
