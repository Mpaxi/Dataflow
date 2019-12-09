using System.Collections.Generic;
using System.Threading.Tasks;

namespace Paxi.DataFlow.Domain.Contract
{
    public interface IFileRepository
    {
        Task<bool> WriteFile(dynamic records, string path);

        Task<IEnumerable<T>> ReadFile<T>(T entity, string path);
    }
}
