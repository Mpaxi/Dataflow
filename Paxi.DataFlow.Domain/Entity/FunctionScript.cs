using Paxi.DataFlow.Domain.Entity.Base;
using System.Collections.Generic;

namespace Paxi.DataFlow.Domain.Entity
{
    public class FunctionScript : EntityBase
    {
        public string Name { get; set; }
        public dynamic Expression { get; set; }
        public object Entry { get; set; }
        public bool Private { get; set; }
        public IEnumerable<ParamterMap> ParametersMap { get; set; }
        public IEnumerable<FunctionScript> ChildFunctions { get; set; } = new List<FunctionScript>();

    }
}
