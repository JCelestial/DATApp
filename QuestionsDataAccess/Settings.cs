using MongoDB.Driver;

namespace QuestionsDataAccess.Models
{
    public class Settings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
