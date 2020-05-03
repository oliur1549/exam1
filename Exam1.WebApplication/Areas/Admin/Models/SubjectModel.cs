using Exam1.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam1.WebApplication.Areas.Admin.Models
{
    public class SubjectModel : SubjectBaseModel
    {
        public SubjectModel(IStudentService subjectService) : base(subjectService) { }
        public SubjectModel() : base() { }

        public string Name { get; set; }
        public string RegistrationOpen { get; set; }

        public void Create()
        {
            var subject = new Subject
            {
                Name = this.Name,
                RegistrationOpen = this.RegistrationOpen
            };
            _studentService.CreateSubject(subject);
        }
    }
}
