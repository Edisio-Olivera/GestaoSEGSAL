using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class PaymentTermsDTO
    {
        private Int32 _id;
        private String _paymentTerms;

        public int Id { get => _id; set => _id = value; }
        public string PaymentTerms { get => _paymentTerms; set => _paymentTerms = value; }
    }
}
