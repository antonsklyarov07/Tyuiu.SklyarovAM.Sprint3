using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SklyarovAM.Sprint3.Task1.V5.Lib;

namespace Tyuiu.SklyarovAM.Sprint3.Task1.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Старт шага:" + startValue);
            Console.WriteLine("Конец шага:" + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
