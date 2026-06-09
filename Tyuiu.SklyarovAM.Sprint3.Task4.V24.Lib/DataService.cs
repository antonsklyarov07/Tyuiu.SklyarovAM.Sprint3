using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SklyarovAM.Sprint3.Task4.V24.Lib
{
    public class DataService : ISprint3Task4V24
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1.0;
            for (int x = startValue; x <= stopValue; x += 1)
            {
                if (x == 0)
                {
                    break;
                }
                double y = (Math.Sin(x) / x) + 2;
                product *= y;
            }
            return product;
        }
    }
}
