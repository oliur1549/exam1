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
    public class StudentController : Controller
    {
        private readonly IConfiguration Configuration;
        public StudentController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            var model = new StudentModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(StudentModel studentModel)
        {
            studentModel.Create();
            return View(studentModel);
        }
    }
}