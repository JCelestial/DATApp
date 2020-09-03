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
    public class QuestionRepository : IQuestionRepository
    {
        #region Context and Constructor
        private readonly IQuestionContext _context;

        public QuestionRepository(IQuestionContext context)
        {
            _context = context;
        }
        #endregion

        #region Fetch all Questions
        public async Task<IEnumerable<Question>> GetAllQuestions()
        {
            return await _context.Questions.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<Question> GetQuestion(string id)
        {
            FilterDefinition<Question> filter = Builders<Question>.Filter.Eq(x => x.QuestionId, id);
            return await _context.Questions.Find(filter).FirstOrDefaultAsync();
        }

        #endregion

        // Next Features to implement
        // Drill down into a question for more details
        // go to the next question

        //public async Task<QuestionModel> GetQuestion()
        //{
        //}

        //public void NextQuestion()
        //{

        //}
    }
}
