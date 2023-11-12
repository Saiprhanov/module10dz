using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calclass
{
    public class AdvancedCalculator : SimpleCalculator, ICalculatable, IStorable
    {
        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double SquareRoot(double a)
        {
            if (a < 0)
            {
                Console.WriteLine("Square root of a negative number is not a real number.");
                return 0;
            }
            return Math.Sqrt(a);
        }

        public void SaveState(string fileName)
        {
            // Реализация сохранения состояния в файл
            Console.WriteLine($"Saving state to file: {fileName}");
        }

        public void LoadState(string fileName)
        {
            // Реализация загрузки состояния из файла
            Console.WriteLine($"Loading state from file: {fileName}");
        }
    }
}
