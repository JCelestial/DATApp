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
        #region CONTEXT AND CONSTRUCTOR
        private readonly IQuestionContext _context;

        public QuestionRepository(IQuestionContext context)
        {
            _context = context;
        }
        #endregion

        #region FETCH QUESTIONS
        public async Task<IEnumerable<QuestionEntity>> GetAllQuestions()
        {
            IEnumerable<QuestionEntity> qList = new List<QuestionEntity>();
            try
            {
                qList =  await _context.Questions.Find(new BsonDocument()).ToListAsync();
                var sorted = qList.OrderBy(x => x.QuestionId).ToList();
                return sorted;
            }
            catch
            {
                qList = null;
                return qList;
            }


            // Refactor later to retreive based on section and/or QuestionID

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

        #region SUBMIT EXAM
        public async Task<IEnumerable<string>> FetchCorrectAns()
        {
            IEnumerable<QuestionEntity> qEntity = new List<QuestionEntity>();
            ICollection<string> qAns = new List<string>();
            try
            {
                qEntity = await GetAllQuestions();
                if (qEntity != null)
                {
                    foreach (var q in qEntity)
                    {
                        qAns.Add(q.CorrectAns);
                    }
                    return qAns;
                }
                else
                {
                    throw new Exception(message: "Correct Answer array was not properly");
                }
            }
            catch
            {
                qAns = null;
                return qAns;
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
