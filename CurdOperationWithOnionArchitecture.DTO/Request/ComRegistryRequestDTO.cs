using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurdOperationWithOnionArchitecture.DTO.Request
{
    public class ComRegistryRequestDTO
    {
        public string Name { get; set; }
        public int EmployeeCount { get; set; }
        public string Description { get; set; }
    }
    public class UpdateComRegistryRequestDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeCount { get; set; }
        public string Description { get; set; }
    }
}
