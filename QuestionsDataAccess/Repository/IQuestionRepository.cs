using System.Collections.Generic;
using System.Threading.Tasks;
using QuestionsDataAccess.Models;

namespace QuestionsDataAccess.Repository
{
    public interface IQuestionRepository
    {
        Task<IEnumerable<QuestionModel>> GetAllQuestions();
        Task<QuestionModel> GetQuestion(string id);
    }
}