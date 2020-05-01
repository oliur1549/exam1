using Exam1.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam1.WebApplication.Areas.Admin.Models
{
    public class StudentModel : StudentBaseModel
    {
        public StudentModel(IStudentService studentService) : base(studentService) { }
        public StudentModel() : base() { }

        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public void Create()
        {
            var student = new Student
            {
                Name = this.Name,
                Username = this.Username,
                Email = this.Email
            };
            _studentService.CreateStudent(student);
        }
    }
}
