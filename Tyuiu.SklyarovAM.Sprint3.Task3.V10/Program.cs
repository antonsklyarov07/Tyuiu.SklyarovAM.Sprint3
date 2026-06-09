using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SklyarovAM.Sprint3.Task3.V10.Lib;
namespace Tyuiu.SklyarovAM.Sprint3.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "gdfppf vfppt p";
            char item = 'p';
            Console.WriteLine("Исходная строка - " +  value);
            Console.WriteLine("Искомый символ - " + item);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Строка без символа - " + ds.DeleteCharInString(value, item));
            Console.ReadKey();
        }
    }
}
