using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam1.WebApplication.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Exam1.WebApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubjectController : Controller
    {
        private readonly IConfiguration _configuration;
        public SubjectController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            var model = new SubjectModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(SubjectModel studentModel)
        {
            studentModel.Create();
            return View(studentModel);
        }
    }
}