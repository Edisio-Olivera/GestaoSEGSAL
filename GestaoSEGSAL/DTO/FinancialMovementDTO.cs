using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class FinancialMovementDTO
    {
        private Int32 _id;                      //id
        private DateTime _registerDate;         //data registro movimentação
        private String _movimentType;           //tipo movimentação
        private String _providerClient;         //fornecedor ou cliente
        private DateTime _movimentDate;         //data transação
        private String _description;            //descrição
        private String _paymentTerms;           //condição pagamento
        private String _paymentForm;            //forma pagamento
        private String _bankAccount;            //conta
        private Int32 _amount;                  //valor total
        private Int32 _quantityInstallments;    //quantidade parcelas
        private Int32 _installmentNumber;       //numero parcela
        private Int32 _installmentValue;        //valor parcela
        private DateTime _dueDate;              //data vencimento
        private DateTime _paymentDate;          //data pagamento
        private Int32 _interestAmount;          //valor juros
        private Int32 _amountPaid;              //valor pago
        private String _status;                 //status

        public int Id { get => _id; set => _id = value; }
        public DateTime RegisterDate { get => _registerDate; set => _registerDate = value; }
        public string MovimentType { get => _movimentType; set => _movimentType = value; }
        public string ProviderClient { get => _providerClient; set => _providerClient = value; }
        public DateTime MovimentDate { get => _movimentDate; set => _movimentDate = value; }
        public string Description { get => _description; set => _description = value; }
        public string PaymentTerms { get => _paymentTerms; set => _paymentTerms = value; }
        public string PaymentForm { get => _paymentForm; set => _paymentForm = value; }
        public string BankAccount { get => _bankAccount; set => _bankAccount = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public int QuantityInstallments { get => _quantityInstallments; set => _quantityInstallments = value; }
        public int InstallmentNumber { get => _installmentNumber; set => _installmentNumber = value; }
        public int InstallmentValue { get => _installmentValue; set => _installmentValue = value; }
        public DateTime DueDate { get => _dueDate; set => _dueDate = value; }
        public DateTime PaymentDate { get => _paymentDate; set => _paymentDate = value; }
        public int InterestAmount { get => _interestAmount; set => _interestAmount = value; }
        public int AmountPaid { get => _amountPaid; set => _amountPaid = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
