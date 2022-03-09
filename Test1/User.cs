using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test1
{
    public class User
    {
        [BsonId]
        public Guid Id { get; set; }

        [BsonRequired]
        public string IDNumber { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        [BsonRequired]
        public string Surname { get; set; }

        //[BsonDateTimeOptions(DateOnly = true, Kind = DateTimeKind.Utc, Representation = MongoDB.Bson.BsonType.DateTime)]
        public string DateOfBirth { get; set; }

    }
}
