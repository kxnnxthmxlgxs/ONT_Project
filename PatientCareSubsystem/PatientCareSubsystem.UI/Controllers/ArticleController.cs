using Microsoft.AspNetCore.Mvc;
using PatientCareSubsystem.Data.Models.Domain;
using PatientCareSubsystem.Data.Repository;
using System.Threading.Tasks;

namespace PatientCareSubsystem.UI.Controllers 
{
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _articleRepo;

        public ArticleController(IArticleRepository articleRepo)
        {
            _articleRepo = articleRepo;
        }


        public async Task<IActionResult> Index()
        {
            var articles = await _articleRepo.GetArticlesAsync();
            return View(articles);
        }
    }
}