using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Inheritance_and_Abstraction
{
    class Teacher : People
    {
        public List<Discpiline> Disciplines { get; set; }
        public Teacher(string name, List<Discpiline> disciplines, string details = null) : base(name, details)
        {
            this.Disciplines = disciplines;
        }
    }
}
