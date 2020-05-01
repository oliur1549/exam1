using Entity.Framework;
using Exam1.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Framework
{
    public class SUbjectRepository : Repository<Subject, int, DatabaseContext>, ISubjectRepository
    {
        public SUbjectRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
