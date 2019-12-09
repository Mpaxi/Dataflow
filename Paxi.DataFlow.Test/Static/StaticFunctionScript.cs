using Paxi.DataFlow.Domain.Entity;
using Paxi.DataFlow.Domain.Handler.Entity;
using System;
using System.Collections.Generic;

namespace Paxi.DataFlow.Test.Static
{
    public class StaticFunctionScript
    {
        public static FunctionScript GetFunctionScriptSucess()
        {
            return new FunctionScript
            {
                Id = Guid.Parse("b5448235-3efe-4ec5-900a-4740a31f2872"),
                Active = true,
                Expression = new WriteFile { Path = "C:\tmp", Entry = new List<int> { 1, 2, 3 } },
                ChildFunctions = new List<FunctionScript> {
                    new FunctionScript {
                        Id = Guid.Parse("b5448235-3efe-4ec5-900a-4740a31f2872"),
                        Active = true,
                        Expression = new WriteFile { Path = "C:\tmp", Entry = new List<int> {1,2,3 } },
                        Name = "Sub Função 1 Sucesso",
                        Private = false
                    },
                    new FunctionScript {
                        Id = Guid.Parse("b5448235-3efe-4ec5-900a-4740a31f2872"),
                        Active = true,
                        Expression = new WriteFile { Path = "C:\tmp", Entry = new List<int> {1,2,3 } },
                        Name = "Sub Função 2 Sucesso",
                        Private = false
                    }
                },
                Name = "Função 1 Sucesso",
                Private = false
            };
        }
    }
}
