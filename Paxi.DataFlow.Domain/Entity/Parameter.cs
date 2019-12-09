using Paxi.DataFlow.Domain.Entity.Base;

namespace Paxi.DataFlow.Domain.Entity
{
    public class Parameter : EntityBase
    {
        public string Name { get; set; }
        public dynamic Value { get; set; }
    }
}
