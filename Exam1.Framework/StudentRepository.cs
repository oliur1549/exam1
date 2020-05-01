using Entity.Framework;
using Exam1.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Framework
{
    public class StudentRepository : Repository<Student, int, DatabaseContext>, IStudentRepository
    {
        public StudentRepository(DatabaseContext context) : base(context)
        {

        }
    }

}
