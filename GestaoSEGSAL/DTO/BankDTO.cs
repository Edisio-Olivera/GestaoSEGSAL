using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class BankDTO
    {
        private Int32 _id;
        private String _bankCode;
        private String _bankName;

        public int Id { get => _id; set => _id = value; }
        public string BankCode { get => _bankCode; set => _bankCode = value; }
        public string BankName { get => _bankName; set => _bankName = value; }
    }
}
