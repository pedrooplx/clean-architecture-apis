using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Empresarial.Application.Models.CompanyModels
{
    public class CreateCompanyRequest
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
