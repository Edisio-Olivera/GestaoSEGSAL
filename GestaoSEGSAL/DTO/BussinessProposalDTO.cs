using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class BussinessProposalDTO
    {
        private Int32 _id;
        private String _codeProposal;
        private DateTime _dateProposal;
        private String _title;
        private String _description;
        private String _observation;
        private String _client;
        private String _baseClient;
        private Int32 _amount;
        private String _paymentTerms;
        private String _paymentForm;
        private String _invoice;
        private String _statusBussinesProposal;

        public int Id { get => _id; set => _id = value; }
        public string NumberProposal { get => _codeProposal; set => _codeProposal = value; }
        public DateTime DateProposal { get => _dateProposal; set => _dateProposal = value; }
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public string Observation { get => _observation; set => _observation = value; }
        public string Client { get => _client; set => _client = value; }
        public string BaseClient { get => _baseClient; set => _baseClient = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public string PaymentForm { get => _paymentForm; set => _paymentForm = value; }
        public string Invoice { get => _invoice; set => _invoice = value; }
        public string Status { get => _statusBussinesProposal; set => _statusBussinesProposal = value; }
        public string PaymentTerms { get => _paymentTerms; set => _paymentTerms = value; }
    }
}
