﻿using Microsoft.AspNetCore.Mvc;
using PatientCareSubsystem.Data.Models.Domain;
using PatientCareSubsystem.Data.Repository;

namespace PatientCareSubsystem.UI.Controllers
{
    public class SisterNurseController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        private readonly ISisterNurseRepository _sisterNurseRepo;

        public SisterNurseController(ISisterNurseRepository sisterNurseRepo)
        {
            _sisterNurseRepo = sisterNurseRepo;
        }

        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(SisterNurse sisterNurse)
        {
            var result = await _sisterNurseRepo.AddAsync(sisterNurse);
            if (result)
            {
                return RedirectToAction(nameof(DisplayAll));
            }
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            var sisterNurse = await _sisterNurseRepo.GetByIdAsync(id);
            if (sisterNurse == null)
            {
                return NotFound();
            }
            return View(sisterNurse);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SisterNurse sisterNurse)
        {
            var result = await _sisterNurseRepo.UpdateAsync(sisterNurse);
            if (result)
            {
                return RedirectToAction(nameof(DisplayAll));
            }
            return View();
        }

        public async Task<IActionResult> GetById(int id)
        {
            var sisterNurse = await _sisterNurseRepo.GetByIdAsync(id);
            if (sisterNurse == null)
            {
                return NotFound();
            }
            return View(sisterNurse);
        }

        public async Task<IActionResult> DisplayAll()
        {
            var sisterNurses = await _sisterNurseRepo.GetAllAsync();
            return View(sisterNurses);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _sisterNurseRepo.DeleteAsync(id);
            return RedirectToAction(nameof(DisplayAll));
        }
    }
}
