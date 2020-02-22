using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NurseManagement.Models;
using NurseManagement.Service;

namespace NurseManagement.Controllers
{
    public class NurseController : Controller
    {
        private readonly HospitalService _hospitalService;
        private readonly NurseService _nurseService;
        private readonly string _prefix;
        private readonly string _prefixHospital;

        public NurseController(NurseService nurseService)
        {
            _nurseService = nurseService;
            _prefix = "nurse";
            _prefixHospital = "hospital";

        }

        public IActionResult Index()
        {
            var result = _nurseService.List(_prefix).ToList();
            return View(result);
        }

        public IActionResult Detail(Guid id)
        {
            var result = _nurseService.Get($"{_prefix}/{id}");
            return View(result);
        }

        public IActionResult Create()
        {
            ListHospital();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Nurse nurse)
        {
            var result = _nurseService.Post($"{_prefix}", nurse);
            if (result == true)
                return RedirectToAction("Index", _nurseService.List(_prefix));
            return View("Create", nurse);
        }

        public IActionResult Edit(Guid id)
        {
            ListHospital();
            var result = _nurseService.Get($"{_prefix}/{id}");
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Guid id, Nurse nurse)
        {
            var result = _nurseService.Put($"{_prefix}/{id}", nurse);
            if (result == true)
                return RedirectToAction("Index", _nurseService.List(_prefix));
            return View("Edit", nurse);
        }

        public JsonResult Delete(int Id, Nurse nurse)
        {
            bool result = false;
            try
            {
                var resultado = _nurseService.Delete($"{_prefix}/{nurse.Id}");
                result = true;
            }
            catch (Exception dex)
            {
                return Json(new { success = false, responseText = dex.Message });
            }
            return Json(new { success = false, responseText = "Registro Deletado Com Sucesso" });
        }

        public void ListHospital()
        {
            ViewBag.Hospital = "";
            var result = _nurseService.ListHospital(_prefixHospital).ToList();
            ViewBag.Hospital = result;
        }
    }
}