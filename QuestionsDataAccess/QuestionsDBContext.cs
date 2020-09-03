using MongoDB.Driver;
using Microsoft.Extensions.Options;
using QuestionsDataAccess.Models;

namespace QuestionsDataAccess
{
    public class QuestionsDBContext : IQuestionContext
    {
        private readonly IMongoDatabase mongoDatabase;

        public QuestionsDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            mongoDatabase = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<QuestionModel> Questions => mongoDatabase.GetCollection<QuestionModel>("Questions");
    }
}