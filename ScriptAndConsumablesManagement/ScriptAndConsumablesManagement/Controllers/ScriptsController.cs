using Microsoft.AspNetCore.Mvc;
using ScriptAndConsumablesManagement.Data.Models.Domain;
using ScriptAndConsumablesManagement.Data.Models.Services;
using ScriptAndConsumablesManagement.Data.Models.ViewModels;
using ScriptAndConsumablesManagement.Data.Repository;

namespace ScriptAndConsumablesManagement.Controllers
{
    public class ScriptsController : Controller
    {
        private readonly IScriptDetailsRepo _SDRepo;
        private readonly PDFService _pdfservice;
        public ScriptsController(IScriptDetailsRepo sDRepo, PDFService pdfservice)
        {
            _SDRepo = sDRepo;
            _pdfservice = pdfservice;
        }

        //makes downloadable pdf
        public async Task<IActionResult> PrintScript(int id)
        {
            ScriptDetailsViewModel scriptDetailsViewModel = await _SDRepo.GetByIdAsync(id);
            byte[] pdfBytes = _pdfservice.GeneratePDF(scriptDetailsViewModel);
            return File(pdfBytes, "application/pdf", "Prescription.pdf");
        }

        //Gets the count for each script status for the dashboard
        public async Task<IActionResult> Dashboard()
        {
            //returns count for all scripts based on status
            var newcount = await _SDRepo.GetAllAsync('N');
            var processedcount = await _SDRepo.GetAllAsync('P');
            var receivedcount = await _SDRepo.GetAllAsync('R');

            var viewModel = new ScriptStatusCountViewModel
            {
                NewCount = newcount.Count(),
                ProcessedCount = processedcount.Count(),
                ReceivedCount = receivedcount.Count(),
            };
            return View(viewModel);
        }

        // returns a list of new scripts
        public async Task<IActionResult> DisplayScriptListN()
        {
            var scriptDetails = await _SDRepo.GetAllAsync('N');
            return View(scriptDetails);
        }

        // returns a list of processed scripts and allows for searching based on date
        public async Task<IActionResult> DisplayScriptListP(DateTime? searchDate = null)
        {
            if (searchDate.HasValue)
            {
                var scriptDetails = await _SDRepo.GetByDateAsync(searchDate.Value);
                return View(scriptDetails);
            }
            else
            {
                var scriptDetails = await _SDRepo.GetAllAsync('P');
                return View(scriptDetails);
            }
        }
        // returns a list of Received scripts
        public async Task<IActionResult> DisplayScriptListR()
        {
            var scriptDetails = await _SDRepo.GetAllAsync('R');
            return View(scriptDetails);
        }

        // returns the details of each script based on Id
        public async Task<IActionResult> DetailsN(int id)
        {
            var script = await _SDRepo.GetByIdAsync(id);
            return View(script);
        }
        public async Task<IActionResult> DetailsP(int id)
        {
            var script = await _SDRepo.GetByIdAsync(id);
            return View(script);
        }
        public async Task<IActionResult> DetailsR(int id)
        {
            var script = await _SDRepo.GetByIdAsync(id);
            return View(script);
        }


        // Deals with sending the script to the pharmacy (Changes script status from N to P)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendScript(int Id)
        {
            try
            {
                var scriptDetails = new Script { ScriptID = Id };
                bool updateRecord = await _SDRepo.UpdateAsync(scriptDetails);
                if (updateRecord)
                {
                    TempData["msg"] = "Successfully Updated";
                }
                else
                {
                    TempData["msg"] = "Successfully failed";
                }
            }
            catch (Exception)
            {
                TempData["msg"] = "Successfully failed";
            }
            return RedirectToAction("Dashboard");
        }

        // Marks scripts as Received (Changes script status from P to R)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReceivedScripts(int Id)
        {
            try
            {
                var scriptDetails = new Script { ScriptID = Id };
                bool updateRecord = await _SDRepo.ReceivedScriptsAsync(scriptDetails);
                if (updateRecord)
                {
                    TempData["msg"] = "Successfully Updated";
                }
                else
                {
                    TempData["msg"] = "Successfully failed";
                }
            }
            catch (Exception)
            {
                TempData["msg"] = "Successfully failed";
            }
            return RedirectToAction("Dashboard");
        }
    }

}