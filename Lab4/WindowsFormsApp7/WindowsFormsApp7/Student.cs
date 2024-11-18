using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Student : Person
    {   
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }

        public float CalcAvg() {
            float avg = (Mark1 + Mark2) / 2.0f;

            return avg;
        }

        public override string GetInfo()
        {
            string studentInfo = $"Student\n{base.GetInfo()}\n" +
                $"Mark1 -> {Mark1}, Mark2 -> {Mark2}"+
                $"\nAverage -> {this.CalcAvg()}";

            return studentInfo;
        }
    }
}
