using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(@"Создать метод для вычисления объема и площади поверхности куба по длине его ребра.");
            Console.WriteLine("");
            Console.Write("Введите ребро куба:");
            double Side = double.Parse(Console.ReadLine());

             
            GetCubeVolumeAndSurfacArea(Side, out double SurfaceArea, out double Volume);

            Console.WriteLine($"Объём куба:{Volume} , площадь поверхности: {SurfaceArea}");

            Console.ReadKey();
        }
    }
}
