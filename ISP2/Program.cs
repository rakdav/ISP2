using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("Введите первое число:");
                //double a = double.Parse(Console.ReadLine());
                //Console.WriteLine("Введите второе число:");
                //double b =double.Parse(Console.ReadLine());
                //double sa = (a * a * a + b * b * b) / 2;
                //double sg = Math.Sqrt(Math.Abs(a)*Math.Abs(b)/2);
                //Console.WriteLine("Среднее арифметическое:{0:F2}",sa);
                //Console.WriteLine("Среднее геометрическое:{0:F2}",sg);

                //const double b = 4.2;
                //Console.Write("Введите число t:");
                //double t = double.Parse(Console.ReadLine());
                //double a = t + b * b * b;
                //double x = t * t * Math.Sqrt(Math.Abs(a+b));
                //double y = Math.Pow(Math.Log(x + a * a), 5);
                //Console.WriteLine("y={0:F2}", y);

                Console.WriteLine("Введите прибыль:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите себестоимость:");
                double b = double.Parse(Console.ReadLine());
                double rent = a * 100 / b;
                Console.WriteLine("Рентабельность {0:F2}%",rent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
