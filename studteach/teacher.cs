using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studteach;

namespace studteach
{
    public class Teacher : Person
    {
        public List<StudentWithAdvisor> Students { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Teaching:");
            foreach (var student in Students)
            {
                Console.WriteLine($" - {student.Name}");
            }
        }
    }
}
