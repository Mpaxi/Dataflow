using CsvHelper;
using Paxi.DataFlow.Domain.Contract;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Paxi.DataFlow.File.Repository
{
    public class FileRepository : IFileRepository
    {
        public async Task<IEnumerable<T>> ReadFile<T>(T entity, string path)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader))
            {
                var records = csv.GetRecords<T>();
                return records;
            }


        }

        public async Task<bool> WriteFile(dynamic records, string path)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(records);
            }

            return true;
        }
    }
}
