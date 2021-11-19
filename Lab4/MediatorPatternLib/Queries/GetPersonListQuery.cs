using System.Collections.Generic;
using MediatorPatternLib.Models;
using MediatR;

namespace MediatorPatternLib.Queries
{
    public class GetPersonListQuery : IRequest<List<PersonModel>>
    {
    }
}
