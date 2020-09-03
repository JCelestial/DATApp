using MongoDB.Bson;
using MongoDB.Driver;
using QuestionsDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsDataAccess.Repository
{
    public class QuestionsRepository : IQuestionRepository
    {
        private readonly IQuestionContext _context;

        public QuestionsRepository(IQuestionContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<QuestionModel>> GetAllQuestions()
        {
            return await _context.Questions.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<QuestionModel> GetQuestion(string id)
        {
            FilterDefinition<QuestionModel> filter = Builders<QuestionModel>.Filter.Eq(x => x.QuestionId, id);
            return await _context.Questions.Find(filter).FirstOrDefaultAsync();
        }
    }
}