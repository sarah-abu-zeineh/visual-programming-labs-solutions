using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Person
    {
        public int ID{ get; set; }
        public string Name { get; set; }

        public virtual string GetInfo() {
            string personInfo = $"ID -> {ID}, Name -> {Name}";

            return personInfo;
        }
    }

}
