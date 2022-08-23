using System;
using MongoDB.Bson.Serialization.Attributes;

namespace LomasFormApi.Models.Request
{
    public class PersonRequest
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Document { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}

