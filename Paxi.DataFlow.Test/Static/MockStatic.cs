using NSubstitute;
using Paxi.DataFlow.Domain.Contract;
using Paxi.DataFlow.Domain.Entity;
using System;
using System.Linq.Expressions;

namespace Paxi.DataFlow.Test.Static
{
    public static class MockStatic
    {
        public static object GetMock()
        {
            object mockContainer = Substitute.For(new[] { typeof(IFlowRepository), typeof(IFunctionScriptRepository) }, null);

            ((IFlowRepository)mockContainer).AddAsync(Arg.Any<Flow>()).Returns(true);
            ((IFunctionScriptRepository)mockContainer).AddAsync(Arg.Any<FunctionScript>()).Returns(true);
            ((IFunctionScriptRepository)mockContainer).GetAsync(Arg.Any<Expression<Func<FunctionScript, bool>>>(), Arg.Any<bool>(), Arg.Any<Expression<Func<FunctionScript, object>>[]>()).Returns(StaticFunctionScript.GetFunctionScriptSucess());

            return mockContainer;
        }
    }
}
