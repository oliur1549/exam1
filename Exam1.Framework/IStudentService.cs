using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Framework
{
    public interface IStudentService : IDisposable
    {
        void CreateStudent(Student student);
        
    }
}
