using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studteach
{
    public class StudentWithAdvisor : Student
    {
        public Teacher Advisor { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Advisor: {Advisor.Name}");
        }
    }
}
