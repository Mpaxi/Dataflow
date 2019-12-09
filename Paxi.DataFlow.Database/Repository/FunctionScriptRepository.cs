using Paxi.DataFlow.Domain.Contract;
using Paxi.DataFlow.Domain.Entity;
using Paxi.DataFlow.Domain.Handler.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Paxi.DataFlow.Database.Repository
{
    public class FunctionScriptRepository : IFunctionScriptRepository
    {
        public Task<bool> AddAsync(FunctionScript Entity, bool SaveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddRangeAsync(IEnumerable<FunctionScript> Entity, bool SaveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(FunctionScript Entity, bool SaveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRangeAsync(IEnumerable<FunctionScript> Entity, bool SaveChanges = false)
        {
            throw new NotImplementedException();
        }

        public async Task<FunctionScript> GetAsync(Expression<Func<FunctionScript, bool>> predicate, bool NoLock = true, params Expression<Func<FunctionScript, object>>[] includeProperties)
        {
            return new FunctionScript
            {
                Id = Guid.Parse("b5448235-3efe-4ec5-900a-4740a31f2872"),
                Active = true,
                Expression = new WriteFile { Path = "C:\\tmp", Name = "Cleiton.csv", Entry = new List<Parameter> { new Parameter { Name = "Clieton", Value = 1 } } },
                ChildFunctions = new List<FunctionScript> {
                    new FunctionScript {
                        Id = Guid.Parse("b5448235-3efe-4ec5-900a-4740a31f2872"),
                        Active = true,
                        Expression = new ReadFile { Path = "C:\\tmp", Name = "Cleiton.csv", Entry = new List<int> {1,2,3 } },
                        Name = "Sub Função 1 Sucesso",
                        Private = false
                    },
                    new FunctionScript {
                        Id = Guid.Parse("b5448235-3efe-4ec5-900a-4740a31f2872"),
                        Active = true,
                        Expression = new WriteFile { Path = "C:\\tmp", Name = "Cleiton.csv", Entry = new List<int> {1,2,3 } },
                        Name = "Sub Função 2 Sucesso",
                        Private = false
                    }
                },
                Name = "Função 1 Sucesso",
                Private = false
            };
        }

        public Task<IQueryable<FunctionScript>> GetWhereAsync(Expression<Func<FunctionScript, bool>> predicate, bool NoLock = true, params Expression<Func<FunctionScript, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(FunctionScript Entity, bool SaveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRangAsync(IEnumerable<FunctionScript> Entity, bool SaveChanges = false)
        {
            throw new NotImplementedException();
        }
    }
}
