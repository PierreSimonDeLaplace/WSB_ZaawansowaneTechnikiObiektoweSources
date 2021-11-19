using System.Collections.Generic;
using MediatorPatternLib.Models;

namespace MediatorPatternLib.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}