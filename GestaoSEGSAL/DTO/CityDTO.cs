using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class CityDTO
    {
        private Int32 _id;
        private String _federationState;
        private String _city;

        public int Id { get => _id; set => _id = value; }
        public string FederationState { get => _federationState; set => _federationState = value; }
        public string City { get => _city; set => _city = value; }
    }
}
