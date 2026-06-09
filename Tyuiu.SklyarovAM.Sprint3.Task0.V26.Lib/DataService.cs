using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SklyarovAM.Sprint3.Task0.V26.Lib
{
    public class DataService : ISprint3Task0V26
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1.0;
            for (int k = startValue; k <= stopValue; k++)
            {
                product *= Math.Pow(2, k) / (k + 1);
            }
            double p = product * Math.Cos(1.8);
            return Math.Round(p, 3);
        }
    }
}
