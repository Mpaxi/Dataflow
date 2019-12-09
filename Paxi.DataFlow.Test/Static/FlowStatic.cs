using Paxi.DataFlow.Domain.Entity;
using System;

namespace Paxi.DataFlow.Test.Static
{
    public class FlowStatic
    {
        public static Flow GetFlowSucess()
        {
            return new Flow { Id = Guid.Parse("320e930a-0eeb-4fa7-942d-501c25258ef9"), Active = true, Name = "Fluxo Sucesso", Insctructions = null };
        }
    }
}
