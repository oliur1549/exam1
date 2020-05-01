using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
