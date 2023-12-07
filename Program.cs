using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float PI = 3.14f;
            Console.Write("Nhap ban kinh r = ");
            float radius = float.Parse(Console.ReadLine());

            float chuViHinhTron = (radius * 2) * PI;
            float dienTichHinhTron = radius*radius*PI;

            Console.WriteLine("Chu vi Hinh Tron voi R = {0} la {1}",radius,chuViHinhTron);
            Console.WriteLine("Dien tich Hinh Tron voi R = {0} la {1}", radius, dienTichHinhTron);

            Console.ReadKey();
        }
    }
}
