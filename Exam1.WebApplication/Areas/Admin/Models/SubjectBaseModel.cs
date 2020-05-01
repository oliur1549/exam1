using Autofac;
using Exam1.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam1.WebApplication.Areas.Admin.Models
{
    public class SubjectBaseModel : IDisposable
    {
        protected readonly ISubjectService _studentService;
        public SubjectBaseModel(ISubjectService studentService)
        {
            _studentService = studentService;
        }
        public SubjectBaseModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<ISubjectService>();
        }
        public void Dispose()
        {
            _studentService?.Dispose();
        }
    }
}
