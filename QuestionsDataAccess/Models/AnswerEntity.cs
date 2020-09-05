using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuestionsDataAccess.Models
{
    [BsonIgnoreExtraElements]
    public class Answer
    {
        [BsonElement("choice")]
        [Required]
        public string Choice { get; set; }

        [BsonElement("details")]
        [Required]
        public string Details { get; set; }
    }
}