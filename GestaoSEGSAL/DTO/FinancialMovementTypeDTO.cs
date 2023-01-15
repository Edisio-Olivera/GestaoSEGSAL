using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class FinancialMovementTypeDTO
    {
        private Int32 _id;              //id
        private String _movimentType;   //tipo movimentação
        private String _type;           //tipo

        public int Id { get => _id; set => _id = value; }
        public string MovimentType { get => _movimentType; set => _movimentType = value; }
        public string Type { get => _type; set => _type = value; }
    }
}
