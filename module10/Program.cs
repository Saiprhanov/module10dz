using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studteach;

namespace module10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[10]; // Предположим, что у нас есть массив из 10 объектов

            int personCount = 0;
            int studentCount = 0;
            int teacherCount = 0;

            foreach (var person in people)
            {
                if (person is Teacher)
                {
                    teacherCount++;
                }
                else if (person is Student)
                {
                    studentCount++;
                    if (person is StudentWithAdvisor studentWithAdvisor)
                    {
                        // Переводим студентов на следующий курс, например, увеличиваем возраст на 1
                        studentWithAdvisor.Age++;
                    }
                }
                else
                {
                    personCount++;
                }
            }

            Console.WriteLine($"People: {personCount}, Students: {studentCount}, Teachers: {teacherCount}");
            Console.ReadKey();
        }
    }
}
