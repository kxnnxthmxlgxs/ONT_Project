using PatientCareSubsystem.Data.Models.Domain;

namespace PatientCareSubsystem.Data.Repository
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetArticlesAsync();
    }
}