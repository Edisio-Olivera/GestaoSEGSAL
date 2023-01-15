using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class BussinessProposalStatusDTO
    {
        private Int32 id;
        private String status;

        public int Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }
    }
}
