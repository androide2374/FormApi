using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities
{
    public partial class PersonResponse
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("id")]
        public string Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("lasName")]
        public string Lastname { get; set; }
        [BsonElement("document")]
        public string Document { get; set; }
        [BsonElement("birthData")]
        public DateTime BirthDate { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("mobile")]
        public string Mobile { get; set; }
        [BsonElement("createAt")]
        public DateTime CreateAt { get; set; }
        [BsonElement("updateAt")]
        public DateTime UpdateAt { get; set; }
    }
}
