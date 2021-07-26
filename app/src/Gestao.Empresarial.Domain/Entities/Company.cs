using System;
using System.Collections.Generic;
using System.Text;

namespace Gestao.Empresarial.Domain.Entities
{
    public class Company : EntityBase
    {
        public string CorporateName { get; set; }
        public int CNPJ { get; set; }
        public int CEP { get; set; }
        public string Address { get; set; }
        public int AddressNumber { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Site { get; set; }
    }
}
