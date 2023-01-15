using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class FederationStateDTO
    {
        private Int32 _id;
        private String _federationState;
        private String _initials;

        public int Id { get => _id; set => _id = value; }
        public string FederationState { get => _federationState; set => _federationState = value; }
        public string Initials { get => _initials; set => _initials = value; }
    }
}
