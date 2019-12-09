using MediatR;
using Paxi.DataFlow.Domain.Contract;
using Paxi.DataFlow.Domain.Handler.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace Paxi.DataFlow.Domain.Handler
{
    public class WriteFileHandler : IRequestHandler<WriteFile, bool>
    {
        private readonly IFileRepository _fileRepository;
        public WriteFileHandler(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }
        public async Task<bool> Handle(WriteFile request, CancellationToken cancellationToken)
        {
            var ret = await _fileRepository.WriteFile(request.Entry, $@"{request.Path}\{request.Name}");
            return true;
        }
    }
}
