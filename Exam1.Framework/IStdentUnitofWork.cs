using Exam1.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Framework
{
    public interface IStdentUnitofWork : IUnitOfWork, IDisposable
    {
        IStudentRepository StudentRepository { get; set; }
        
    }
}
