using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Data
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
