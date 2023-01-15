using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class PaymentFormDTO
    {
        private Int32 _id;
        private String _paymentTerms;
        private String _paymentForm;

        public int Id { get => _id; set => _id = value; }
        public string PaymentTerms { get => _paymentTerms; set => _paymentTerms = value; }
        public string PaymentForm { get => _paymentForm; set => _paymentForm = value; }
    }
}
