using Paxi.DataFlow.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Paxi.DataFlow.Domain.Contract
{
    public interface IProcessDomain
    {
        Task<ProcessResult> RunProcess(Guid UserId, Guid ProcessId, IEnumerable<Parameter> Paramters);
    }
}
