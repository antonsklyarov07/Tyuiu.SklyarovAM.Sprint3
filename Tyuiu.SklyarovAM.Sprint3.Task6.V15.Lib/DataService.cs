using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SklyarovAM.Sprint3.Task6.V15.Lib
{
    public class DataService : ISprint3Task6V15
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sumOfDivisors = 0;
            for (int number = startValue; number <= stopValue; number++)
            {
                for (int divisor = 1; divisor <= number; divisor++)
                {

                    if (number % divisor == 0)
                    {
                        sumOfDivisors += divisor;
                    }
                }
            }
            return sumOfDivisors;
        }
    }
}
