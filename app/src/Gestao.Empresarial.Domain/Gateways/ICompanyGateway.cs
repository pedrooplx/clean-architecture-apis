using Gestao.Empresarial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestao.Empresarial.Domain.Interfaces.Repositories
{
    public interface ICompanyGateway
    {
        IEnumerable<Company> GetCompanies();
        Company GetCompanyById(Guid Id);
        Company CreateCompany(Company company);
    }
}
