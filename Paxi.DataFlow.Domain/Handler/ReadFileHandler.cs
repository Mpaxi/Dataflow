using MediatR;
using Paxi.DataFlow.Domain.Contract;
using Paxi.DataFlow.Domain.Entity;
using Paxi.DataFlow.Domain.Handler.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace Paxi.DataFlow.Domain.Handler
{
    public class ReadFileHandler : IRequestHandler<ReadFile, bool>
    {
        private readonly IFileRepository _fileRepository;
        public ReadFileHandler(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }
        public async Task<bool> Handle(ReadFile request, CancellationToken cancellationToken)
        {
            var ret = await _fileRepository.ReadFile(new Parameter(), $@"{request.Path}\{request.Name}");
            return true;
        }
    }
}
