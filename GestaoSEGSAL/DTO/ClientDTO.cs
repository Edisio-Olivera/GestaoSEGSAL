using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class ClientDTO
    {
        private Int32 _id;
        private String _codeClient;
        private String _typeClient;
        private DateTime _dateRegister;
        private String _socialReason;
        private String _fantasyName;
        private String _image;
        private String _statusClient;
        private DateTime _customerSincce;

        public int Id { get => _id; set => _id = value; }
        public string Code { get => _codeClient; set => _codeClient = value; }
        public string TypeClient { get => _typeClient; set => _typeClient = value; }
        public DateTime DateRegister { get => _dateRegister; set => _dateRegister = value; }
        public string SocialReason { get => _socialReason; set => _socialReason = value; }
        public string FantasyName { get => _fantasyName; set => _fantasyName = value; }
        public string Image { get => _image; set => _image = value; }
        public string Status { get => _statusClient; set => _statusClient = value; }
        public DateTime CustomerSincce { get => _customerSincce; set => _customerSincce = value; }
    }
}
