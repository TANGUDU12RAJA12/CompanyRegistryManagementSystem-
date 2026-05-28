using AutoMapper;
using CurdOperationWithOnionArchitecture.DTO.Response;
using CurdOperationWithOnionArchitecture.DTO.Request;
using  CurdOperationWithOnionArchitecture.Model;
namespace CurdOperationWithOnionArchitecture.DataAccessLayer.Mapping
{
    public  class CompanyRegistryMapping : Profile
    {
        public CompanyRegistryMapping() 
        {
            //this mapping is used by getbyId or getallcompany method in service layer and controller layer
            CreateMap<CompanyResistry, ComRegistryResponseDTO>();
            // this mapping is used by createcompany  and updatecompany method in service layer and controller layer
            CreateMap<ComRegistryRequestDTO, CompanyResistry>();
            CreateMap<UpdateComRegistryRequestDTO, CompanyResistry>();

        }
    }
}
