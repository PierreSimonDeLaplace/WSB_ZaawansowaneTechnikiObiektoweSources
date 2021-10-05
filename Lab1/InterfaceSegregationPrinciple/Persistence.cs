using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using NHibernate;

// Split the interface as well as Persitence class so that they meet the priciple of interface segregation principle based on:
// https://pierresimondelaplace.gitlab.io/wsb-zaawansowane-techniki-obiektowe/WSB_ZaawansowaneTechnikiObiektowe.pdf

namespace InterfaceSegregationPrinciple
{
    public class Persistence : IPersistence
	{
		private readonly ISession session;
		private readonly MongoDatabase mongo;

		public Persistence(ISession session, MongoDatabase mongo)
		{
			this.session = session;
			this.mongo = mongo;
		}

        public IEnumerable<Entity> GetAll() => mongo.GetCollection<Entity>("entities").FindAll();

        public Entity GetByID(Guid identity)
		{
			return mongo.GetCollection<Entity>
			("entities").FindOneById(identity.ToBson());
		}

		public IEnumerable<Entity> FindByCriteria(string criteria)
		{
			var query = BsonSerializer.Deserialize<QueryDocument>
			(criteria);
			return mongo.GetCollection<Entity>("entities").Find(query);
		}

		public void Save(Entity entity)
		{
			using (var transaction = session.BeginTransaction())
			{
				session.Save(entity);
				transaction.Commit();
			}
		}

		public void Delete(Entity entity)
		{
			using (var transaction = session.BeginTransaction())
			{
				session.Delete(entity);
				transaction.Commit();
			}
		}
	}
}
