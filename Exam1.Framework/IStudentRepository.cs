using Entity.Framework;
using Exam1.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Framework
{
    public interface IStudentRepository : IRepository<Student, int, DatabaseContext>
    {
        
    }
}
