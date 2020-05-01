using Exam1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam1.Framework
{
    public class Subject : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationOpen { get; set; }
        
    }
}
