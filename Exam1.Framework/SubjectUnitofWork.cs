using Entity.Framework;
using Exam1.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Framework
{
    public class SubjectUnitofWork : UnitOfWork, ISubjectUnitofWork
    {
        
        public ISubjectRepository SubjectRepository { get; set; }
        public SubjectUnitofWork(DatabaseContext context, ISubjectRepository subjectRepository)
            : base(context)
        {
            
            SubjectRepository = subjectRepository;
        }
    }
}
