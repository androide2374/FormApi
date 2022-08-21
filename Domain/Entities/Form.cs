using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Form
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("id")]
        public string Id { get; set; }
        [BsonElement("description")]
        [BsonRepresentation(BsonType.String)]
        public string Description { get; set; } = null!;
        [BsonElement("stared")]
        [BsonRepresentation(BsonType.Boolean)]
        public bool Stared { get; set; }
        [BsonElement("formType")]
        public int FormType { get; set; }
        [BsonElement("createBy")]
        public string CreatedBy { get; set; }
        [BsonElement("name")]
        public string Name { get; set; } = null!;
        [BsonElement("createdAt")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedAt { get; set; }
        [BsonElement("updateAt")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime UpdatedAt { get; set; }
        [BsonElement("lastUpdateBy")]
        public string LastUpdateBy { get; set; }

        [BsonElement("questions")]
        public virtual ICollection<Question> Questions { get; set; }
        [BsonElement("userFormPermisions")]
        public virtual ICollection<UserFormPermision> UserFormPermisions { get; set; }
    }
}
