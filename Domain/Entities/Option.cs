using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public partial class Option
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("id")]
        public string Id { get; set; }

        [BsonElement("optionImage")]
        public string OptionImage { get; set; }

        [BsonElement("optionText")]
        public string OptionText { get; set; }
    }
}
