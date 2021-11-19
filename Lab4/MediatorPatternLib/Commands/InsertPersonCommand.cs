using MediatorPatternLib.Models;
using MediatR;

namespace MediatorPatternLib.Commands
{
    public class InsertPersonCommand : IRequest<PersonModel>
    {
        public string FirstName { get; }
        public string LastName { get; }

        public InsertPersonCommand(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
