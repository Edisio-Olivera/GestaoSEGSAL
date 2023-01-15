using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class BankCardBandDTO
    {
        private Int32 _id;          //id
        private String _bandCard;   //tipo cartão
        private String _image;      //imagem

        public int Id { get => _id; set => _id = value; }
        public string BandCard { get => _bandCard; set => _bandCard = value; }
        public string Image { get => _image; set => _image = value; }
    }
}
