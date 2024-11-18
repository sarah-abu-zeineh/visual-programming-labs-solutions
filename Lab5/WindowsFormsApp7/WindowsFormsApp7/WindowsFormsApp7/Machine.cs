using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Machine: AgeInterface
    {
        public int ID { get; set; }
        public float Price { get; set; }
        public int YearOfProduction { get; set; }

        public float CalcFinalPrice() {
            return Price * .2f;
        }
        public int CalcAge()
        {
            return System.DateTime.Now.Year - YearOfProduction;
        }
    }
}
