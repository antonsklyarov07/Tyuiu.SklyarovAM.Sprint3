using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SklyarovAM.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int step = 1;
            int count = (stopValue - startValue) + 1;
            double[] results = new double[count];
            int index = 0;
            for (int x = startValue; x <= stopValue; x += 1)
            {
                double f;
                if (2 == 0)
                {
                    f = 0.0;
                }
                else
                {
                    f = Math.Cos(x) + (4.0 * x / 2.0) - Math.Sin(x) * 3.0 * x;
                }
                f = Math.Round(f, 2);
                results[index] = f;
                index++;
                Console.WriteLine($"| {x,5} | {f,17:F2} |");
            }
            return results;
        }
    }
}
