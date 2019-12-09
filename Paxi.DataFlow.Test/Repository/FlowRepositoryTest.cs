using Paxi.DataFlow.Domain.Contract;
using Paxi.DataFlow.Domain.Entity;
using Paxi.DataFlow.Test.Static;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Paxi.DataFlow.Test.Repository
{
    public class FlowRepositoryTest
    {
        private readonly IFlowRepository flowRepository;
        public FlowRepositoryTest()
        {
            flowRepository = (IFlowRepository)MockStatic.GetMock();
        }
        [Fact]
        public async Task Add_Flow_Sucess()
        {
            var xxxx = Guid.NewGuid().ToString();
            var assets = await flowRepository.AddAsync(new Flow());

            Assert.True(assets);
        }
    }
}
