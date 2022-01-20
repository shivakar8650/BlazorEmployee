using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Model
{
    public  class EmployeeModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; }
        [Required(ErrorMessage = "Enter the name")]
        public string name { get; set; }
        public string ProfileImage { get; set; }
        public int MyProperty { get; set; }
        [Required(ErrorMessage ="Gender is missing")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Deaprtment")]
        public string Department  { get; set; }
        public string Salary { get; set; }
        public string SatrtDate { get; set; }
        public string Note { get; set; }

    }
}
