using Paxi.DataFlow.Domain.Entity;
using System;
using System.Collections.Generic;

namespace Paxi.DataFlow.Test.Static
{
    public class ParameterStatic
    {
        public static IEnumerable<Parameter> GetListParameterSucess()
        {
            return new List<Parameter> {
                new Parameter {
                    Id = Guid.Parse("547315ee-564d-4280-a84b-ea4eedfb6abe"),
                    Active = true,
                    Name = "Parametro Data",
                    Value = DateTime.Parse("2019-09-20")
                },
                new Parameter
                {
                    Id = Guid.Parse("3dc30ce0-0cb9-49a8-a7b9-115a155a2e79"),
                    Active = true,
                    Name = "Parametro inteiro",
                    Value = 1
                }
            };
        }
    }
}
