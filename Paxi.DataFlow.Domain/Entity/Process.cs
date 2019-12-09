using Paxi.DataFlow.Domain.Entity.Base;
using System.Collections.Generic;

namespace Paxi.DataFlow.Domain.Entity
{
    public class Process : EntityBase
    {
        public IEnumerable<Parameter> Paramters { get; set; }
        public FunctionScript FunctionScript { get; set; }

        public IEnumerable<Process> ChildProcess { get; set; }
    }
}
