using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    abstract class Person : AgeInterface
    {
        public int ID{ get; set; }
        public string Name { get; set; }

        public int YearOfBirth { get; set; }
        public abstract string GetInfo();

        public int CalcAge() {
            return System.DateTime.Now.Year - YearOfBirth;
        }
    }

}
