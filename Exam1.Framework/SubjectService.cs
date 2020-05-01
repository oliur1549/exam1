using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Exam1.Framework
{
    public class SubjectService : ISubjectService, IDisposable
    {
        private ISubjectUnitofWork _sbjectUnitofWork;
        public SubjectService(ISubjectUnitofWork subjectUnitofWork)
        {
            _sbjectUnitofWork = subjectUnitofWork;
        }

        
        public void CreateSubject(Subject subject)
        {
            _sbjectUnitofWork.SubjectRepository.Add(subject);
            _sbjectUnitofWork.Save();
        }

        public void Dispose()
        {
            _sbjectUnitofWork?.Dispose();
        }
    }
}
