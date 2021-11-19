using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatorPatternLib.DataAccess;
using MediatorPatternLib.Models;
using MediatorPatternLib.Queries;
using MediatR;

namespace MediatorPatternLib.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private readonly IDataAccess data;

        public GetPersonByIdHandler(IDataAccess data) => this.data = data;

        public Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(data.GetPeople().FirstOrDefault(x => x.Id == request.Id));
        }
    }
}