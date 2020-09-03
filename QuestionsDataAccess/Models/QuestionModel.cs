using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace QuestionsDataAccess.Models
{
    [BsonIgnoreExtraElements]
    public class QuestionModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("questionId")]
        [Required]
        public string QuestionId { get; set; }

        [BsonElement("question")]
        [Required]
        public string Question { get; set; }      

        [BsonElement("answers")]
        [Required]
        public List<AnswerModel> AnswerChoices { get; set; } 

        [BsonElement("correctAns")]
        [Required]
        public string CorrectAns { get; set; } 

        [BsonElement("explanation")]
        [Required]
        public string Explanation { get; set; }

        [BsonElement("section")]
        [Required]
        public string Section { get; set; }

        [BsonElement("subject")]
        [Required]
        public string Subject { get; set; }

        [BsonElement("isBookmarked")]
        [Required]
        public bool IsBookmarked { get; set; }

        [BsonElement("rating")]
        [Required]
        public string Rating { get; set; }

        [BsonElement("difficulty")]
        [Required]
        [Range(1,5, ErrorMessage = "Number should be between 1 to 5")]
        public byte Difficulty { get; set; }
    }
}