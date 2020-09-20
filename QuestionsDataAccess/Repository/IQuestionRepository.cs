using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QuestionsDataAccess.Models;

namespace QuestionsDataAccess.Repository
{
    public interface IQuestionRepository
    {
        Task<IEnumerable<QuestionEntity>> GetAllQuestions();
        Task<QuestionEntity> GetQuestion(Traversal trav);
        Task<IEnumerable<string>> FetchCorrectAns();
    }
}
