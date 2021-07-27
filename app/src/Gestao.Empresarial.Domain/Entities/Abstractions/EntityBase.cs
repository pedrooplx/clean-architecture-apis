using System;
using System.Collections.Generic;
using System.Text;

namespace Gestao.Empresarial.Domain.Entities
{
    public abstract class EntityBase : IAuditory
    {
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime Modified { get; set; }

        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }
    }

    public interface IAuditory
    {
        Guid CreatedBy { get; set; }
        DateTime Created { get; set; }
        Guid ModifiedBy { get; set; }
        DateTime Modified { get; set; }
    }
}
