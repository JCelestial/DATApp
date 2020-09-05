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
        public async Task<IEnumerable<QuestionEntity>> GetAllQuestions()
        {
            var qList =  await _context.Questions.Find(new BsonDocument()).ToListAsync();
            var sorted = qList.OrderBy(x => x.QuestionId).ToList();
            return sorted;

        }

        public async Task<QuestionEntity> GetQuestion(Traversal trav)
        {
            FilterDefinition<QuestionEntity> curr = Builders<QuestionEntity>.Filter.Eq(x => x.QuestionId, trav.CurrId);
            try
            {
                if (trav.TravId != 0)
                {
                    FilterDefinition<QuestionEntity> filter = Builders<QuestionEntity>.Filter.Eq(x => x.QuestionId, trav.TravId);
                    var foundQuestion = await _context.Questions.Find(filter).FirstAsync();
                    return foundQuestion;
                }
                else
                {
                    return await _context.Questions.Find(curr).FirstOrDefaultAsync();
                }
            }
            catch
            {
                return await _context.Questions.Find(curr).FirstOrDefaultAsync();
            }
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
