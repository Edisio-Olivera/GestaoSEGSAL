using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class BaseClientDTO
    {
        private Int32 _id;
        private String _code;
        private DateTime _dateRegister;
        private String _client;
        private String _nameBase;
        private String _address;
        private String _complement;
        private String _district;
        private String _city;
        private String _faderationState;
        private String _postalCode;
        private String _cnpj;
        private String _ie;
        private String _ativityBranch;
        private String _activity;
        private String _telephone;
        private String _email;
        private String _site;
        private String _status;

        public int Id { get => _id; set => _id = value; }
        public string Code { get => _code; set => _code = value; }
        public DateTime DateRegister { get => _dateRegister; set => _dateRegister = value; }
        public string Client { get => _client; set => _client = value; }
        public string NameBase { get => _nameBase; set => _nameBase = value; }
        public string Address { get => _address; set => _address = value; }
        public string Complement { get => _complement; set => _complement = value; }
        public string District { get => _district; set => _district = value; }
        public string City { get => _city; set => _city = value; }
        public string FaderationState { get => _faderationState; set => _faderationState = value; }
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        public string Cnpj { get => _cnpj; set => _cnpj = value; }
        public string Ie { get => _ie; set => _ie = value; }
        public string AtivityBranch { get => _ativityBranch; set => _ativityBranch = value; }
        public string Activity { get => _activity; set => _activity = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }
        public string Email { get => _email; set => _email = value; }
        public string Site { get => _site; set => _site = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
