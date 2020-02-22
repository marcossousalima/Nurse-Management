using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NurseManagement.Models;
using NurseManagement.Service;

namespace NurseManagement.Controllers
{
    public class HospitalController : Controller
    {
        private readonly HospitalService _hospitalService;
        private readonly string _prefix;

        public HospitalController(HospitalService hospitalService)
        {
            _hospitalService = hospitalService;
            _prefix = "hospital";
        }
        public IActionResult Index()
        {
            var result = _hospitalService.List(_prefix).ToList();
            return View(result);
        }

        public IActionResult Detail(Guid id)
        {
            var result = _hospitalService.Get($"{_prefix}/{id}");
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Hospital hospital)
        {
            var result = _hospitalService.Post($"{_prefix}", hospital);
            if (result == true)
                return RedirectToAction("Index", _hospitalService.List(_prefix));
            return View("Create", hospital);
        }

        public IActionResult Edit(Guid id)
        {
            var result = _hospitalService.Get($"{_prefix}/{id}");
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Guid id, Hospital hospital)
        {
            var result = _hospitalService.Put($"{_prefix}/{id}", hospital);
            if (result == true)
                return RedirectToAction("Index", _hospitalService.List(_prefix));
            return View("Edit", hospital);
        }

        public JsonResult Delete(int Id, Nurse nurse)
        {
            bool result = false;
            try
            {
                var resultado = _hospitalService.Delete($"{_prefix}/{nurse.Id}");
                result = true;
            }
            catch (Exception dex)
            {
                return Json(new { success = false, responseText = dex.Message });
            }
            return Json(new { success = false, responseText = "Registro Deletado Com Sucesso" });
        }
    }
}