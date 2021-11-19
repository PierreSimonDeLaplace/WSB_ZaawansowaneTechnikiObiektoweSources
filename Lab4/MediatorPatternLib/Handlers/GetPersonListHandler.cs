using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatorPatternLib.DataAccess;
using MediatorPatternLib.Models;
using MediatorPatternLib.Queries;
using MediatR;

namespace MediatorPatternLib.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        private readonly IDataAccess data;

        public GetPersonListHandler(IDataAccess data) => this.data = data;

        public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            // FromResult take synchronous call and turns it into an asynchronous 
            return Task.FromResult(data.GetPeople());
        }
    }
}
