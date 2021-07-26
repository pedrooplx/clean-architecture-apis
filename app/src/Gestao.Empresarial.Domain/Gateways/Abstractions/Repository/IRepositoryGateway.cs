using Gestao.Empresarial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestao.Empresarial.Domain.Gateways.Abstractions.Repository
{
    public interface IRepositoryGateway<TEntity> : IDisposable where TEntity : EntityBase
    {
        Task<IList<TEntity>> GettAll();
        Task<TEntity> GetById(Guid id);
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Remove(Guid id);
        Task<int> SaveChanges();
    }
}
