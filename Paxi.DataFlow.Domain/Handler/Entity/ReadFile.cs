using MediatR;
using Paxi.DataFlow.Domain.Entity.Base;

namespace Paxi.DataFlow.Domain.Handler.Entity
{
    public class ReadFile : EntityHandleBase, IRequest<bool>
    {
        public string Path { get; set; }
        public string Name { get; set; }
    }
}
