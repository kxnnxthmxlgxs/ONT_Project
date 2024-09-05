using PatientManagementSystem.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using PatientManagementSystem.Data.Models.Domain;
using PatientManagement.Data.Repository;

namespace PatientManagementSystem.Controllers
   
{
    public class PatientsController : Controller 
    {
        private readonly IPatientRepository _patientRepository;
        
        public PatientsController (IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public async Task<IActionResult> Add()
        {
            return View();
        }
    }
}
