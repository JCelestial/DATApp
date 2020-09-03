using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsMVC.Models
{
    public class Question
    {
        public ObjectId Id { get; set; }
        public string QuestionString { get; set; }
        public List<Answer> AnswerChoices { get; set; }
        public string CorrectAns { get; set; }
        public string Explanation { get; set; }
        public string Section { get; set; }
        public string Subject { get; set; }
        public bool IsBookmarked { get; set; }
        public string Rating { get; set; }
        public byte Difficulty { get; set; }
    }
}