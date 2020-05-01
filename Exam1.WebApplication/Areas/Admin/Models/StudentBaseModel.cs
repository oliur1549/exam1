using Autofac;
using Exam1.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam1.WebApplication.Areas.Admin.Models
{
    public class StudentBaseModel : IDisposable
    {
        protected readonly IStudentService _studentService;
        public StudentBaseModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public StudentBaseModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }
        public void Dispose()
        {
            _studentService?.Dispose();
        }
    }
}
