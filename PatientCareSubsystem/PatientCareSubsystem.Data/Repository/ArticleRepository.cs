using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using PatientCareSubsystem.Data.DataAccess;
using PatientCareSubsystem.Data.Models.Domain;


namespace PatientCareSubsystem.Data.Repository
{


    public class ArticleRepository : IArticleRepository
    {
        private readonly ISqlDataAccess _db;

        public ArticleRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Article>> GetArticlesAsync()
        {
           string query = "sp_get_articles";
           return await _db.GetData<Article, dynamic>(query, new { });
        }
    }
}