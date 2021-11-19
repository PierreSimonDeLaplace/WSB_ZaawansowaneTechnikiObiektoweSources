using System.Threading;
using System.Threading.Tasks;
using MediatorPatternLib.Commands;
using MediatorPatternLib.DataAccess;
using MediatorPatternLib.Models;
using MediatR;

namespace MediatorPatternLib.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IDataAccess data;

        public InsertPersonHandler(IDataAccess data) => this.data = data;

        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(data.InsertPerson(request.FirstName, request.LastName));
        }
    }
}
