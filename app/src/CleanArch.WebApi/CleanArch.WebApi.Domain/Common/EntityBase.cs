using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.WebApi.Domain.Common
{
    public abstract class EntityBase : IAuditory
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime Modified { get; set; }
    }

    public interface IAuditory
    {
        Guid CreatedBy { get; set; }
        DateTime Created { get; set; }
        Guid ModifiedBy { get; set; }
        DateTime Modified { get; set; }
    }
}
