using Paxi.DataFlow.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Paxi.DataFlow.Domain.Contract
{
    public interface IFunctionScriptDomain
    {
        Task<IEnumerable<FunctionScript>> GetFunctions(Guid UserId);

    }
}
