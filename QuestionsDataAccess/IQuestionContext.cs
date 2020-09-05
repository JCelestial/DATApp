using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using QuestionsDataAccess.Models;

namespace QuestionsDataAccess
{
    public interface IQuestionContext
    {
        IMongoCollection<QuestionEntity> Questions { get; }
    }
}
