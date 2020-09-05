using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace QuestionsDataAccess.Models
{
    [BsonIgnoreExtraElements]
    public class QuestionEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("questionID")]
        [Required]
        public int QuestionId { get; set; }

        [BsonElement("question")]
        [Required]
        public string QuestionString { get; set; }

        [BsonElement("answers")]
        [Required]
        public List<Answer> AnswerChoices { get; set; }

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