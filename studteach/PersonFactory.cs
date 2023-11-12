using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studteach
{
    public static class PersonFactory
    {
        private static Random random = new Random();

        public static Person RandomPerson()
        {
            var types = new[] { typeof(Person), typeof(Student), typeof(Teacher) };
            var index = random.Next(types.Length);
            return RandomInstance(types[index]);
        }

        public static Student RandomStudent()
        {
            return (Student)RandomInstance(typeof(Student));
        }

        public static Teacher RandomTeacher()
        {
            return (Teacher)RandomInstance(typeof(Teacher));
        }

        private static Person RandomInstance(Type type)
        {
            if (type == typeof(Person))
            {
                return new Person { Name = "Random Person", Age = random.Next(18, 60) };
            }
            else if (type == typeof(Student))
            {
                return new Student { Name = "Random Student", Age = random.Next(18, 30) };
            }
            else if (type == typeof(Teacher))
            {
                return new Teacher { Name = "Random Teacher", Age = random.Next(25, 65) };
            }

            return null;
        }
    }

}
