using Gestao.Empresarial.Domain.Entities;
using Gestao.Empresarial.Domain.Interfaces.Repositories;
using Gestao.Empresarial.Infrastructure.DataProviders.Repositories.Abstractions;
using Gestao.Empresarial.Infrastructure.DataProviders.Repositories.Data;
using System;
using System.Collections.Generic;

namespace Gestao.Empresarial.Infrastructure.Persistence.Repositories
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyGateway
    {
        public CompanyRepository(ApplicationDbContext context) : base(context) { }



    }
}
