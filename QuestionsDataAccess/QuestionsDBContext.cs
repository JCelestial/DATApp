using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;

namespace QuestionsDataAccess.Models
{
    public class QuestionsDBContext : IQuestionContext
    {
        private readonly IMongoDatabase mongoDatabase;

        public QuestionsDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            mongoDatabase = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<QuestionEntity> Questions => mongoDatabase.GetCollection<QuestionEntity>("Questions");

    }
}
