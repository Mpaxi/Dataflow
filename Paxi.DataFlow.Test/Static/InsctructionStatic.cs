using Paxi.DataFlow.Domain.Entity;
using System;

namespace Paxi.DataFlow.Test.Static
{
    public class InsctructionStatic
    {
        public static Process GetInsctructionSucess()
        {
            return new Process { Id = Guid.Parse("320e930a-0eeb-4fa7-942d-501c25258ef9"), Active = true, FunctionScript = StaticFunctionScript.GetFunctionScriptSucess(), Paramters = ParameterStatic.GetListParameterSucess() };
        }
    }
}
