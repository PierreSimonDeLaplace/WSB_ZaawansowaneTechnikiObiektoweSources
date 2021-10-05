using System;
using System.Collections.Generic;

namespace InterfaceSegregationPrinciple
{
    public interface IPersistence
    {
        IEnumerable<Entity> GetAll();
        Entity GetByID(Guid identity);
        IEnumerable<Entity> FindByCriteria(string criteria);
        void Save(Entity entity);
        void Delete(Entity entity);
    }
}