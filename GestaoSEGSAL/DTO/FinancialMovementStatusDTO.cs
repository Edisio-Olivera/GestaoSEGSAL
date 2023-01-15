using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class FinancialMovementStatusDTO
    {
        private Int32 _id;      //id
        private String _status; //status

        public int Id { get => _id; set => _id = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
