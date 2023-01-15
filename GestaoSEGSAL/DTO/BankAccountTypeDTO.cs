using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class BankAccountTypeDTO
    {
        private Int32 _id;
        private String _bankAccountType;

        public int Id { get => _id; set => _id = value; }
        public string BankAccountType { get => _bankAccountType; set => _bankAccountType = value; }
    }
}
