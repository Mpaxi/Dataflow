using MediatR;
using Paxi.DataFlow.Domain.Contract;
using Paxi.DataFlow.Domain.Implementation;
using Paxi.DataFlow.Test.Static;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Paxi.DataFlow.Test.Domain
{
    public class ProcessDomainTest
    {
        private readonly IProcessDomain _processDomain;
        private readonly IMediator _mediator;
        public ProcessDomainTest()
        {
            _processDomain = new ProcessDomain((IFunctionScriptRepository)MockStatic.GetMock(), _mediator);
        }

        [Fact]
        public async Task RunProcess_Sucess()
        {

            var assets = await _processDomain.RunProcess(Guid.NewGuid(), Guid.NewGuid(), null);

            Assert.NotNull(assets);
        }
    }
}
