using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class ServiceTypeDTO
    {
        private Int32 _id;
        private String _serviceType;
        private String _description;

        public int Id { get => _id; set => _id = value; }
        public string ServiceType { get => _serviceType; set => _serviceType = value; }
        public string Description { get => _description; set => _description = value; }
    }
}
