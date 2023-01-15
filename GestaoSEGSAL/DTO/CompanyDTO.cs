using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoSEGSAL.DTO
{
    class CompanyDTO
    {
        private Int32 _id;
        private String _socialReason;
        private String _fantasyName;
        private String _port;
        private DateTime _openDate;
        private String _cnpj;
        private String _stateRegistration;
        private String _cityRegistration;
        private String _legalNature;
        private String _address;
        private String _complement;
        private String _district;
        private String _city;
        private String _federationState;
        private String _postalCode;
        private String _email;
        private String _password;
        private String _telephone;
        private String _mainActivity;
        private String _logo;
        private String _logoPrint;

        public int Id { get => _id; set => _id = value; }
        public string SocialReason { get => _socialReason; set => _socialReason = value; }
        public string FantasyName { get => _fantasyName; set => _fantasyName = value; }
        public string Port { get => _port; set => _port = value; }
        public DateTime OpenDate { get => _openDate; set => _openDate = value; }
        public string Cnpj { get => _cnpj; set => _cnpj = value; }
        public string StateRegistration { get => _stateRegistration; set => _stateRegistration = value; }
        public string CityRegistration { get => _cityRegistration; set => _cityRegistration = value; }
        public string LegalNature { get => _legalNature; set => _legalNature = value; }
        public string Address { get => _address; set => _address = value; }
        public string Complement { get => _complement; set => _complement = value; }
        public string District { get => _district; set => _district = value; }
        public string City { get => _city; set => _city = value; }
        public string FederationState { get => _federationState; set => _federationState = value; }
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }
        public string MainActivity { get => _mainActivity; set => _mainActivity = value; }
        public string Logo { get => _logo; set => _logo = value; }
        public string LogoPrint { get => _logoPrint; set => _logoPrint = value; }
    }
}
