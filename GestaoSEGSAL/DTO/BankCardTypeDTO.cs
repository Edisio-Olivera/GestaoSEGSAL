using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class BankCardTypeDTO
    {
        private Int32 _id;          //id
        private String _typeCard;   //tipo cartão

        public int Id { get => _id; set => _id = value; }
        public string TypeCard { get => _typeCard; set => _typeCard = value; }
    }
}
