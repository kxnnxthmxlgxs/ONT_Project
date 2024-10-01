using System.ComponentModel.DataAnnotations;

namespace PatientCareSubsystem.Data.Models.Domain
{
    public class Article 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Details { get; set; }
        public string Preview { get; set; }
        public DateTime PublishedDate { get; set; }
        public string ImageUrl { get; set; }

    }
    
}
