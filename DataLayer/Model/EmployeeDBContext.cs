
using DataLayer.Interface;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Model
{
    public class EmployeeDBContext : IEmployee
    {
        public readonly IMongoDatabase Db;
        public EmployeeDBContext(IOptions<Setting> options)
        {
            var client = new MongoClient(options.Value.Connectionstring);
            Db = client.GetDatabase(options.Value.DatabaseName);
        }
        public IMongoCollection<EmployeeModel> EmployeeCollection =>
            Db.GetCollection<EmployeeModel>("EmployeeBlazor");
        public List<EmployeeModel> GetAllEmployee()
        {
            return EmployeeCollection.Find(x => true).ToList();
        }

        public EmployeeModel GetemployeeDetails(string id)
        {
            var employee = EmployeeCollection.Find(x => x.id == id).FirstOrDefault();
            return employee;
        }
        public string Create(EmployeeModel employee)
        {
            EmployeeCollection.InsertOne(employee);
            return "Data stored";
        }

        public string  Delete(string id)
        {
            var employee = Builders<EmployeeModel>.Filter.Eq(x =>  x.id,id);
            EmployeeCollection.DeleteOne(employee);
            return "deleted succesfully";
        }
        public string Update(EmployeeModel employee)
        {
            EmployeeCollection.ReplaceOne(filter: g => g.id == employee.id, replacement: employee);
            return "update succesfully";
        }
    }
}
