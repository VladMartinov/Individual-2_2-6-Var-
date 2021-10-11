using System;

namespace _222
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Номер 1");
            double x, y, a, dd, kk;
            Console.WriteLine("Введите значение x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = double.Parse(Console.ReadLine());
            dd = Math.Cos(x - (Math.PI / 6));
            if (dd <= -1 | dd >= 1)
            { Console.WriteLine("Косинус в числителе не можит быть больше 1 или меньше -1"); }
            else
            {
                kk = Math.Pow(Math.Cos(y), 2);
                if (kk <= 0 | kk >= 1)
                {
                    Console.WriteLine("Синус в знаменателе не можит быть больше 1 или меньше 0");
                }
                else
                {
                    a = 2 * Math.Cos(x - (Math.PI / 6)) / (1 / 2 + Math.Pow(Math.Sin(y), 2));
                    Console.WriteLine("Ответ:" + a);
                }
            }




            Console.WriteLine("Номер 2");
            double z, b;
            Console.WriteLine("Введите значение z");
            z = double.Parse(Console.ReadLine());
           
            b = 1 + ((z * z) / 3 + (z * z) / 5);   //z может быть любое число т.к. z∉R
            Console.WriteLine("Ответ:"+b);
            
            
        }
    }
}
