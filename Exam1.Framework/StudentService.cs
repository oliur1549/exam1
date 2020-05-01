using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Exam1.Framework
{
    public class StudentService : IStudentService, IDisposable
    {
        private IStdentUnitofWork _stdentUnitofWork;
        public StudentService(IStdentUnitofWork stdentUnitofWork)
        {
            _stdentUnitofWork = stdentUnitofWork;
        }

        public void CreateStudent(Student student)
        {
            _stdentUnitofWork.StudentRepository.Add(student);
            _stdentUnitofWork.Save();
        }

        public void Dispose()
        {
            _stdentUnitofWork?.Dispose();
        }
    }
}
