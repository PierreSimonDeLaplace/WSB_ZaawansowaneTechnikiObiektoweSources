using MediatorPatternLib.Models;
using MediatR;

namespace MediatorPatternLib.Queries
{
    // - an '*Query' at the end beacuse of convention
    // - every query have ONE and only ONE handler
    public class GetPersonByIdQuery : IRequest<PersonModel>
    {
        public int Id { get; }

        public GetPersonByIdQuery(int Id) => this.Id = Id;
    }
}
