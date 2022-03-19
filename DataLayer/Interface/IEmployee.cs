using DataLayer.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interface
{
    public interface IEmployee
    {
       public  IMongoCollection<EmployeeModel> EmployeeCollection { get; }
       public  List<EmployeeModel> GetAllEmployee();
       public  EmployeeModel GetemployeeDetails(string id);
       public  string Create(EmployeeModel employee);
       public  string Update(EmployeeModel employee);
       public string Delete(string id);


    }
}
