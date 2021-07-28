using Gestao.Empresarial.Domain.Entities;
using Gestao.Empresarial.Infrastructure.DataProviders.Repositories.Extentions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gestao.Empresarial.Infrastructure.DataProviders.Repositories.Data
{
    public class ApplicationDbContext : DbContext
    {
        public Guid LoggedUserId { get; set; }
        //public ApplicationDbContext(DbContextOptions options, Guid loggedUserId) : base(options)
        //{
        //    this.LoggedUserId = loggedUserId;
        //}
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            //this.ConfigureAuditoryProperty();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //this.ConfigureAuditoryProperty();
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
