using Gestao.Empresarial.Domain.Entities;
using Gestao.Empresarial.Domain.Gateways.Abstractions.Repository;
using Gestao.Empresarial.Infrastructure.DataProviders.Repositories.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestao.Empresarial.Infrastructure.DataProviders.Repositories.Abstractions
{
    public abstract class RepositoryBase<TEntity> : IRepositoryGateway<TEntity> where TEntity : EntityBase, new()
    {
        protected readonly ApplicationDbContext context;
        protected readonly DbSet<TEntity> DbSet;

        protected RepositoryBase(ApplicationDbContext context)
        {
            this.context = context;
            DbSet = context.Set<TEntity>();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<IList<TEntity>> GettAll()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public async Task Create(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public async Task Update(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public async Task Remove(Guid id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context?.Dispose();
        }
    }
}
