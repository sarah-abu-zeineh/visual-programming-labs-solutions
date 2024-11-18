using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Employee : Person
    {
        public int Salary { get; set; }

        public float CalcBonus() {
            return Salary * 0.15f;
        }

        public override string GetInfo()
        {
            string employeetInfo = $"Employee\n" +
                $"Name -> {this.Name}, ID -> {this.ID}\n" +
                $"Salary -> {Salary}\n" +
                $"Bonus -> {this.CalcBonus()}";

            return employeetInfo;
        }
    }
}
