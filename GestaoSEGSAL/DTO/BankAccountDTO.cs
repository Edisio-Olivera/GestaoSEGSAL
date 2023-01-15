using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class BankAccountDTO
    {
        private Int32 _id;                  //id
        private DateTime _registerDate;     //data registro
        private String _bankAccountName;    //nome conta
        private String _bankName;               //banco
        private String _bankAccountType;    //tipo conta
        private String _agencyNumber;       //numero agencia
        private String _accountNumber;      //numero conta
        private Int32 _balance;             //saldo
        private String _status;             //status

        public int Id { get => _id; set => _id = value; }
        public DateTime RegisterDate { get => _registerDate; set => _registerDate = value; }
        public string BankName { get => _bankName; set => _bankName = value; }
        public string BankAccountType { get => _bankAccountType; set => _bankAccountType = value; }
        public string AgencyNumber { get => _agencyNumber; set => _agencyNumber = value; }
        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public int Balance { get => _balance; set => _balance = value; }
        public string Status { get => _status; set => _status = value; }
        public string BankAccountName { get => _bankAccountName; set => _bankAccountName = value; }
    }
}
