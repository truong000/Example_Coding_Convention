using System;

namespace QuadraticEquation2
{
    class Program
    {
        /*
         * giai phương trinh bac 2: ax^2 * bx + c = 0
         * a: he so bac 2
         * b: he so bac 1
         * c: so hang tu do
         */
        static void QuadraticEquation2(float a, float b, float c)
        {
            //Kiem tra cac he so
            if(a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co mot nghiem: x = {0}", (-c / b));
                }
                return;
            }
            //Tinh delta
            float delta = ((b * b) - (4 * a * c));
            float x1, x2;
            //Tinh nghiem
            if(delta > 0)
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.Write("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.Write("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
        /*
         *Ham chinh
         */
        static void Main(string[] args)
        {
            //Khai bao 3 bien
            float a, b, c;
            Console.Write("Nhap he so a = ");
            String valA = Console.ReadLine();
            a = Convert.ToInt32(valA);
            Console.Write("Nhap he so b = ");
            String valB = Console.ReadLine();
            b = Convert.ToInt32(valB);
            Console.Write("Nhap he so c = ");
            String valC = Console.ReadLine();
            c = Convert.ToInt32(valC);
            Console.WriteLine("Giai phuong trinh bac 2: {0}x^2 + {1}x + {2} = 0", valA, valB, valC);
            QuadraticEquation2(a, b, c);
        }
    }
}
