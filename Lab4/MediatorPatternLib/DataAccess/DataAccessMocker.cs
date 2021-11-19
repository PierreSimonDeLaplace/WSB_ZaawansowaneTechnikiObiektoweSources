using System.Collections.Generic;
using System.Linq;
using MediatorPatternLib.Models;

namespace MediatorPatternLib.DataAccess
{
    // IDataAccess instead of IDemoDataAccess beacuse in future 
    // one may want to change demo one to more specific that 
    // can do real job

    public class DataAccessMocker : IDataAccess
    {
        private readonly List<PersonModel> people = new List<PersonModel>();

        public DataAccessMocker()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Joey", LastName = "Tribbiani" });
            people.Add(new PersonModel { Id = 2, FirstName = "Monica", LastName = "Geller" });
        }

        public List<PersonModel> GetPeople() => people; // one can use SQL database in this place instead of List<T>

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new PersonModel() 
            { 
                FirstName = firstName, 
                LastName = lastName 
            };

            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);

            return p; //return model beacuse, client may want to see the new PersonModel with the Id value
        }
    }
}
