using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Framework
{
    public interface ISubjectService : IDisposable
    {
        
        void CreateSubject(Subject subject);
    }
}
