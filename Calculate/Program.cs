using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calclass;

namespace Calculate
{
    internal class Program
    {
        static void Main()
        {
            SimpleCalculator simpleCalc = new SimpleCalculator();
            AdvancedCalculator advancedCalc = new AdvancedCalculator();

            double a = 10;
            double b = 5;

            double resultSimpleAdd = simpleCalc.Add(a, b);
            double resultSimpleSubtract = simpleCalc.Subtract(a, b);

            simpleCalc.PrintResult(resultSimpleAdd);
            simpleCalc.PrintResult(resultSimpleSubtract);

            double resultAdvancedMultiply = advancedCalc.Multiply(a, b);
            double resultAdvancedDivide = advancedCalc.Divide(a, b);

            advancedCalc.PrintResult(resultAdvancedMultiply);
            advancedCalc.PrintResult(resultAdvancedDivide);

            double resultAdvancedPower = advancedCalc.Power(a, b);
            double resultAdvancedSqrt = advancedCalc.SquareRoot(a);

            advancedCalc.PrintResult(resultAdvancedPower);
            advancedCalc.PrintResult(resultAdvancedSqrt);

            advancedCalc.SaveState("calculator_state.txt");
            advancedCalc.LoadState("calculator_state.txt");
        }
    }
}
