using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurdOperationWithOnionArchitecture.DTO.Response;
using CurdOperationWithOnionArchitecture.DTO.Request;
namespace CurdOperationWithOnionArchitecture.Services.Interface
{
    public  interface IComRegistryServices
    {
        Task<IEnumerable<ComRegistryResponseDTO>> GetAllCompanie();
        Task<ComRegistryResponseDTO> GetCompanyById(int id);
        Task<ComRegistryResponseDTO> CreateCompany(ComRegistryRequestDTO request);
        Task<ComRegistryResponseDTO> UpdateCompany(UpdateComRegistryRequestDTO request);
        Task<bool> DeleteCompany  (int id);  
    }
}
