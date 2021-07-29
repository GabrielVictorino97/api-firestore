using Domain.Model.v1.Teste;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Queries.v1.Teste
{
    public class TestQueryHandler : IRequestHandler<RequestTest, string>
    {
        public Task<string> Handle(RequestTest request, CancellationToken cancellationToken)
        {
            return Task.FromResult<string>("Olá mundo!!");
        }
    }
}
