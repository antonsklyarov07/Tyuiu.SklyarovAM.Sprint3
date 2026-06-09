using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SklyarovAM.Sprint3.Task1.V5.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1.0;
            int k = startValue;
            while (k < stopValue)
            {
                p *= Math.Cos(0.1) + Math.Pow(k, -2);
                k++;
            }
            return Math.Round(p,3);
        }
    }
}
