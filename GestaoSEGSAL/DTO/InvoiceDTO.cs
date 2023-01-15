using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class InvoiceDTO
    {
        private Int32 _id;
        private String _numberInvoice;
        private DateTime _issuanceDate;
        private DateTime _forecastDate;
        private String _invoiceType;
        private String _competence;
        private String _verificationCode;
        private String _client;
        private String _baseClient;
        private String _service;
        private String _requestNumber;
        private Int32 _amount;
        private String _file;
        private String _status;
        private String _monthIssuanceDate;
        private String _yearIssuanceDate;

        public int Id { get => _id; set => _id = value; }
        public string NumberInvoice { get => _numberInvoice; set => _numberInvoice = value; }
        public DateTime IssuanceDate { get => _issuanceDate; set => _issuanceDate = value; }
        public DateTime ForecastDate { get => _forecastDate; set => _forecastDate = value; }
        public string InvoiceType { get => _invoiceType; set => _invoiceType = value; }
        public string Competence { get => _competence; set => _competence = value; }
        public string VerificationCode { get => _verificationCode; set => _verificationCode = value; }
        public string Client { get => _client; set => _client = value; }
        public string BaseClient { get => _baseClient; set => _baseClient = value; }
        public string Service { get => _service; set => _service = value; }
        public string RequestNumber { get => _requestNumber; set => _requestNumber = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public string File { get => _file; set => _file = value; }
        public string Status { get => _status; set => _status = value; }
        public string MonthIssuanceDate { get => _monthIssuanceDate; set => _monthIssuanceDate = value; }
        public string YearIssuanceDate { get => _yearIssuanceDate; set => _yearIssuanceDate = value; }
    }
}
