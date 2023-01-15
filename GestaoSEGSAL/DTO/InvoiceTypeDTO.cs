using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class InvoiceTypeDTO
    {
        private Int32 _id;
        private String _InvoiceType;

        public int Id { get => _id; set => _id = value; }
        public string InvoiceType { get => _InvoiceType; set => _InvoiceType = value; }
    }
}
