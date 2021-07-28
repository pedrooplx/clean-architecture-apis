using System;

namespace Gestao.Empresarial.Application.Models.CompanyModels
{
    public class GetCompanyByIdResponse
    {
        public Guid Id { get; set; }
        public string CorporateName { get; set; }
        public int CNPJ { get; set; }
        public int CEP { get; set; }
        public string Address { get; set; }
    }
}
