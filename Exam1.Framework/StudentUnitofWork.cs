using Entity.Framework;
using Exam1.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Framework
{
    public class StudentUnitofWork : UnitOfWork, IStdentUnitofWork
    {
        public ISubjectRepository SubjectRepository { get; set; }
        public StudentUnitofWork(DatabaseContext context, ISubjectRepository subjectRepository)
            : base(context)
        {

            SubjectRepository = subjectRepository;
        }
        public IStudentRepository StudentRepository { get; set; }
        public StudentUnitofWork(DatabaseContext context, IStudentRepository studentRepository)
            : base(context)
        {

            StudentRepository = studentRepository;
        }
    }
}
