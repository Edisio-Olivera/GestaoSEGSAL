using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class BussinessProposalServiceDTO
    {
        private Int32 _id;
        private String _numberProposal;
        private Int32 _quantity;
        private String _serviceType;
        private String _service;
        private Int32 _unitityValue;
        private Int32 _amount;

        public int Id { get => _id; set => _id = value; }
        public string NumberProposal { get => _numberProposal; set => _numberProposal = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public string ServiceType { get => _serviceType; set => _serviceType = value; }
        public string Service { get => _service; set => _service = value; }
        public int UnitityValue { get => _unitityValue; set => _unitityValue = value; }
        public int Amount { get => _amount; set => _amount = value; }
    }
}
