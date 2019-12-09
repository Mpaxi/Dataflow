using System;

namespace Paxi.DataFlow.Domain.Entity.Base
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime Created { get; private set; } = DateTime.Now;
        public DateTime? Updated { get; set; }
        public bool Active { get; set; }
    }
}
