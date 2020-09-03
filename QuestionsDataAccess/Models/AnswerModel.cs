using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace QuestionsDataAccess.Models
{
    [BsonIgnoreExtraElements]
    public class AnswerModel
    {
        [BsonElement("choice")]
        [Required]
        public string Choice { get; set; }

        [BsonElement("details")]
        [Required]
        public string Details { get; set; }
    }
}