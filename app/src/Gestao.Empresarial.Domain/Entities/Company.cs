using System;
using System.Collections.Generic;
using System.Text;

namespace Gestao.Empresarial.Domain.Entities
{
    public class Company : Entity
    {
        public string CorporateName { get; set; }
        public string CNPJ { get; set; }
        public string CEP { get; set; }
        public string Address { get; set; }
        public string AddressNum { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Site { get; set; }
    }
}
