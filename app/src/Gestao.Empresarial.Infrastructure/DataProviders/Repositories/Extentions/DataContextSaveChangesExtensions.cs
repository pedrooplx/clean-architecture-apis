using Gestao.Empresarial.Domain.Entities;
using Gestao.Empresarial.Infrastructure.DataProviders.Repositories.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Empresarial.Infrastructure.DataProviders.Repositories.Extentions
{
    public static class DataContextSaveChangesExtensions
    {
        public static void ConfigureAuditoryProperty(this ApplicationDbContext context)
        {
            context.ChangeTracker.DetectChanges();

            var addedEntities = context.ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Added)
                    .Select(e => e.Entity)
                    .ToArray();

            foreach (var entity in addedEntities)
            {
                if (entity is IAuditory)
                {
                    var track = entity as IAuditory;
                    track.Created = DateTime.UtcNow;
                    track.CreatedBy = context.LoggedUserId;
                }
            }

            var modifiedEntities = context.ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Modified)
                    .Select(e => e.Entity)
                    .ToArray();

            foreach (var entity in modifiedEntities)
            {
                if (entity is IAuditory)
                {
                    var track = entity as IAuditory;
                    track.Modified = DateTime.UtcNow;
                    track.ModifiedBy = context.LoggedUserId;
                }
            }
        }
    }
}
