using MongoDB.Driver;
using QuestionsDataAccess.Models;

namespace QuestionsDataAccess
{
    public interface IQuestionContext
    {
        IMongoCollection<QuestionModel> Questions { get; }
    }
}