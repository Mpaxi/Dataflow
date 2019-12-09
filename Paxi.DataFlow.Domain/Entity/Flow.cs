using Paxi.DataFlow.Domain.Entity.Base;
using System.Collections.Generic;

namespace Paxi.DataFlow.Domain.Entity
{
    public class Flow : EntityBase
    {
        public string Name { get; set; }
        public dynamic Function { get; set; }
        public IEnumerable<Flow> Flows { get; set; }
        public IEnumerable<Process> Insctructions { get; set; }
    }
}
