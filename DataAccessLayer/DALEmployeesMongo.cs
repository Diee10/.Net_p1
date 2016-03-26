using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson.Serialization;

namespace DataAccessLayer
{
    public class DALEmployeesMongo : IDALEmployees
    {
        MongoClient client;
        IMongoDatabase database;
        IMongoCollection<Employee> collection;

        public DALEmployeesMongo()
        {
            BsonClassMap.RegisterClassMap<Employee>(cm =>
            {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
                cm.SetIsRootClass(true);
            });

            BsonClassMap.RegisterClassMap<PartTimeEmployee>(cm =>
            {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
            });

            BsonClassMap.RegisterClassMap<FullTimeEmployee>(cm =>
            {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
            });
            client      = new MongoClient("mongodb://localhost");
            database    = client.GetDatabase("local");
            collection  = database.GetCollection<Employee>("employees");
        }

        public void AddEmployee(Employee emp)
        {
            this.collection.InsertOneAsync(emp);
        }

        public void DeleteEmployee(int id)
        {
            var filter = Builders<Employee>.Filter.Eq("id", id);
            this.collection.DeleteOneAsync(filter);
        }

        public void UpdateEmployee(Employee emp)
        {
            var filter = Builders<Employee>.Filter.Eq("id", emp.Id);
            var update = Builders<Employee>.Update.Set("Name", emp.Name).Set("StartDate", emp.StartDate);
            var result = collection.UpdateOneAsync(filter, update);

            //return result;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> result = new List<Employee>();
            result.AddRange(this.collection.FindAsync(new BsonDocument()).Result.ToList());
            return result;
        }

        public Employee GetEmployee(int id)
        {
            var filter = Builders<Employee>.Filter.Eq("id", id);
            Employee employee = (Employee)this.collection.Find(filter);
            return employee;
        }
    }
}
