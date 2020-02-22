using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NurseManagement.Models;
using NurseManagement.Service;

namespace NurseManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly HospitalService _hospitalService;
        private readonly NurseService _nurseService;
        private readonly string _prefixNurse;
        private readonly string _prefixHospital;

        public HomeController(NurseService nurseService, HospitalService hospitalService)
        {
            _nurseService = nurseService;
            _hospitalService = hospitalService;
            _prefixNurse = "nurse";
            _prefixHospital = "hospital";

        }
        public IActionResult Index()
        {
            var countHospital = _hospitalService.List(_prefixHospital).ToList();
            var countNurse = _nurseService.List(_prefixNurse).ToList();
            ViewBag.Hospitais = countHospital.Count();
            ViewBag.Nurses = countNurse.Count();
            return View();
        }
    }
}
