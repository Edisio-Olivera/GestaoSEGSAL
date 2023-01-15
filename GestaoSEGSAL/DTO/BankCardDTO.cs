using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class BankCardDTO
    {
        private Int32 _id;                  //id
        private DateTime _registrationDate; //data registro
        private String _typeCard;           //tipo cartão
        private String _surname;            //apelido
        private String _numberCard;         //numero
        private String _bandCard;           //bandeira
        private Int32 _duePay;              //dia vencimento
        private Int32 _bestDay;             //melhor dia
        private Int32 _totalLimit;          //limite total
        private Int32 _userLimit;           //limite utilizado
        private Int32 _avaliableLimit;      //limite disponivel
        private String _image;              //imagem
        private String _status;             //status

        public int Id { get => _id; set => _id = value; }
        public DateTime RegistrationDate { get => _registrationDate; set => _registrationDate = value; }
        public string TypeCard { get => _typeCard; set => _typeCard = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string NumberCard { get => _numberCard; set => _numberCard = value; }
        public string BandCard { get => _bandCard; set => _bandCard = value; }
        public int DuePay { get => _duePay; set => _duePay = value; }
        public int BestDay { get => _bestDay; set => _bestDay = value; }
        public int TotalLimit { get => _totalLimit; set => _totalLimit = value; }
        public int UserLimit { get => _userLimit; set => _userLimit = value; }
        public int AvaliableLimit { get => _avaliableLimit; set => _avaliableLimit = value; }
        public string Image { get => _image; set => _image = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
