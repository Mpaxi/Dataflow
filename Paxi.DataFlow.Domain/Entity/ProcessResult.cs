using System;
using System.Collections.Generic;

namespace Paxi.DataFlow.Domain.Entity
{
    public class ProcessResult
    {
        public Guid Id { get; set; }
        public object Result { get; set; }
        public List<ProcessResult> ChildResult { get; set; } = new List<ProcessResult>();
    }
}
