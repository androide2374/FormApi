using Domain.Entities;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using static Domain.Enumerados.Enums;

namespace Domain.Entities
{
    public class Question
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("id")]
        public string Id { get; set; }
        
        [BsonElement("questionText")]
        public string QuestionText { get; set; }

        [BsonElement("questionImage")]
        public string QuestionImage { get; set; }

        [BsonElement("questionType")]
        public QuestionTypes QuestionType { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updateAt")]
        public DateTime UpdateAt { get; set; }
        public virtual ICollection<Option> Options { get; set; }
    }
}
