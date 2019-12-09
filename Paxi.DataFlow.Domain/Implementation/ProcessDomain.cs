using MediatR;
using Paxi.DataFlow.Domain.Contract;
using Paxi.DataFlow.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Paxi.DataFlow.Domain.Implementation
{
    public class ProcessDomain : IProcessDomain
    {
        private readonly IFunctionScriptRepository _functionScriptRepository;
        private readonly IMediator _mediator;
        public ProcessDomain(IFunctionScriptRepository functionScriptRepository, IMediator mediator)
        {
            _functionScriptRepository = functionScriptRepository;
            _mediator = mediator;
        }
        public async Task<ProcessResult> RunProcess(Guid UserId, Guid ProcessId, IEnumerable<Parameter> Paramters)
        {
            try
            {
                var function = await _functionScriptRepository.GetAsync(w => w.Id.Equals(ProcessId));
                var result = await RunFunction(function);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private async Task<ProcessResult> RunFunction(FunctionScript function)
        {
            ProcessResult processResult = new ProcessResult();
            processResult.Id = function.Id;

            var ret = await _mediator.Send(function.Expression);

            foreach (var childFunction in function.ChildFunctions)
            {
                processResult.ChildResult.Add(await RunFunction(childFunction));

            }

            return processResult;

        }
    }
}
