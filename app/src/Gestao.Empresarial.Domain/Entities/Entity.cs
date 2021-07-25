using System;
using System.Collections.Generic;
using System.Text;

namespace Gestao.Empresarial.Domain.Entities
{
    public abstract class Entity : Auditory
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }

    public abstract class Auditory
    {
        public Guid CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime Modified { get; set; }
    }
}
